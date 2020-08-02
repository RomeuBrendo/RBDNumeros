using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Infra.Repositories.Transactions;
using System;
using System.Windows.Forms;

namespace RBDNumeros.Viwer.Formulario.Categoria
{
    public partial class frmCategoria : MetroFramework.Forms.MetroForm
    {
        private IServiceCategoria _serviceCategoria;
        private IUnitOfWork _unitOfWork;
        public frmCategoria()
        {
            InitializeComponent();
            ConsultarDepedencias();
            dataGridCategoria.AutoGenerateColumns = false;
            AtualizaGrid("");
        }

        void ConsultarDepedencias()
        {
            _serviceCategoria = (IServiceCategoria)Program.ServiceProvider.GetService(typeof(IServiceCategoria));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));
        }
        public void AtualizaGrid(string categoria)
        {
            dataGridCategoria.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridCategoria.DataSource = null;

            if(categoria == "")
                dataGridCategoria.DataSource = _serviceCategoria.ListarCategoria("");
            else
                dataGridCategoria.DataSource = _serviceCategoria.ListarCategoria(categoria);

            dataGridCategoria.Update();
            dataGridCategoria.Refresh();

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _unitOfWork.SaveChanges();
            MessageBox.Show("Alteração Salva com Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCategoria_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
                btnSalvar.PerformClick();

            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            
            if (txtPesquisar.Text.Length > 0)
                AtualizaGrid(txtPesquisar.Text);
            else
                AtualizaGrid("");
        }

    }
}

using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Infra.Repositories.Transactions;
using RBDNumeros.Viwer.Toast;
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
            try
            {
                _unitOfWork.SaveChanges();
                frmToast toast = new frmToast("Alteração Salva com Sucesso!!", "Okay");
                toast.Show();
                this.Close();
            }
            catch (Exception)
            {
                frmToast taoastErro = new frmToast("Erro ao Salvar informações no Banco de dados", "Erro");
                taoastErro.Show();
                this.Focus();
            }

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

        private void dataGridCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
                e.Handled = true;
        }
    }
}

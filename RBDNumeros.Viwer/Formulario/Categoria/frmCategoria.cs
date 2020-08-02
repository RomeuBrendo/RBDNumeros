using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Infra.Repositories.Transactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            AtualizaGrid();
        }

        void ConsultarDepedencias()
        {
            _serviceCategoria = (IServiceCategoria)Program.ServiceProvider.GetService(typeof(IServiceCategoria));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));
        }
        public void AtualizaGrid()
        {
            dataGridCategoria.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridCategoria.DataSource = null;

            dataGridCategoria.DataSource = _serviceCategoria.ListarCategoria();

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
    }
}

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

namespace RBDNumeros.Viwer.Formulario.Configuracao
{
    public partial class frmTempoSla : MetroFramework.Forms.MetroForm
    {
        private IServiceSla _serviceSla;
        private IUnitOfWork _unitOfWork;
        public frmTempoSla()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            ConsultarDepedencias();
            CarregarTela();
        }

        void ConsultarDepedencias()
        {
            _serviceSla = (IServiceSla)Program.ServiceProvider.GetService(typeof(IServiceSla));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));


        }

        void CarregarTela()
        {
            var sla = _serviceSla.ObterRegistro();

            txtDentroSla.Text = sla.Dentro.ToString();
            txtAcima20.Text = sla.Acima20.ToString();
            txtEstourado.Text = sla.Estourado.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDentroSla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtAcima20.Focus();
        }

        private void txtAcima20_Click(object sender, EventArgs e)
        {
            
        }

        private void txtAcima20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtEstourado.Focus();
        }

        private void txtEstourado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSalvar.PerformClick();


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("G2","titulo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);





        }

        private void frmTempoSla_Load(object sender, EventArgs e)
        {

        }
    }
}

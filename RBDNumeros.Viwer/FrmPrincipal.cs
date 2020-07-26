using Microsoft.Extensions.DependencyInjection;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Domain.Services;
using RBDNumeros.Infra.Repositories;
using RBDNumeros.Infra.Repositories.Transactions;
using RBDNumeros.Viwer.Formulario.Configuracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBDNumeros.Viwer
{
    public partial class FrmPrincipal : Form
    {
        private IServiceTicket _serviceTicket;
        private IUnitOfWork _unitOfWork;

        void ConsultarDepedencias()
        {
            _serviceTicket = (IServiceTicket)Program.ServiceProvider.GetService(typeof(IServiceTicket));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));
        }

        public FrmPrincipal()
        {
            ConsultarDepedencias();
            InitializeComponent();
        }

        private void importaçãoPlanilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmConf = new frmConfiguracaoExcel();
            frmConf.MdiParent = this;
            frmConf.Show();
        }

        private void importarPlanilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileCsv.ShowDialog();
                _serviceTicket.ImportarCsv(this.openFileCsv.FileName);
                _unitOfWork.SaveChanges();
            }
            catch(Exception ex)
            {

                MessageBox.Show("Erro ao realizar importação." + ex);
            }



            
        }
    }
}

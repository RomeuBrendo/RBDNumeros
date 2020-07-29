using Microsoft.Extensions.DependencyInjection;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Domain.Services;
using RBDNumeros.Infra.Repositories;
using RBDNumeros.Infra.Repositories.Transactions;
using RBDNumeros.Viwer.Formulario.Barra;
using RBDNumeros.Viwer.Formulario.Configuracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBDNumeros.Viwer
{
    public partial class FrmPrincipal : Form
    {
        private IServiceTicket _serviceTicket;
        private IUnitOfWork _unitOfWork;
        frmBarraProgresso frmBarra = new frmBarraProgresso();
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
                Thread t1 = new Thread(new ThreadStart(run));
                t1.Name = "Secundária";

                backgroundWorker1.RunWorkerAsync(); //Chamo em uma theread separada importação
                t1.Start(); // Inicio theread que vai alimentar barra de progresso.

                frmBarra.ShowInTaskbar = false;
                frmBarra.StartPosition = FormStartPosition.CenterParent; 
                DialogResult result = frmBarra.ShowDialog(FrmPrincipal.ActiveForm); //Para que funcione, é nessario exibir em show modal, por este motivo só deixo ele na theread principal.

                t1.Abort();
                if (result == DialogResult.OK)
                {
                   MessageBox.Show("Importação Realizada com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

               
                if (result == DialogResult.Cancel)
                {
                    _serviceTicket.CancelarImportacao(); 
                    MessageBox.Show("Operação Cancelada!", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                   
            }
            catch(Exception ex)
            {
                
                MessageBox.Show("Erro ao realizar importação." + ex);
            }
            
        }

        public  void run()
        {
            frmBarra.CarregaBarraProgresso(0, "");
            while (true)
            {
                frmBarra.CarregaBarraProgresso(_serviceTicket.RetornaPorcentagem(), _serviceTicket.RetornaProcesso());                 
                Thread.Sleep(400);
            }        
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            if(_serviceTicket.ImportarCsv(this.openFileCsv.FileName) > 0)
            {
                frmBarra.CarregaBarraProgresso(90, "Finalizando Commit. Aguarde...");
                _unitOfWork.SaveChanges();
                frmBarra.CarregaBarraProgresso(100, "Importação Realizada com sucesso!");
            }

        }
    }
}

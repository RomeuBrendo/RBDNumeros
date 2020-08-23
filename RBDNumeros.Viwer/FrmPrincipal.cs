using RBDNumeros.Domain.Enum;
using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Infra.Repositories.Transactions;
using RBDNumeros.Viwer.Formulario.Barra;
using RBDNumeros.Viwer.Formulario.Categoria;
using RBDNumeros.Viwer.Formulario.Configuracao;
using RBDNumeros.Viwer.Formulario.Kpi;
using RBDNumeros.Viwer.Formulario.Tecnico;
using RBDNumeros.Viwer.Formulario.Ticket;
using RBDNumeros.Viwer.Toast;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace RBDNumeros.Viwer
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm

    {
 
        int glb_PosicaoBotaoBase1, glb_PosicaoBotaoBase2;
        int glb_TopCadastro, glb_TopMovimentacao, glb_TopConfiguracao;
        bool glb_HideMenu;

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
            _serviceTicket.VerificaEstruturaBanco();

            glb_PosicaoBotaoBase1 = pnCadastro.Top;
            glb_PosicaoBotaoBase2 = btnKpi.Height;

            glb_TopCadastro = pnCadastro.Top;
            glb_TopMovimentacao = pnMovimentacao.Top;
            glb_TopConfiguracao = pnConfiguracao.Top;

            HideAllMenu();

            this.StyleManager = metroStyleManager1;
            pnMenu.Left = -272;
            
            glb_HideMenu = true;
            
        }


        public void HideAllMenu()
        {
            pnCadastro.Visible = false;
            pnMovimentacao.Visible = false;
            pnConfiguracao.Visible = false;
            btnKpi.Top = glb_PosicaoBotaoBase1;
            btnConfiguracao.Top = glb_PosicaoBotaoBase1 + glb_PosicaoBotaoBase2;

        }

        public void ShowSubMenu(Panel Painel)
        {
            HideAllMenu();
            if (Painel.Name == "pnCadastro")
            {
                btnKpi.Top = btnKpi.Top + pnCadastro.Height;
                btnConfiguracao.Top = btnConfiguracao.Top + pnCadastro.Height;
                Painel.Top = glb_TopCadastro;
                Painel.Visible = true;
            }
            if (Painel.Name == "pnMovimentacao")
            {
                btnConfiguracao.Top = btnConfiguracao.Top + pnMovimentacao.Height;
                Painel.Top = glb_TopMovimentacao - pnCadastro.Height;
                Painel.Visible = true;
            }
            if (Painel.Name == "pnRelatorio")
            {
                btnConfiguracao.Top = btnConfiguracao.Top ;
                Painel.Top = pnMovimentacao.Height - pnCadastro.Height;
                Painel.Visible = true;
            }
            if (Painel.Name == "pnConfiguracao")
            {
                Painel.Top = glb_TopConfiguracao - pnMovimentacao.Height - pnCadastro.Height;
                Painel.Visible = true;
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

        private void label1_Click(object sender, EventArgs e)
        {
            tmMenu.Start();
            HideAllMenu();
        }

        private void btnConfPlanilha_Click(object sender, EventArgs e)
        {
           // var frmConf = new frmConfiguracaoExcel();
           // //frmConf.MdiParent = this;
           //// frmConf.Show();
           // frmConf.ShowInTaskbar = false;
           // frmConf.StartPosition = FormStartPosition.CenterParent;
           // DialogResult result = frmConf.ShowDialog(FrmPrincipal.ActiveForm);

            AbrirFormulario< frmConfiguracaoExcel>();
        }

        private void btnCadImportarPlanilha_Click(object sender, EventArgs e)
        {
            try
            {

                this.openFileCsv.ShowDialog();

                if (this.openFileCsv.FileName.Equals(""))
                    return;

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
                    frmToast toast = new frmToast("Importação Realizada com sucesso!!", "Okay");
                    toast.Show();
                }


                if (result == DialogResult.Cancel)
                {
                    _serviceTicket.CancelarImportacao();
                    frmToast toast = new frmToast("Importação Cancelada!!", "");
                    toast.Show();
                }

            }
            catch (Exception ex)
            {
                frmToast toast = new frmToast("Erro ao realizar importação. Tente Novamente!!", "Erro");
                toast.Show();
            }
        }


        private void btnCadTecnicos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmTecnico>();
        }

        private void tmMenu_Tick(object sender, EventArgs e)
        {
            if (glb_HideMenu)
            {
                pnMenu.Left += 16;
                label3.Left += 16;
                if (pnMenu.Left == 0)
                {
                    glb_HideMenu = false;
                    this.Refresh();
                    tmMenu.Stop();
                }
            }
            else
            {
                pnMenu.Left -= 16;
                label3.Left -= 16;
                if (pnMenu.Left == -272)
                {
                    glb_HideMenu = true;
                    this.Refresh();
                    tmMenu.Stop();
                    
                }
            }
        }

        private void btnTempoSla_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmTempoSla>();
        }

        private void btnMovDesempenho_Click(object sender, EventArgs e)
        {
            Form frmForm = new frmChamadoSlaV2(EnumKPI.ChamadosPorCarteira);
            frmForm.ShowInTaskbar = false;
            frmForm.ShowDialog(FrmPrincipal.ActiveForm);
        }

        private void btnRelTecnico_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
           if (pnCadastro.Visible == false)
            {
                ShowSubMenu(pnCadastro);
            }
            else
            {
                HideAllMenu();
            }
               
        }

        private void btnCadCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCategoria>();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            if (pnMovimentacao.Visible == false)
            {
                ShowSubMenu(pnMovimentacao);
            }
            else
            {
                HideAllMenu();
            }
        }

        private void btnKpiChamadPorSla_Click(object sender, EventArgs e)
        {
            Form frmForm = new frmChamadoSlaV2(EnumKPI.ChamadosPorSla);
            frmForm.ShowInTaskbar = false;
            frmForm.ShowDialog(FrmPrincipal.ActiveForm);
        }

        private void btnExcluirTicket_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmDeletarTicket>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmForm = new frmChamadoSlaV2(EnumKPI.Top10);
            frmForm.ShowInTaskbar = false;
            frmForm.ShowDialog(FrmPrincipal.ActiveForm);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {

            if (pnConfiguracao.Visible == false)
            {
                ShowSubMenu(pnConfiguracao);
            }
            else
            {
                HideAllMenu();
            }

        }

        private void AbrirFormulario<teste>() where teste : Form, new()
        {
            Form frmForm = new teste();
            frmForm.ShowInTaskbar = false;
            frmForm.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = frmForm.ShowDialog(FrmPrincipal.ActiveForm);
        }



    }
}

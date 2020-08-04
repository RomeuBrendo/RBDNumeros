using Microsoft.Extensions.DependencyInjection;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Domain.Services;
using RBDNumeros.Infra.Repositories;
using RBDNumeros.Infra.Repositories.Transactions;
using RBDNumeros.Viwer.Formulario.Barra;
using RBDNumeros.Viwer.Formulario.Categoria;
using RBDNumeros.Viwer.Formulario.Configuracao;
using RBDNumeros.Viwer.Formulario.Tecnico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RBDNumeros.Viwer
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm

    {
        int glb_PosicaoBotaoBase1, glb_PosicaoBotaoBase2;
        int glb_TopCadastro, glb_TopMovimentacao, glb_TopConfiguracao;
        bool glb_HideMenu;

        private IServiceTicket _serviceTicket;
        private IServiceKPI _serviceKPI;

        private IUnitOfWork _unitOfWork;
        frmBarraProgresso frmBarra = new frmBarraProgresso();
        void ConsultarDepedencias()
        {
            _serviceTicket = (IServiceTicket)Program.ServiceProvider.GetService(typeof(IServiceTicket));
            _serviceKPI = (IServiceKPI)Program.ServiceProvider.GetService(typeof(IServiceKPI));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));
        }

        public FrmPrincipal()
        {
            ConsultarDepedencias();
            InitializeComponent();

            glb_PosicaoBotaoBase1 = pnCadastro.Top;
            glb_PosicaoBotaoBase2 = btnKpi.Height;

            glb_TopCadastro = pnCadastro.Top;
            glb_TopMovimentacao = pnMovimentacao.Top;
            glb_TopConfiguracao = pnConfiguracao.Top;

            HideAllMenu();

            //dtAte.Value = DateTime.Now;
            //dtDe.Value = DateTime.Now.AddDays(-7);

            //chart1.Series.Clear();
            //chart1.Series.Add("Carteiras");

            //CarregarGrafico(dtDe.Value, dtAte.Value);

           // this.StyleManager = metroStyleManager1;
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
                Painel.Top = glb_TopMovimentacao - pnCadastro.Height -5;
                Painel.Visible = true;
            }
            if (Painel.Name == "pnRelatorio")
            {
                btnConfiguracao.Top = btnConfiguracao.Top;
                Painel.Top = pnMovimentacao.Height - pnCadastro.Height;
                Painel.Visible = true;
            }
            if (Painel.Name == "pnConfiguracao")
            {
                Painel.Top = glb_TopConfiguracao - pnMovimentacao.Height - pnCadastro.Height -5;
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
            var frmConf = new frmConfiguracaoExcel();
            //frmConf.MdiParent = this;
           // frmConf.Show();
            frmConf.ShowInTaskbar = false;
            frmConf.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = frmConf.ShowDialog(FrmPrincipal.ActiveForm);
        }

        private void btnCadImportarPlanilha_Click(object sender, EventArgs e)
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
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao realizar importação." + ex);
            }
        }


        private void btnCadTecnicos_Click(object sender, EventArgs e)
        {
            var frmTecnico = new frmTecnico();

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
            var frmTempoSLA = new frmTempoSla();

            AbrirFormulario<frmTempoSla>();
        }

        private void btnMovDesempenho_Click(object sender, EventArgs e)
        {

        }

        private void btnRelTecnico_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnCadastro);
        }

        private void btnCadCategoria_Click(object sender, EventArgs e)
        {
            var frmCategoria = new frmCategoria();
            AbrirFormulario<frmCategoria>();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        //private void dtAte_ValueChanged(object sender, EventArgs e)
        //{
        //    lblRefresh.Visible = true;
        //}

        //private void dtDe_ValueChanged(object sender, EventArgs e)
        //{
        //    lblRefresh.Visible = true;
        //}

        //private void label5_Click(object sender, EventArgs e)
        //{
        //    CarregarGrafico(dtDe.Value, dtAte.Value);
        //}

        //private void lblGraphicPizza_Click(object sender, EventArgs e)
        //{
        //    ValoresNoGrafico(false);

        //    chart1.Series[0].ChartType = SeriesChartType.Pie;

        //}

        //private void lblGraphicColumn_Click(object sender, EventArgs e)
        //{
        //    ValoresNoGrafico(true);

        //    chart1.Series[0].ChartType = SeriesChartType.Column;
        //}

        //private void lblLineGraphic_Click(object sender, EventArgs e)
        //{
        //    ValoresNoGrafico(true);
        //    chart1.Series[0].ChartType = SeriesChartType.Line;
        //}

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnMovimentacao);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnConfiguracao);
        }

        //      private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        private void AbrirFormulario<teste>() where teste : Form, new()
        {
            Form frmForm = new teste();
            //frmConf.MdiParent = this;
            // frmConf.Show();
            frmForm.ShowInTaskbar = false;
            frmForm.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = frmForm.ShowDialog(FrmPrincipal.ActiveForm);
        }
        
        //private void CarregarGrafico(DateTime de, DateTime ate)
        //{

        //    var cat = _serviceKPI.ChamadosPorCarteira(de, ate);

        //   int CarteiraA = cat.A;
        //   int CarteiraB = cat.B;
        //   int CarteiraC = cat.C;
        //   int CarteiraD = cat.D;

        //   string[] series = { "Carteira A", "Carteira B", "Carteira C", "Carteira D" };
        //   int[] pontos = { CarteiraA, CarteiraB, CarteiraC, CarteiraD };

        //    chart1.Series["Carteiras"].Points.Clear();


        //    for (int i = 0; i < series.Length; i++)
        //    {

        //        chart1.Series["Carteiras"].Points.AddXY(series[i], pontos[i]);
        //        chart1.Series["Carteiras"].Points[i].IsValueShownAsLabel = true;


        //    }

        //    this.Refresh();

        //    lblRefresh.Visible = false;

        //}

        //public void ValoresNoGrafico(Boolean Status)
        //{
        //    chart1.Series["Carteiras"].Points[0].IsValueShownAsLabel = Status;
        //    chart1.Series["Carteiras"].Points[1].IsValueShownAsLabel = Status;
        //    chart1.Series["Carteiras"].Points[2].IsValueShownAsLabel = Status;
        //    chart1.Series["Carteiras"].Points[3].IsValueShownAsLabel = Status;
        //}
    }
}

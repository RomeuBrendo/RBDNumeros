using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;
using RBDNumeros.Viwer.Toast;
using RBDNumeros.Domain.Enum;
using System.CodeDom.Compiler;
using System.Linq;

namespace RBDNumeros.Viwer.Formulario.Kpi
{
    public partial class frmChamadoSlaV2 : MetroFramework.Forms.MetroForm
    {
        private IServiceKPI _serviceKPI;
        EnumKPI _enumKPI;


        void ConsultarDepedencias()
        {
            _serviceKPI = (IServiceKPI)Program.ServiceProvider.GetService(typeof(IServiceKPI));
        }
        public frmChamadoSlaV2(EnumKPI enumKPI)
        {
            this.Location = new Point(322, 35);
            InitializeComponent();
            ConsultarDepedencias();
            _enumKPI = enumKPI;
            ConfiguraTela();
        }

        void ConfiguraTela()
        {
            if (_enumKPI == EnumKPI.ChamadosPorSla)
            {
                this.Text = "Chamados por Sla";
                this.Text = "Chamados por Carteira";
                lblRefresh.Left = DataFim.Left + DataFim.Width + 20;
                pnTop10.Visible = false;
            } 
            else if (_enumKPI == EnumKPI.ChamadosPorCarteira)
            {
                this.Text = "Chamados por Carteira";
                lblRefresh.Left = DataFim.Left + DataFim.Width + 20;
                pnTop10.Visible = false;

            }
            else if (_enumKPI == EnumKPI.Top10)
            {
                this.Text = "Top 10 - Clientes";
                lblRefresh.Left = pnTop10.Left + pnTop10.Width + 20;
                pnTop10.Visible = true;


            }
        }

        private void frmChamadoSlaV2_Load(object sender, EventArgs e)
        {

            this.reportViewerChamadosPorSla.RefreshReport();
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            if (_enumKPI == EnumKPI.ChamadosPorCarteira)
                CarregaChamadosPorCarteira();
            else if (_enumKPI == EnumKPI.ChamadosPorSla)
                CarregaChamadosPorSla();
            else
               Top10();
        }

        public void CarregaChamadosPorCarteira()
        {
            var chamados = new List<ChamadosPorCarteiraRequest>();

            this.Text = "Chamados por Carteira";

            chamados.Add(_serviceKPI.ChamadosPorCarteira(DataInicio.Value, DataFim.Value));

            var dataSourceChamado = new ReportDataSource("DataSetChamadoPorCarteira", chamados);

            this.reportViewerChamadosPorSla.LocalReport.ReportEmbeddedResource = "RBDNumeros.Viwer.RDLC.ReportChamadoPorCarteira.rdlc";
           
            this.reportViewerChamadosPorSla.LocalReport.DataSources.Clear();

            this.reportViewerChamadosPorSla.LocalReport.DataSources.Add(dataSourceChamado);

            this.reportViewerChamadosPorSla.Visible = true;

            this.reportViewerChamadosPorSla.RefreshReport();

            lblRefresh.Visible = false;
        }

        public void Top10()
        {
            var chamados = new List<Top10Response>();
            var request = new Top10Request();

            request.DataInicio = DataInicio.Value.Date;
            request.DataFim = DataFim.Value.Date;
            request.Carteira = (EnumCarteira)cbCarteira.SelectedIndex;

            this.Text = "Top 10 por Cliente";

            chamados = _serviceKPI.Top10(request);

            if(chamados == null)
            {
                var toasts = new frmToast("Verifique o filtro passado e tente novamente!!", "Erro");
                toasts.Show();
                return;
            }

            var dataSourceChamado = new ReportDataSource("DataSetTop10", chamados);

            this.reportViewerChamadosPorSla.LocalReport.ReportEmbeddedResource = "RBDNumeros.Viwer.RDLC.ReportTop10.rdlc";

            this.reportViewerChamadosPorSla.LocalReport.DataSources.Clear();

            this.reportViewerChamadosPorSla.LocalReport.DataSources.Add(dataSourceChamado);

            this.reportViewerChamadosPorSla.Visible = true;

            this.reportViewerChamadosPorSla.RefreshReport();

            lblRefresh.Visible = false;
        }
        public void CarregaChamadosPorSla()
        {
            List<ChamadosPorSlaRequest> chamados = new List<ChamadosPorSlaRequest>();

            chamados = _serviceKPI.ChamadosPorSla(DataInicio.Value, DataFim.Value);

            var dataSourceChamado = new ReportDataSource("DataSetChamadoPorSla", chamados);

            this.reportViewerChamadosPorSla.LocalReport.DataSources.Clear();

            this.reportViewerChamadosPorSla.LocalReport.DataSources.Add(dataSourceChamado);

            this.reportViewerChamadosPorSla.Visible = true;

            this.reportViewerChamadosPorSla.RefreshReport();

            lblRefresh.Visible = false;
        }

        private void frmChamadoSlaV2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.F4)
                lblRefresh.PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        { 
           ExportarRelatorio("EXCELOPENXML", "xlsx");

        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {
                reportViewerChamadosPorSla.PrintDialog();
            }
            catch (Exception)
            {
                frmToast ToastC = new frmToast("Erro ao realizar impressão!", "erro");
                ToastC.Show();
                this.Focus();
            }
            
        }

        private void ExportarRelatorio(string Formato, string Extencao)
        {

            folderBrowserDialog1.ShowDialog();

            String NomeArquivo = folderBrowserDialog1.SelectedPath;

            if (NomeArquivo == "")
                return;

            NomeArquivo += "\\" + frmChamadoSlaV2.ActiveForm.Text + DataInicio.Text.Replace("/", "") + "-" + DataFim.Text.Replace("/", "") + "." + Extencao;

            try
            {
                var bytes = reportViewerChamadosPorSla.LocalReport.Render(Formato);
                System.IO.File.WriteAllBytes(NomeArquivo, bytes);

                frmToast Toast = new frmToast("Exportado com Sucesso!!", "Okay");
                Toast.Show();
                this.Focus();
            }
            catch(Exception)
            {
                frmToast ToastC = new frmToast("Erro ao realizar exportação!", "erro");
                ToastC.Show();
                this.Focus();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SavePDF();
        }

        public void SavePDF()
        {
            folderBrowserDialog1.ShowDialog();

            String NomeArquivo = folderBrowserDialog1.SelectedPath;

            if (NomeArquivo == "")
                return;

            NomeArquivo += "\\" + frmChamadoSlaV2.ActiveForm.Text + DataInicio.Text.Replace("/", "") + "-" + DataFim.Text.Replace("/", "") + ".pdf";

            try
            {

                byte[] Bytes = reportViewerChamadosPorSla.LocalReport.Render(format: "PDF", deviceInfo: "");

                using (FileStream stream = new FileStream(NomeArquivo, FileMode.Create))
                {
                    stream.Write(Bytes, 0, Bytes.Length);
                }

                frmToast Toast = new frmToast("Exportado com Sucesso!!", "Okay");
                Toast.Show();
                this.Focus();

            }
            catch(Exception)
            {

                frmToast ToastC = new frmToast("Erro ao realizar exportação!", "erro");
                ToastC.Show();
                this.Focus();

            }

            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ExportarRelatorio("WORDOPENXML", "docx");
        }

        private void DataInicio_ValueChanged(object sender, EventArgs e)
        {
            lblRefresh.Visible = true;
        }

        private void DataFim_ValueChanged(object sender, EventArgs e)
        {
            lblRefresh.Visible = true;
        }

        private void cbCarteira_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkAscendente_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

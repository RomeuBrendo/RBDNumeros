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

            if (_enumKPI == EnumKPI.ChamadosPorCarteira)
            {
                this.Text = "Chamados por Carteira";
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
            else
                CarregaChamadosPorSla();

            return;
        }

        public void CarregaChamadosPorCarteira()
        {
            var chamados = new List<ChamadosPorCarteiraRequest>();

            this.Text = "Chamados por Carteira";

            chamados.Add(_serviceKPI.ChamadosPorCarteira(DateTime.Parse("05/06/2020"), DateTime.Parse("18/06/2020")));

            var dataSourceChamado = new ReportDataSource("DataSetChamadoPorCarteira", chamados);

            this.reportViewerChamadosPorSla.LocalReport.ReportEmbeddedResource = "RBDNumeros.Viwer.RDLC.ReportChamadoPorCarteira.rdlc";

            this.reportViewerChamadosPorSla.LocalReport.DataSources.Add(dataSourceChamado);

            this.reportViewerChamadosPorSla.Visible = true;

            this.reportViewerChamadosPorSla.RefreshReport();
        }

        public void CarregaChamadosPorSla()
        {
            List<ChamadosPorSlaRequest> chamados = new List<ChamadosPorSlaRequest>();

            //  chamados = _serviceKPI.ChamadosPorSla(DataInicio.Value, DataFim.Value);
            chamados = _serviceKPI.ChamadosPorSla(DateTime.Parse("05/06/2020"), DateTime.Parse("18/06/2020"));

            var dataSourceChamado = new ReportDataSource("DataSetChamadoPorSla", chamados);

            this.reportViewerChamadosPorSla.LocalReport.DataSources.Clear();

            this.reportViewerChamadosPorSla.LocalReport.DataSources.Add(dataSourceChamado);

            this.reportViewerChamadosPorSla.Visible = true;

            this.reportViewerChamadosPorSla.RefreshReport();
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
            reportViewerChamadosPorSla.PrintDialog();
        }

        private void ExportarRelatorio(string Formato, string Extencao)
        {
            folderBrowserDialog1.ShowDialog();

            String NomeArquivo = folderBrowserDialog1.SelectedPath;

            if (NomeArquivo == "")
                return;

            NomeArquivo += "\\" + frmChamadoSlaV2.ActiveForm.Text + DataInicio.Text.Replace("/", "") + "-" + DataFim.Text.Replace("/", "") + "." + Extencao;

            var bytes = reportViewerChamadosPorSla.LocalReport.Render(Formato);
            System.IO.File.WriteAllBytes(NomeArquivo, bytes);

            frmToast Toast = new frmToast("Exportado com Sucesso!!", "Okay");
            Toast.Show();
            this.Focus();
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

            byte[] Bytes = reportViewerChamadosPorSla.LocalReport.Render(format: "PDF", deviceInfo: "");

            using (FileStream stream = new FileStream(NomeArquivo, FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }

            frmToast Toast = new frmToast("Exportado com Sucesso!!", "Okay");
            Toast.Show();
            this.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ExportarRelatorio("WORDOPENXML", "docx");
        }
    }
}

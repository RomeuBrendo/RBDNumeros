using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;
using RBDNumeros.Viwer.Toast;


namespace RBDNumeros.Viwer.Formulario.Kpi
{
    public partial class frmChamadoSlaV2 : MetroFramework.Forms.MetroForm
    {
        private IServiceKPI _serviceKPI;
        List<ChamadosPorSlaRequest> chamados = new List<ChamadosPorSlaRequest>();
        void ConsultarDepedencias()
        {
            _serviceKPI = (IServiceKPI)Program.ServiceProvider.GetService(typeof(IServiceKPI));
        }
        public frmChamadoSlaV2()
        {
            this.Location = new Point(322, 35);
            InitializeComponent();
            ConsultarDepedencias();
    
        }

        private void frmChamadoSlaV2_Load(object sender, EventArgs e)
        {


            this.reportViewerChamadosPorSla.RefreshReport();
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            chamados.Clear();
            //  chamados = _serviceKPI.ChamadosPorSla(DataInicio.Value, DataFim.Value);
            chamados = _serviceKPI.ChamadosPorSla(DateTime.Parse("05/06/2020"), DateTime.Parse("18/06/2020"));

            var dataSourceChamado = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetChamadoPorSla", chamados);

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

            frmToast Toast = new frmToast("Exportado com Sucesso!!", Color.FromArgb(43, 148, 50), "Okay");
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

            frmToast Toast = new frmToast("Exportado com Sucesso!!", Color.FromArgb(43, 148, 50), "Okay");
            Toast.Show();
            this.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ExportarRelatorio("WORDOPENXML", "docx");
        }
    }
}

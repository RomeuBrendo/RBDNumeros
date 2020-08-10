using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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
    }
}

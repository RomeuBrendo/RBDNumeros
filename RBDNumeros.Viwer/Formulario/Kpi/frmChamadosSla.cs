using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using RBDNumeros.Domain.Interfaces.Services;
using System.Windows.Forms;
using System.Xml.Schema;

namespace RBDNumeros.Viwer.Formulario.Kpi
{
    public partial class frmChamadosSla : MetroFramework.Forms.MetroForm
    {
        private IServiceKPI _serviceKPI;
        private bool glb_TemChartAreas;

        void ConsultarDepedencias()
        {
            _serviceKPI = (IServiceKPI)Program.ServiceProvider.GetService(typeof(IServiceKPI));
        }

        public frmChamadosSla()
        {
            InitializeComponent();
            ConsultarDepedencias();

            dtAte.Value = DateTime.Now;
            dtDe.Value = DateTime.Now.AddDays(-7);

            glb_TemChartAreas = false;

            ConfigurarGrafico();
            CarregarGrafico(dtDe.Value, dtAte.Value);

        }
        /*------------------------------------Configurações do Grafico-----------------------------------*/
        /*-----------------------------------------------------------------------------------------------*/
        public void ConfigurarGrafico()
        {
            chart1.Series.Clear();

            chart1.Series.Add("Dentro SLA");
            chart1.Series.Add("SLA +20");
            chart1.Series.Add("Acima SLA");

            RemoverChartAreas();

            ExibirLegendas();

            chart1.Legends.Add("Dentro SLA");
            chart1.Legends.Add("SLA +20");
            chart1.Legends.Add("Acima SLA");

            chart1.Legends[0].Font = new System.Drawing.Font("ARIAL", 10, FontStyle.Bold);
            chart1.Legends[1].Font = new System.Drawing.Font("ARIAL", 10, FontStyle.Bold);
            chart1.Legends[2].Font = new System.Drawing.Font("ARIAL", 10, FontStyle.Bold);

        }

        public void AdcionarChartAreas()
        {
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add("Dentro SLA");
            chart1.ChartAreas.Add("SLA +20");
            chart1.ChartAreas.Add("Acima SLA");

            glb_TemChartAreas = true;
        }


        public void RemoverChartAreas()
        {
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add("Geral");
            chart1.Series[0].ChartArea = "Geral";
            chart1.Series[1].ChartArea = "Geral";
            chart1.Series[2].ChartArea = "Geral";
            chart1.Titles.Clear();
            glb_TemChartAreas = false;
        }

        public void ApenasUmaLegenda()
        {
            chart1.Series[0].IsVisibleInLegend = true;
            chart1.Series[1].IsVisibleInLegend = false;
            chart1.Series[2].IsVisibleInLegend = false;
        }

        public void ExibirLegendas()
        {
            chart1.Series[0].IsVisibleInLegend = true;
            chart1.Series[1].IsVisibleInLegend = true;
            chart1.Series[2].IsVisibleInLegend = true;
        }

        public void NaoExibirLegendas()
        {
            chart1.Series[0].IsVisibleInLegend = false;
            chart1.Series[1].IsVisibleInLegend = false;
            chart1.Series[2].IsVisibleInLegend = false;
        }

        public void ConfigurarChartAreas()
        {
            chart1.Series[0].ChartArea = "Dentro SLA";
            chart1.Series[1].ChartArea = "SLA +20";
            chart1.Series[2].ChartArea = "Acima SLA";
        }

        public void AdicionarTitulo()
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Dentro SLA");
            chart1.Titles.Add("SLA +20");
            chart1.Titles.Add("Acima SLA");

            chart1.Titles[0].DockedToChartArea = "Dentro SLA";
            chart1.Titles[1].DockedToChartArea = "SLA +20";
            chart1.Titles[2].DockedToChartArea = "Acima SLA";

        }
            

        public void TituloGraficoTopo()
        {
            chart1.Titles[0].Font = new System.Drawing.Font("ARIAL", 12, FontStyle.Bold);
            chart1.Titles[0].Docking = Docking.Top;
            chart1.Titles[0].DockingOffset = -4;
            chart1.Titles[1].Font = new System.Drawing.Font("ARIAL", 12, FontStyle.Bold);
            chart1.Titles[1].Docking = Docking.Top;
            chart1.Titles[1].DockingOffset = -4;
            chart1.Titles[2].Font = new System.Drawing.Font("ARIAL", 12, FontStyle.Bold);
            chart1.Titles[2].Docking = Docking.Top;
            chart1.Titles[2].DockingOffset = -4;

        }

        public void TituloGraficoDireita()
        {
            chart1.Titles[0].Font = new System.Drawing.Font("ARIAL", 12, FontStyle.Bold);
            chart1.Titles[0].Docking = Docking.Right;
            chart1.Titles[0].DockingOffset = -11;
            chart1.Titles[1].Font = new System.Drawing.Font("ARIAL", 12, FontStyle.Bold);
            chart1.Titles[1].Docking = Docking.Right;
            chart1.Titles[1].DockingOffset = -11;
            chart1.Titles[2].Font = new System.Drawing.Font("ARIAL", 12, FontStyle.Bold);
            chart1.Titles[2].Docking = Docking.Right;
            chart1.Titles[2].DockingOffset = -11;

        }


        private void CarregarGrafico(DateTime de, DateTime ate)
        {
            String[] Carteiras = { "Carteira A", "Carteira B", "Carteira C", "Carteira D"};
            int contador = 0;
            var cat = _serviceKPI.ChamadosPorSla(de.Date, ate.Date);
            double TotalDentro, TotalSla20, TotalEstourado;

            TotalDentro = 0;
            TotalSla20 = 0;
            TotalEstourado = 0;

            chart1.Series["Dentro SLA"].Points.Clear();
            chart1.Series["SLA +20"].Points.Clear();
            chart1.Series["Acima SLA"].Points.Clear();
            
            DataGridDados.Rows.Clear();
            
            foreach (var Item in cat)
            {

                chart1.Series["Dentro SLA"].Points.AddXY(Carteiras[contador], Item.DentroSla.ToString());
                chart1.Series["SLA +20"].Points.AddXY(Carteiras[contador], Item.Acima20.ToString());
                chart1.Series["Acima SLA"].Points.AddXY(Carteiras[contador], Item.Estourado.ToString());
                DataGridDados.Rows.Add(Carteiras[contador], Item.DentroSla.ToString(), Item.Acima20.ToString(), Item.Estourado.ToString());

                TotalDentro += Double.Parse(Item.DentroSla.ToString());
                TotalSla20 += Double.Parse(Item.Acima20.ToString());
                TotalEstourado += Double.Parse(Item.Estourado.ToString());

                contador++;

            }

            DataGridDados.Rows.Add("");

            DataGridDados.Rows.Add("Total", TotalDentro.ToString(), TotalSla20.ToString(), TotalEstourado.ToString());
            DataGridDados.ClearSelection();

            this.Refresh();

            

            lblRefresh.Visible = false;
        }

        /*-----------------------------------------------------------------------------------------------*/
        /*-----------------------------------------------------------------------------------------------*/


        private void lblGraphicColumn_Click(object sender, EventArgs e)
        {

            if (glb_TemChartAreas)
                RemoverChartAreas();

            ExibirLegendas();
            chart1.Series[0].ChartType = SeriesChartType.Column;
            chart1.Series[1].ChartType = SeriesChartType.Column;
            chart1.Series[2].ChartType = SeriesChartType.Column;
        }


        private void lblGraphicPizza_Click(object sender, EventArgs e)
        {

            if (!glb_TemChartAreas)
                AdcionarChartAreas();

            AdicionarTitulo();
            TituloGraficoDireita();
            ConfigurarChartAreas();
            ApenasUmaLegenda();
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.Series[1].ChartType = SeriesChartType.Pie;
            chart1.Series[2].ChartType = SeriesChartType.Pie;

        }

       
        private void lblLineGraphic_Click(object sender, EventArgs e)
        {

            if (!glb_TemChartAreas)
                AdcionarChartAreas();

            AdicionarTitulo();
            TituloGraficoTopo();
            ConfigurarChartAreas();
            ExibirLegendas();
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[2].ChartType = SeriesChartType.Line;
            
        }

        private void lblRefresh_Click(object sender, EventArgs e)
        {
            CarregarGrafico(dtDe.Value, dtAte.Value);
        }

        private void dtDe_ValueChanged(object sender, EventArgs e)
        {
            lblRefresh.Visible = true;
        }

        private void dtAte_ValueChanged(object sender, EventArgs e)
        {
            lblRefresh.Visible = true;
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!panel1.Visible && metroCheckBox1.Checked)
            {
                panel1.Visible = true;
            }else if (panel1.Visible && !metroCheckBox1.Checked)
            {
                panel1.Visible = false;
            }



        }
    }
}

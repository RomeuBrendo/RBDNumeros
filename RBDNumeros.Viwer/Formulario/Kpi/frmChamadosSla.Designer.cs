﻿namespace RBDNumeros.Viwer.Formulario.Kpi
{
    partial class frmChamadosSla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamadosSla));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblLineGraphic = new System.Windows.Forms.Label();
            this.lblGraphicPizza = new System.Windows.Forms.Label();
            this.lblGraphicColumn = new System.Windows.Forms.Label();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtAte = new System.Windows.Forms.DateTimePicker();
            this.dtDe = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.lblLineGraphic);
            this.metroPanel1.Controls.Add(this.lblGraphicPizza);
            this.metroPanel1.Controls.Add(this.lblGraphicColumn);
            this.metroPanel1.Controls.Add(this.chart1);
            this.metroPanel1.Controls.Add(this.lblRefresh);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.dtAte);
            this.metroPanel1.Controls.Add(this.dtDe);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 54);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(943, 537);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblLineGraphic
            // 
            this.lblLineGraphic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLineGraphic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLineGraphic.Image = ((System.Drawing.Image)(resources.GetObject("lblLineGraphic.Image")));
            this.lblLineGraphic.Location = new System.Drawing.Point(880, 215);
            this.lblLineGraphic.Name = "lblLineGraphic";
            this.lblLineGraphic.Size = new System.Drawing.Size(60, 58);
            this.lblLineGraphic.TabIndex = 18;
            this.lblLineGraphic.Click += new System.EventHandler(this.lblLineGraphic_Click);
            // 
            // lblGraphicPizza
            // 
            this.lblGraphicPizza.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGraphicPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGraphicPizza.Image = ((System.Drawing.Image)(resources.GetObject("lblGraphicPizza.Image")));
            this.lblGraphicPizza.Location = new System.Drawing.Point(877, 152);
            this.lblGraphicPizza.Name = "lblGraphicPizza";
            this.lblGraphicPizza.Size = new System.Drawing.Size(63, 58);
            this.lblGraphicPizza.TabIndex = 17;
            this.lblGraphicPizza.Click += new System.EventHandler(this.lblGraphicPizza_Click);
            // 
            // lblGraphicColumn
            // 
            this.lblGraphicColumn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGraphicColumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGraphicColumn.Image = ((System.Drawing.Image)(resources.GetObject("lblGraphicColumn.Image")));
            this.lblGraphicColumn.Location = new System.Drawing.Point(877, 78);
            this.lblGraphicColumn.Name = "lblGraphicColumn";
            this.lblGraphicColumn.Size = new System.Drawing.Size(63, 58);
            this.lblGraphicColumn.TabIndex = 16;
            this.lblGraphicColumn.Click += new System.EventHandler(this.lblGraphicColumn_Click);
            // 
            // lblRefresh
            // 
            this.lblRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRefresh.Image = ((System.Drawing.Image)(resources.GetObject("lblRefresh.Image")));
            this.lblRefresh.Location = new System.Drawing.Point(383, 21);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(39, 38);
            this.lblRefresh.TabIndex = 15;
            this.lblRefresh.Visible = false;
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "até";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtAte
            // 
            this.dtAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAte.Location = new System.Drawing.Point(263, 31);
            this.dtAte.MaximumSize = new System.Drawing.Size(98, 20);
            this.dtAte.MinimumSize = new System.Drawing.Size(98, 20);
            this.dtAte.Name = "dtAte";
            this.dtAte.Size = new System.Drawing.Size(98, 20);
            this.dtAte.TabIndex = 13;
            this.dtAte.ValueChanged += new System.EventHandler(this.dtAte_ValueChanged);
            // 
            // dtDe
            // 
            this.dtDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDe.Location = new System.Drawing.Point(122, 31);
            this.dtDe.MaximumSize = new System.Drawing.Size(98, 20);
            this.dtDe.MinimumSize = new System.Drawing.Size(98, 20);
            this.dtDe.Name = "dtDe";
            this.dtDe.Size = new System.Drawing.Size(98, 20);
            this.dtDe.TabIndex = 12;
            this.dtDe.ValueChanged += new System.EventHandler(this.dtDe_ValueChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(58, 62);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(17)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(17)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(17)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))))};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(758, 457);
            this.chart1.TabIndex = 10;
            // 
            // frmChamadosSla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 614);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmChamadosSla";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Relação de chamados por SLA";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label lblLineGraphic;
        private System.Windows.Forms.Label lblGraphicPizza;
        private System.Windows.Forms.Label lblGraphicColumn;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtAte;
        private System.Windows.Forms.DateTimePicker dtDe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
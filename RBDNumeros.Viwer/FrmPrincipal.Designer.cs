﻿namespace RBDNumeros.Viwer
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.openFileCsv = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtAte = new System.Windows.Forms.DateTimePicker();
            this.dtDe = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnMenu = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.pnConfiguracao = new MetroFramework.Controls.MetroPanel();
            this.btnTempoSla = new System.Windows.Forms.Button();
            this.btnConfPlanilha = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.pnRelatorio = new MetroFramework.Controls.MetroPanel();
            this.btnRelClienteRede = new System.Windows.Forms.Button();
            this.btnRelClientePrio = new System.Windows.Forms.Button();
            this.btnRelTecnico = new System.Windows.Forms.Button();
            this.btnMovimentacao = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.pnMovimentacao = new MetroFramework.Controls.MetroPanel();
            this.btnMovDesempenho = new System.Windows.Forms.Button();
            this.btnMovNaoResolvido = new System.Windows.Forms.Button();
            this.pnCadastro = new MetroFramework.Controls.MetroPanel();
            this.btnCadTecnicos = new System.Windows.Forms.Button();
            this.btnCadCategoria = new System.Windows.Forms.Button();
            this.btnCadImportarPlanilha = new System.Windows.Forms.Button();
            this.tmMenu = new System.Windows.Forms.Timer(this.components);
            this.lblGraphicColumn = new System.Windows.Forms.Label();
            this.lblGraphicPizza = new System.Windows.Forms.Label();
            this.lblLineGraphic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.pnConfiguracao.SuspendLayout();
            this.pnRelatorio.SuspendLayout();
            this.pnMovimentacao.SuspendLayout();
            this.pnCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileCsv
            // 
            this.openFileCsv.Title = "Importação Planilha";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.lblLineGraphic);
            this.metroPanel1.Controls.Add(this.lblGraphicPizza);
            this.metroPanel1.Controls.Add(this.lblGraphicColumn);
            this.metroPanel1.Controls.Add(this.lblRefresh);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.dtAte);
            this.metroPanel1.Controls.Add(this.dtDe);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.chart1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1100, 648);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblRefresh
            // 
            this.lblRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRefresh.Image = ((System.Drawing.Image)(resources.GetObject("lblRefresh.Image")));
            this.lblRefresh.Location = new System.Drawing.Point(332, 73);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(39, 35);
            this.lblRefresh.TabIndex = 15;
            this.lblRefresh.Visible = false;
            this.lblRefresh.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(162, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "até";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtAte
            // 
            this.dtAte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAte.Location = new System.Drawing.Point(209, 79);
            this.dtAte.MaximumSize = new System.Drawing.Size(98, 20);
            this.dtAte.MinimumSize = new System.Drawing.Size(98, 20);
            this.dtAte.Name = "dtAte";
            this.dtAte.Size = new System.Drawing.Size(98, 20);
            this.dtAte.TabIndex = 13;
            this.dtAte.ValueChanged += new System.EventHandler(this.dtAte_ValueChanged);
            // 
            // dtDe
            // 
            this.dtDe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDe.Location = new System.Drawing.Point(58, 79);
            this.dtDe.MaximumSize = new System.Drawing.Size(98, 20);
            this.dtDe.MinimumSize = new System.Drawing.Size(98, 20);
            this.dtDe.Name = "dtDe";
            this.dtDe.Size = new System.Drawing.Size(98, 20);
            this.dtDe.TabIndex = 12;
            this.dtDe.ValueChanged += new System.EventHandler(this.dtDe_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(626, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Relação de chamados abertos no periodo";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(58, 102);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(17)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))))};
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(915, 563);
            this.chart1.TabIndex = 10;
            // 
            // pnMenu
            // 
            this.pnMenu.AllowDrop = true;
            this.pnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnMenu.AutoScroll = true;
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            this.pnMenu.Controls.Add(this.metroPanel2);
            this.pnMenu.Controls.Add(this.btnConfiguracao);
            this.pnMenu.Controls.Add(this.pnConfiguracao);
            this.pnMenu.Controls.Add(this.btnRelatorio);
            this.pnMenu.Controls.Add(this.pnRelatorio);
            this.pnMenu.Controls.Add(this.btnMovimentacao);
            this.pnMenu.Controls.Add(this.btnCadastro);
            this.pnMenu.Controls.Add(this.pnMovimentacao);
            this.pnMenu.Controls.Add(this.pnCadastro);
            this.pnMenu.HorizontalScrollbar = true;
            this.pnMenu.HorizontalScrollbarBarColor = false;
            this.pnMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnMenu.HorizontalScrollbarSize = 0;
            this.pnMenu.Location = new System.Drawing.Point(0, 4);
            this.pnMenu.MaximumSize = new System.Drawing.Size(321, 10000);
            this.pnMenu.MinimumSize = new System.Drawing.Size(321, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(321, 730);
            this.pnMenu.TabIndex = 2;
            this.pnMenu.UseCustomBackColor = true;
            this.pnMenu.UseCustomForeColor = true;
            this.pnMenu.UseStyleColors = true;
            this.pnMenu.VerticalScrollbar = true;
            this.pnMenu.VerticalScrollbarBarColor = true;
            this.pnMenu.VerticalScrollbarHighlightOnWheel = false;
            this.pnMenu.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.label2);
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(324, 119);
            this.metroPanel2.TabIndex = 11;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "KPI Suporte";
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(271, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 39);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConfiguracao
            // 
            this.btnConfiguracao.AutoSize = true;
            this.btnConfiguracao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            this.btnConfiguracao.FlatAppearance.BorderSize = 0;
            this.btnConfiguracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguracao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracao.ForeColor = System.Drawing.Color.White;
            this.btnConfiguracao.Location = new System.Drawing.Point(0, 478);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(324, 38);
            this.btnConfiguracao.TabIndex = 9;
            this.btnConfiguracao.Text = "CONFIGURAÇÕES";
            this.btnConfiguracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracao.UseVisualStyleBackColor = false;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // pnConfiguracao
            // 
            this.pnConfiguracao.Controls.Add(this.btnTempoSla);
            this.pnConfiguracao.Controls.Add(this.btnConfPlanilha);
            this.pnConfiguracao.HorizontalScrollbarBarColor = true;
            this.pnConfiguracao.HorizontalScrollbarHighlightOnWheel = false;
            this.pnConfiguracao.HorizontalScrollbarSize = 10;
            this.pnConfiguracao.Location = new System.Drawing.Point(-3, 513);
            this.pnConfiguracao.Name = "pnConfiguracao";
            this.pnConfiguracao.Size = new System.Drawing.Size(321, 71);
            this.pnConfiguracao.TabIndex = 10;
            this.pnConfiguracao.VerticalScrollbarBarColor = true;
            this.pnConfiguracao.VerticalScrollbarHighlightOnWheel = false;
            this.pnConfiguracao.VerticalScrollbarSize = 10;
            // 
            // btnTempoSla
            // 
            this.btnTempoSla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTempoSla.FlatAppearance.BorderSize = 0;
            this.btnTempoSla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempoSla.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempoSla.ForeColor = System.Drawing.Color.White;
            this.btnTempoSla.Location = new System.Drawing.Point(-3, 37);
            this.btnTempoSla.Name = "btnTempoSla";
            this.btnTempoSla.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnTempoSla.Size = new System.Drawing.Size(324, 34);
            this.btnTempoSla.TabIndex = 3;
            this.btnTempoSla.Text = "TEMPO SLA";
            this.btnTempoSla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTempoSla.UseVisualStyleBackColor = false;
            this.btnTempoSla.Click += new System.EventHandler(this.btnTempoSla_Click);
            // 
            // btnConfPlanilha
            // 
            this.btnConfPlanilha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConfPlanilha.FlatAppearance.BorderSize = 0;
            this.btnConfPlanilha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfPlanilha.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfPlanilha.ForeColor = System.Drawing.Color.White;
            this.btnConfPlanilha.Location = new System.Drawing.Point(-3, 0);
            this.btnConfPlanilha.Name = "btnConfPlanilha";
            this.btnConfPlanilha.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnConfPlanilha.Size = new System.Drawing.Size(330, 43);
            this.btnConfPlanilha.TabIndex = 2;
            this.btnConfPlanilha.Text = "IMPORTAÇÃO PLANILHA";
            this.btnConfPlanilha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfPlanilha.UseVisualStyleBackColor = false;
            this.btnConfPlanilha.Click += new System.EventHandler(this.btnConfPlanilha_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.AutoSize = true;
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 346);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(318, 38);
            this.btnRelatorio.TabIndex = 7;
            this.btnRelatorio.Text = "RELATÓRIOS";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // pnRelatorio
            // 
            this.pnRelatorio.Controls.Add(this.btnRelClienteRede);
            this.pnRelatorio.Controls.Add(this.btnRelClientePrio);
            this.pnRelatorio.Controls.Add(this.btnRelTecnico);
            this.pnRelatorio.HorizontalScrollbarBarColor = true;
            this.pnRelatorio.HorizontalScrollbarHighlightOnWheel = false;
            this.pnRelatorio.HorizontalScrollbarSize = 10;
            this.pnRelatorio.Location = new System.Drawing.Point(0, 380);
            this.pnRelatorio.Name = "pnRelatorio";
            this.pnRelatorio.Size = new System.Drawing.Size(318, 102);
            this.pnRelatorio.TabIndex = 8;
            this.pnRelatorio.VerticalScrollbarBarColor = true;
            this.pnRelatorio.VerticalScrollbarHighlightOnWheel = false;
            this.pnRelatorio.VerticalScrollbarSize = 10;
            // 
            // btnRelClienteRede
            // 
            this.btnRelClienteRede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRelClienteRede.FlatAppearance.BorderSize = 0;
            this.btnRelClienteRede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelClienteRede.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelClienteRede.ForeColor = System.Drawing.Color.White;
            this.btnRelClienteRede.Location = new System.Drawing.Point(-3, 64);
            this.btnRelClienteRede.Name = "btnRelClienteRede";
            this.btnRelClienteRede.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnRelClienteRede.Size = new System.Drawing.Size(324, 38);
            this.btnRelClienteRede.TabIndex = 4;
            this.btnRelClienteRede.Text = "CLIENTES REDE";
            this.btnRelClienteRede.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelClienteRede.UseVisualStyleBackColor = false;
            // 
            // btnRelClientePrio
            // 
            this.btnRelClientePrio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRelClientePrio.FlatAppearance.BorderSize = 0;
            this.btnRelClientePrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelClientePrio.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelClientePrio.ForeColor = System.Drawing.Color.White;
            this.btnRelClientePrio.Location = new System.Drawing.Point(-3, 39);
            this.btnRelClientePrio.Name = "btnRelClientePrio";
            this.btnRelClientePrio.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnRelClientePrio.Size = new System.Drawing.Size(324, 31);
            this.btnRelClientePrio.TabIndex = 3;
            this.btnRelClientePrio.Text = "CHAMADOS CLIENTE P/ PRIOR.";
            this.btnRelClientePrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelClientePrio.UseVisualStyleBackColor = false;
            // 
            // btnRelTecnico
            // 
            this.btnRelTecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRelTecnico.FlatAppearance.BorderSize = 0;
            this.btnRelTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelTecnico.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelTecnico.ForeColor = System.Drawing.Color.White;
            this.btnRelTecnico.Location = new System.Drawing.Point(-3, 3);
            this.btnRelTecnico.Name = "btnRelTecnico";
            this.btnRelTecnico.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnRelTecnico.Size = new System.Drawing.Size(321, 40);
            this.btnRelTecnico.TabIndex = 2;
            this.btnRelTecnico.Text = "CHAMADOS P/ TECNICO";
            this.btnRelTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelTecnico.UseVisualStyleBackColor = false;
            this.btnRelTecnico.Click += new System.EventHandler(this.btnRelTecnico_Click);
            // 
            // btnMovimentacao
            // 
            this.btnMovimentacao.AutoSize = true;
            this.btnMovimentacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            this.btnMovimentacao.FlatAppearance.BorderSize = 0;
            this.btnMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimentacao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentacao.ForeColor = System.Drawing.Color.White;
            this.btnMovimentacao.Location = new System.Drawing.Point(0, 255);
            this.btnMovimentacao.Name = "btnMovimentacao";
            this.btnMovimentacao.Size = new System.Drawing.Size(318, 32);
            this.btnMovimentacao.TabIndex = 5;
            this.btnMovimentacao.Text = "MOVIMENTAÇÃO";
            this.btnMovimentacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimentacao.UseVisualStyleBackColor = false;
            this.btnMovimentacao.Click += new System.EventHandler(this.btnMovimentacao_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.AutoSize = true;
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Location = new System.Drawing.Point(0, 129);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(318, 32);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "CADASTRO";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // pnMovimentacao
            // 
            this.pnMovimentacao.Controls.Add(this.btnMovDesempenho);
            this.pnMovimentacao.Controls.Add(this.btnMovNaoResolvido);
            this.pnMovimentacao.HorizontalScrollbarBarColor = true;
            this.pnMovimentacao.HorizontalScrollbarHighlightOnWheel = false;
            this.pnMovimentacao.HorizontalScrollbarSize = 10;
            this.pnMovimentacao.Location = new System.Drawing.Point(0, 289);
            this.pnMovimentacao.Name = "pnMovimentacao";
            this.pnMovimentacao.Size = new System.Drawing.Size(318, 61);
            this.pnMovimentacao.TabIndex = 6;
            this.pnMovimentacao.VerticalScrollbarBarColor = true;
            this.pnMovimentacao.VerticalScrollbarHighlightOnWheel = false;
            this.pnMovimentacao.VerticalScrollbarSize = 10;
            // 
            // btnMovDesempenho
            // 
            this.btnMovDesempenho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMovDesempenho.FlatAppearance.BorderSize = 0;
            this.btnMovDesempenho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovDesempenho.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovDesempenho.ForeColor = System.Drawing.Color.White;
            this.btnMovDesempenho.Location = new System.Drawing.Point(-3, 30);
            this.btnMovDesempenho.Name = "btnMovDesempenho";
            this.btnMovDesempenho.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnMovDesempenho.Size = new System.Drawing.Size(324, 31);
            this.btnMovDesempenho.TabIndex = 3;
            this.btnMovDesempenho.Text = "DESEMPENHO EQUIPE";
            this.btnMovDesempenho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovDesempenho.UseVisualStyleBackColor = false;
            this.btnMovDesempenho.Click += new System.EventHandler(this.btnMovDesempenho_Click);
            // 
            // btnMovNaoResolvido
            // 
            this.btnMovNaoResolvido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMovNaoResolvido.FlatAppearance.BorderSize = 0;
            this.btnMovNaoResolvido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovNaoResolvido.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovNaoResolvido.ForeColor = System.Drawing.Color.White;
            this.btnMovNaoResolvido.Location = new System.Drawing.Point(-3, 0);
            this.btnMovNaoResolvido.Name = "btnMovNaoResolvido";
            this.btnMovNaoResolvido.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnMovNaoResolvido.Size = new System.Drawing.Size(321, 33);
            this.btnMovNaoResolvido.TabIndex = 2;
            this.btnMovNaoResolvido.Text = "NAO RESOLVIDOS";
            this.btnMovNaoResolvido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovNaoResolvido.UseVisualStyleBackColor = false;
            // 
            // pnCadastro
            // 
            this.pnCadastro.Controls.Add(this.btnCadTecnicos);
            this.pnCadastro.Controls.Add(this.btnCadCategoria);
            this.pnCadastro.Controls.Add(this.btnCadImportarPlanilha);
            this.pnCadastro.HorizontalScrollbarBarColor = true;
            this.pnCadastro.HorizontalScrollbarHighlightOnWheel = false;
            this.pnCadastro.HorizontalScrollbarSize = 10;
            this.pnCadastro.Location = new System.Drawing.Point(0, 160);
            this.pnCadastro.Name = "pnCadastro";
            this.pnCadastro.Size = new System.Drawing.Size(318, 96);
            this.pnCadastro.TabIndex = 4;
            this.pnCadastro.VerticalScrollbarBarColor = true;
            this.pnCadastro.VerticalScrollbarHighlightOnWheel = false;
            this.pnCadastro.VerticalScrollbarSize = 10;
            // 
            // btnCadTecnicos
            // 
            this.btnCadTecnicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCadTecnicos.FlatAppearance.BorderSize = 0;
            this.btnCadTecnicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadTecnicos.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadTecnicos.ForeColor = System.Drawing.Color.White;
            this.btnCadTecnicos.Location = new System.Drawing.Point(0, 58);
            this.btnCadTecnicos.Name = "btnCadTecnicos";
            this.btnCadTecnicos.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnCadTecnicos.Size = new System.Drawing.Size(318, 38);
            this.btnCadTecnicos.TabIndex = 4;
            this.btnCadTecnicos.Text = "TECNICOS";
            this.btnCadTecnicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadTecnicos.UseVisualStyleBackColor = false;
            this.btnCadTecnicos.Click += new System.EventHandler(this.btnCadTecnicos_Click);
            // 
            // btnCadCategoria
            // 
            this.btnCadCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCadCategoria.FlatAppearance.BorderSize = 0;
            this.btnCadCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCategoria.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCadCategoria.Location = new System.Drawing.Point(0, 30);
            this.btnCadCategoria.Name = "btnCadCategoria";
            this.btnCadCategoria.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnCadCategoria.Size = new System.Drawing.Size(318, 31);
            this.btnCadCategoria.TabIndex = 3;
            this.btnCadCategoria.Text = "CATEGORIA";
            this.btnCadCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadCategoria.UseVisualStyleBackColor = false;
            this.btnCadCategoria.Click += new System.EventHandler(this.btnCadCategoria_Click);
            // 
            // btnCadImportarPlanilha
            // 
            this.btnCadImportarPlanilha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCadImportarPlanilha.FlatAppearance.BorderSize = 0;
            this.btnCadImportarPlanilha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadImportarPlanilha.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadImportarPlanilha.ForeColor = System.Drawing.Color.White;
            this.btnCadImportarPlanilha.Location = new System.Drawing.Point(0, 0);
            this.btnCadImportarPlanilha.Name = "btnCadImportarPlanilha";
            this.btnCadImportarPlanilha.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnCadImportarPlanilha.Size = new System.Drawing.Size(318, 33);
            this.btnCadImportarPlanilha.TabIndex = 2;
            this.btnCadImportarPlanilha.Text = "IMPORTAR PLANILHA";
            this.btnCadImportarPlanilha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadImportarPlanilha.UseVisualStyleBackColor = false;
            this.btnCadImportarPlanilha.Click += new System.EventHandler(this.btnCadImportarPlanilha_Click);
            // 
            // tmMenu
            // 
            this.tmMenu.Interval = 1;
            this.tmMenu.Tick += new System.EventHandler(this.tmMenu_Tick);
            // 
            // lblGraphicColumn
            // 
            this.lblGraphicColumn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGraphicColumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGraphicColumn.Image = ((System.Drawing.Image)(resources.GetObject("lblGraphicColumn.Image")));
            this.lblGraphicColumn.Location = new System.Drawing.Point(1034, 134);
            this.lblGraphicColumn.Name = "lblGraphicColumn";
            this.lblGraphicColumn.Size = new System.Drawing.Size(63, 58);
            this.lblGraphicColumn.TabIndex = 16;
            this.lblGraphicColumn.Click += new System.EventHandler(this.lblGraphicColumn_Click);
            // 
            // lblGraphicPizza
            // 
            this.lblGraphicPizza.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGraphicPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGraphicPizza.Image = ((System.Drawing.Image)(resources.GetObject("lblGraphicPizza.Image")));
            this.lblGraphicPizza.Location = new System.Drawing.Point(1034, 208);
            this.lblGraphicPizza.Name = "lblGraphicPizza";
            this.lblGraphicPizza.Size = new System.Drawing.Size(63, 58);
            this.lblGraphicPizza.TabIndex = 17;
            this.lblGraphicPizza.Click += new System.EventHandler(this.lblGraphicPizza_Click);
            // 
            // lblLineGraphic
            // 
            this.lblLineGraphic.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLineGraphic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLineGraphic.Image = ((System.Drawing.Image)(resources.GetObject("lblLineGraphic.Image")));
            this.lblLineGraphic.Location = new System.Drawing.Point(1037, 271);
            this.lblLineGraphic.Name = "lblLineGraphic";
            this.lblLineGraphic.Size = new System.Drawing.Size(60, 58);
            this.lblLineGraphic.TabIndex = 18;
            this.lblLineGraphic.Click += new System.EventHandler(this.lblLineGraphic_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 728);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.metroPanel1);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.pnConfiguracao.ResumeLayout(false);
            this.pnRelatorio.ResumeLayout(false);
            this.pnMovimentacao.ResumeLayout(false);
            this.pnCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileCsv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel pnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmMenu;
        private System.Windows.Forms.Button btnCadastro;
        private MetroFramework.Controls.MetroPanel pnCadastro;
        private System.Windows.Forms.Button btnCadTecnicos;
        private System.Windows.Forms.Button btnCadCategoria;
        private System.Windows.Forms.Button btnCadImportarPlanilha;
        private System.Windows.Forms.Button btnRelatorio;
        private MetroFramework.Controls.MetroPanel pnRelatorio;
        private System.Windows.Forms.Button btnRelClienteRede;
        private System.Windows.Forms.Button btnRelClientePrio;
        private System.Windows.Forms.Button btnRelTecnico;
        private System.Windows.Forms.Button btnMovimentacao;
        private MetroFramework.Controls.MetroPanel pnMovimentacao;
        private System.Windows.Forms.Button btnMovDesempenho;
        private System.Windows.Forms.Button btnMovNaoResolvido;
        private System.Windows.Forms.Button btnConfiguracao;
        private MetroFramework.Controls.MetroPanel pnConfiguracao;
        private System.Windows.Forms.Button btnTempoSla;
        private System.Windows.Forms.Button btnConfPlanilha;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Label label2;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtDe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtAte;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.Label lblGraphicPizza;
        private System.Windows.Forms.Label lblGraphicColumn;
        private System.Windows.Forms.Label lblLineGraphic;
    }
}
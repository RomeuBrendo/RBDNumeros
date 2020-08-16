namespace RBDNumeros.Viwer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.openFileCsv = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnMenu = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfiguracao = new System.Windows.Forms.Button();
            this.pnConfiguracao = new MetroFramework.Controls.MetroPanel();
            this.btnExcluirTicket = new System.Windows.Forms.Button();
            this.btnConfPlanilha = new System.Windows.Forms.Button();
            this.btnTempoSla = new System.Windows.Forms.Button();
            this.btnKpi = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.pnMovimentacao = new MetroFramework.Controls.MetroPanel();
            this.btnKpiChamadPorCarteira = new System.Windows.Forms.Button();
            this.btnKpiChamadPorSla = new System.Windows.Forms.Button();
            this.pnCadastro = new MetroFramework.Controls.MetroPanel();
            this.btnCadTecnicos = new System.Windows.Forms.Button();
            this.btnCadCategoria = new System.Windows.Forms.Button();
            this.btnCadImportarPlanilha = new System.Windows.Forms.Button();
            this.tmMenu = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.pnConfiguracao.SuspendLayout();
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
            this.pnMenu.Controls.Add(this.btnKpi);
            this.pnMenu.Controls.Add(this.btnCadastro);
            this.pnMenu.Controls.Add(this.pnMovimentacao);
            this.pnMenu.Controls.Add(this.pnCadastro);
            this.pnMenu.HorizontalScrollbar = true;
            this.pnMenu.HorizontalScrollbarBarColor = false;
            this.pnMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnMenu.HorizontalScrollbarSize = 0;
            this.pnMenu.Location = new System.Drawing.Point(-1, 1);
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
            this.metroPanel2.Size = new System.Drawing.Size(321, 119);
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
            this.btnConfiguracao.Location = new System.Drawing.Point(0, 364);
            this.btnConfiguracao.Name = "btnConfiguracao";
            this.btnConfiguracao.Size = new System.Drawing.Size(318, 36);
            this.btnConfiguracao.TabIndex = 9;
            this.btnConfiguracao.Text = "CONFIGURAÇÕES";
            this.btnConfiguracao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguracao.UseVisualStyleBackColor = false;
            this.btnConfiguracao.Click += new System.EventHandler(this.btnConfiguracao_Click);
            // 
            // pnConfiguracao
            // 
            this.pnConfiguracao.Controls.Add(this.btnExcluirTicket);
            this.pnConfiguracao.Controls.Add(this.btnConfPlanilha);
            this.pnConfiguracao.Controls.Add(this.btnTempoSla);
            this.pnConfiguracao.HorizontalScrollbarBarColor = true;
            this.pnConfiguracao.HorizontalScrollbarHighlightOnWheel = false;
            this.pnConfiguracao.HorizontalScrollbarSize = 10;
            this.pnConfiguracao.Location = new System.Drawing.Point(0, 399);
            this.pnConfiguracao.Name = "pnConfiguracao";
            this.pnConfiguracao.Size = new System.Drawing.Size(318, 100);
            this.pnConfiguracao.TabIndex = 10;
            this.pnConfiguracao.VerticalScrollbarBarColor = true;
            this.pnConfiguracao.VerticalScrollbarHighlightOnWheel = false;
            this.pnConfiguracao.VerticalScrollbarSize = 10;
            // 
            // btnExcluirTicket
            // 
            this.btnExcluirTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExcluirTicket.FlatAppearance.BorderSize = 0;
            this.btnExcluirTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirTicket.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTicket.ForeColor = System.Drawing.Color.White;
            this.btnExcluirTicket.Location = new System.Drawing.Point(-3, 66);
            this.btnExcluirTicket.Name = "btnExcluirTicket";
            this.btnExcluirTicket.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnExcluirTicket.Size = new System.Drawing.Size(324, 34);
            this.btnExcluirTicket.TabIndex = 4;
            this.btnExcluirTicket.Text = "EXCLUIR TICKETS";
            this.btnExcluirTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirTicket.UseVisualStyleBackColor = false;
            this.btnExcluirTicket.Click += new System.EventHandler(this.btnExcluirTicket_Click);
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
            this.btnConfPlanilha.Size = new System.Drawing.Size(330, 34);
            this.btnConfPlanilha.TabIndex = 2;
            this.btnConfPlanilha.Text = "IMPORTAÇÃO PLANILHA";
            this.btnConfPlanilha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfPlanilha.UseVisualStyleBackColor = false;
            this.btnConfPlanilha.Click += new System.EventHandler(this.btnConfPlanilha_Click);
            // 
            // btnTempoSla
            // 
            this.btnTempoSla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTempoSla.FlatAppearance.BorderSize = 0;
            this.btnTempoSla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTempoSla.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTempoSla.ForeColor = System.Drawing.Color.White;
            this.btnTempoSla.Location = new System.Drawing.Point(-3, 34);
            this.btnTempoSla.Name = "btnTempoSla";
            this.btnTempoSla.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnTempoSla.Size = new System.Drawing.Size(324, 34);
            this.btnTempoSla.TabIndex = 3;
            this.btnTempoSla.Text = "TEMPO SLA";
            this.btnTempoSla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTempoSla.UseVisualStyleBackColor = false;
            this.btnTempoSla.Click += new System.EventHandler(this.btnTempoSla_Click);
            // 
            // btnKpi
            // 
            this.btnKpi.AutoSize = true;
            this.btnKpi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(17)))), ((int)(((byte)(49)))));
            this.btnKpi.FlatAppearance.BorderSize = 0;
            this.btnKpi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKpi.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKpi.ForeColor = System.Drawing.Color.White;
            this.btnKpi.Location = new System.Drawing.Point(0, 265);
            this.btnKpi.Name = "btnKpi";
            this.btnKpi.Size = new System.Drawing.Size(318, 32);
            this.btnKpi.TabIndex = 5;
            this.btnKpi.Text = "KPI";
            this.btnKpi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKpi.UseVisualStyleBackColor = false;
            this.btnKpi.Click += new System.EventHandler(this.btnMovimentacao_Click);
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
            this.pnMovimentacao.Controls.Add(this.btnKpiChamadPorCarteira);
            this.pnMovimentacao.Controls.Add(this.btnKpiChamadPorSla);
            this.pnMovimentacao.HorizontalScrollbarBarColor = true;
            this.pnMovimentacao.HorizontalScrollbarHighlightOnWheel = false;
            this.pnMovimentacao.HorizontalScrollbarSize = 10;
            this.pnMovimentacao.Location = new System.Drawing.Point(0, 299);
            this.pnMovimentacao.Name = "pnMovimentacao";
            this.pnMovimentacao.Size = new System.Drawing.Size(318, 64);
            this.pnMovimentacao.TabIndex = 6;
            this.pnMovimentacao.VerticalScrollbarBarColor = true;
            this.pnMovimentacao.VerticalScrollbarHighlightOnWheel = false;
            this.pnMovimentacao.VerticalScrollbarSize = 10;
            // 
            // btnKpiChamadPorCarteira
            // 
            this.btnKpiChamadPorCarteira.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKpiChamadPorCarteira.FlatAppearance.BorderSize = 0;
            this.btnKpiChamadPorCarteira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKpiChamadPorCarteira.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKpiChamadPorCarteira.ForeColor = System.Drawing.Color.White;
            this.btnKpiChamadPorCarteira.Location = new System.Drawing.Point(-3, 33);
            this.btnKpiChamadPorCarteira.Name = "btnKpiChamadPorCarteira";
            this.btnKpiChamadPorCarteira.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnKpiChamadPorCarteira.Size = new System.Drawing.Size(324, 32);
            this.btnKpiChamadPorCarteira.TabIndex = 3;
            this.btnKpiChamadPorCarteira.Text = "CHAMADOS POR CARTEIRA";
            this.btnKpiChamadPorCarteira.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKpiChamadPorCarteira.UseVisualStyleBackColor = false;
            this.btnKpiChamadPorCarteira.Click += new System.EventHandler(this.btnMovDesempenho_Click);
            // 
            // btnKpiChamadPorSla
            // 
            this.btnKpiChamadPorSla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKpiChamadPorSla.FlatAppearance.BorderSize = 0;
            this.btnKpiChamadPorSla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKpiChamadPorSla.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKpiChamadPorSla.ForeColor = System.Drawing.Color.White;
            this.btnKpiChamadPorSla.Location = new System.Drawing.Point(-3, 0);
            this.btnKpiChamadPorSla.Name = "btnKpiChamadPorSla";
            this.btnKpiChamadPorSla.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.btnKpiChamadPorSla.Size = new System.Drawing.Size(321, 33);
            this.btnKpiChamadPorSla.TabIndex = 2;
            this.btnKpiChamadPorSla.Text = "CHAMADOS POR SLA";
            this.btnKpiChamadPorSla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKpiChamadPorSla.UseVisualStyleBackColor = false;
            this.btnKpiChamadPorSla.Click += new System.EventHandler(this.btnKpiChamadPorSla_Click);
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
            this.pnCadastro.Size = new System.Drawing.Size(318, 103);
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
            this.btnCadTecnicos.Location = new System.Drawing.Point(0, 65);
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
            this.btnCadCategoria.Location = new System.Drawing.Point(0, 34);
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
            this.btnCadImportarPlanilha.Location = new System.Drawing.Point(0, 1);
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(309, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(522, 341);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Location = new System.Drawing.Point(-1, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1143, 88);
            this.panel.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1140, 728);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "RG2 System";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.pnConfiguracao.ResumeLayout(false);
            this.pnMovimentacao.ResumeLayout(false);
            this.pnCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileCsv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroPanel pnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmMenu;
        private System.Windows.Forms.Button btnCadastro;
        private MetroFramework.Controls.MetroPanel pnCadastro;
        private System.Windows.Forms.Button btnCadTecnicos;
        private System.Windows.Forms.Button btnCadCategoria;
        private System.Windows.Forms.Button btnCadImportarPlanilha;
        private System.Windows.Forms.Button btnKpi;
        private MetroFramework.Controls.MetroPanel pnMovimentacao;
        private System.Windows.Forms.Button btnKpiChamadPorCarteira;
        private System.Windows.Forms.Button btnKpiChamadPorSla;
        private System.Windows.Forms.Button btnConfiguracao;
        private MetroFramework.Controls.MetroPanel pnConfiguracao;
        private System.Windows.Forms.Button btnTempoSla;
        private System.Windows.Forms.Button btnConfPlanilha;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Label label2;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExcluirTicket;
        private System.Windows.Forms.Panel panel;
    }
}
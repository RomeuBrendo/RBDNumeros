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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarPlanilhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usúariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nRNãoResolvidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relátoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamadosPorTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientePorPrioridadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesRedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importaçãoPlanilhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileCsv = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem,
            this.relátoriosToolStripMenuItem,
            this.configuraçãoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarPlanilhaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.usúariosToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // importarPlanilhaToolStripMenuItem
            // 
            this.importarPlanilhaToolStripMenuItem.Name = "importarPlanilhaToolStripMenuItem";
            this.importarPlanilhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importarPlanilhaToolStripMenuItem.Text = "Importar Planilha";
            this.importarPlanilhaToolStripMenuItem.Click += new System.EventHandler(this.importarPlanilhaToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // usúariosToolStripMenuItem
            // 
            this.usúariosToolStripMenuItem.Name = "usúariosToolStripMenuItem";
            this.usúariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usúariosToolStripMenuItem.Text = "Técnicos";
            this.usúariosToolStripMenuItem.Click += new System.EventHandler(this.usúariosToolStripMenuItem_Click);
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nRNãoResolvidosToolStripMenuItem,
            this.performanceTécnicoToolStripMenuItem});
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentação";
            // 
            // nRNãoResolvidosToolStripMenuItem
            // 
            this.nRNãoResolvidosToolStripMenuItem.Name = "nRNãoResolvidosToolStripMenuItem";
            this.nRNãoResolvidosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.nRNãoResolvidosToolStripMenuItem.Text = "NR Não Resolvidos";
            // 
            // performanceTécnicoToolStripMenuItem
            // 
            this.performanceTécnicoToolStripMenuItem.Name = "performanceTécnicoToolStripMenuItem";
            this.performanceTécnicoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.performanceTécnicoToolStripMenuItem.Text = "Desempenho Equipe";
            // 
            // relátoriosToolStripMenuItem
            // 
            this.relátoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chamadosPorTécnicoToolStripMenuItem,
            this.clientePorPrioridadeToolStripMenuItem,
            this.clientesRedeToolStripMenuItem});
            this.relátoriosToolStripMenuItem.Name = "relátoriosToolStripMenuItem";
            this.relátoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relátoriosToolStripMenuItem.Text = "Relátorios";
            // 
            // chamadosPorTécnicoToolStripMenuItem
            // 
            this.chamadosPorTécnicoToolStripMenuItem.Name = "chamadosPorTécnicoToolStripMenuItem";
            this.chamadosPorTécnicoToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.chamadosPorTécnicoToolStripMenuItem.Text = "Chamados por Técnico";
            // 
            // clientePorPrioridadeToolStripMenuItem
            // 
            this.clientePorPrioridadeToolStripMenuItem.Name = "clientePorPrioridadeToolStripMenuItem";
            this.clientePorPrioridadeToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.clientePorPrioridadeToolStripMenuItem.Text = "Chamados Cliente por Prioridade";
            // 
            // clientesRedeToolStripMenuItem
            // 
            this.clientesRedeToolStripMenuItem.Name = "clientesRedeToolStripMenuItem";
            this.clientesRedeToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.clientesRedeToolStripMenuItem.Text = "Clientes Rede";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importaçãoPlanilhaToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // importaçãoPlanilhaToolStripMenuItem
            // 
            this.importaçãoPlanilhaToolStripMenuItem.Name = "importaçãoPlanilhaToolStripMenuItem";
            this.importaçãoPlanilhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importaçãoPlanilhaToolStripMenuItem.Text = "Importação Planilha";
            this.importaçãoPlanilhaToolStripMenuItem.Click += new System.EventHandler(this.importaçãoPlanilhaToolStripMenuItem_Click);
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
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1004, 471);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarPlanilhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usúariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nRNãoResolvidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performanceTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relátoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamadosPorTécnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientePorPrioridadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesRedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importaçãoPlanilhaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileCsv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
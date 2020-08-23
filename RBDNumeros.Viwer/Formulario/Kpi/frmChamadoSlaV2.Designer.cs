namespace RBDNumeros.Viwer.Formulario.Kpi
{
    partial class frmChamadoSlaV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamadoSlaV2));
            this.reportViewerChamadosPorSla = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblRefresh = new System.Windows.Forms.Label();
            this.DataFim = new System.Windows.Forms.DateTimePicker();
            this.DataInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCarteira = new System.Windows.Forms.ComboBox();
            this.checkAscendente = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnTop10 = new System.Windows.Forms.Panel();
            this.pnTop10.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerChamadosPorSla
            // 
            this.reportViewerChamadosPorSla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerChamadosPorSla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewerChamadosPorSla.CausesValidation = false;
            this.reportViewerChamadosPorSla.LocalReport.ReportEmbeddedResource = "RBDNumeros.Viwer.RDLC.ReportChamadoSla.rdlc";
            this.reportViewerChamadosPorSla.LocalReport.ReportPath = "";
            this.reportViewerChamadosPorSla.Location = new System.Drawing.Point(18, 126);
            this.reportViewerChamadosPorSla.Name = "reportViewerChamadosPorSla";
            this.reportViewerChamadosPorSla.ServerReport.BearerToken = null;
            this.reportViewerChamadosPorSla.ShowToolBar = false;
            this.reportViewerChamadosPorSla.Size = new System.Drawing.Size(677, 498);
            this.reportViewerChamadosPorSla.TabIndex = 0;
            this.reportViewerChamadosPorSla.Visible = false;
            // 
            // lblRefresh
            // 
            this.lblRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRefresh.Image = ((System.Drawing.Image)(resources.GetObject("lblRefresh.Image")));
            this.lblRefresh.Location = new System.Drawing.Point(624, 86);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(39, 38);
            this.lblRefresh.TabIndex = 19;
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // DataFim
            // 
            this.DataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataFim.Location = new System.Drawing.Point(184, 98);
            this.DataFim.MaximumSize = new System.Drawing.Size(98, 20);
            this.DataFim.MinimumSize = new System.Drawing.Size(98, 20);
            this.DataFim.Name = "DataFim";
            this.DataFim.Size = new System.Drawing.Size(98, 20);
            this.DataFim.TabIndex = 17;
            this.DataFim.ValueChanged += new System.EventHandler(this.DataFim_ValueChanged);
            // 
            // DataInicio
            // 
            this.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataInicio.Location = new System.Drawing.Point(42, 98);
            this.DataInicio.MaximumSize = new System.Drawing.Size(98, 20);
            this.DataInicio.MinimumSize = new System.Drawing.Size(98, 20);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(98, 20);
            this.DataInicio.TabIndex = 16;
            this.DataInicio.ValueChanged += new System.EventHandler(this.DataInicio_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "até";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(716, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 55);
            this.label1.TabIndex = 21;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(716, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 55);
            this.label2.TabIndex = 22;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(716, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 55);
            this.label3.TabIndex = 23;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(716, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 55);
            this.label5.TabIndex = 24;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbCarteira
            // 
            this.cbCarteira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarteira.FormattingEnabled = true;
            this.cbCarteira.Items.AddRange(new object[] {
            "Carteira A",
            "Carteira B",
            "Carteira C",
            "Carteira D",
            "<Todas>"});
            this.cbCarteira.Location = new System.Drawing.Point(50, 2);
            this.cbCarteira.Name = "cbCarteira";
            this.cbCarteira.Size = new System.Drawing.Size(91, 21);
            this.cbCarteira.TabIndex = 25;
            this.cbCarteira.Tag = "";
            this.cbCarteira.SelectedIndexChanged += new System.EventHandler(this.cbCarteira_SelectedIndexChanged);
            // 
            // checkAscendente
            // 
            this.checkAscendente.AutoSize = true;
            this.checkAscendente.Location = new System.Drawing.Point(160, 6);
            this.checkAscendente.Name = "checkAscendente";
            this.checkAscendente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkAscendente.Size = new System.Drawing.Size(124, 17);
            this.checkAscendente.TabIndex = 26;
            this.checkAscendente.Text = "Ordenar Ascendente";
            this.checkAscendente.UseVisualStyleBackColor = true;
            this.checkAscendente.CheckedChanged += new System.EventHandler(this.checkAscendente_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Carteira:";
            // 
            // pnTop10
            // 
            this.pnTop10.Controls.Add(this.cbCarteira);
            this.pnTop10.Controls.Add(this.label6);
            this.pnTop10.Controls.Add(this.checkAscendente);
            this.pnTop10.Location = new System.Drawing.Point(312, 94);
            this.pnTop10.Name = "pnTop10";
            this.pnTop10.Size = new System.Drawing.Size(294, 25);
            this.pnTop10.TabIndex = 28;
            // 
            // frmChamadoSlaV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 660);
            this.Controls.Add(this.reportViewerChamadosPorSla);
            this.Controls.Add(this.pnTop10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRefresh);
            this.Controls.Add(this.DataFim);
            this.Controls.Add(this.DataInicio);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChamadoSlaV2";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Chamados Por SLA";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmChamadoSlaV2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChamadoSlaV2_KeyDown);
            this.pnTop10.ResumeLayout(false);
            this.pnTop10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerChamadosPorSla;
        private System.Windows.Forms.Label lblRefresh;
        private System.Windows.Forms.DateTimePicker DataFim;
        private System.Windows.Forms.DateTimePicker DataInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCarteira;
        private System.Windows.Forms.CheckBox checkAscendente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnTop10;
    }
}
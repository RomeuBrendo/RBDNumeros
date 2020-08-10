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
            this.SuspendLayout();
            // 
            // reportViewerChamadosPorSla
            // 
            this.reportViewerChamadosPorSla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewerChamadosPorSla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewerChamadosPorSla.LocalReport.ReportEmbeddedResource = "RBDNumeros.Viwer.RDLC.ReportChamadoSla.rdlc";
            this.reportViewerChamadosPorSla.Location = new System.Drawing.Point(18, 112);
            this.reportViewerChamadosPorSla.Name = "reportViewerChamadosPorSla";
            this.reportViewerChamadosPorSla.ServerReport.BearerToken = null;
            this.reportViewerChamadosPorSla.Size = new System.Drawing.Size(924, 461);
            this.reportViewerChamadosPorSla.TabIndex = 0;
            this.reportViewerChamadosPorSla.Visible = false;
            // 
            // lblRefresh
            // 
            this.lblRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRefresh.Image = ((System.Drawing.Image)(resources.GetObject("lblRefresh.Image")));
            this.lblRefresh.Location = new System.Drawing.Point(284, 53);
            this.lblRefresh.Name = "lblRefresh";
            this.lblRefresh.Size = new System.Drawing.Size(39, 38);
            this.lblRefresh.TabIndex = 19;
            this.lblRefresh.Click += new System.EventHandler(this.lblRefresh_Click);
            // 
            // DataFim
            // 
            this.DataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataFim.Location = new System.Drawing.Point(170, 63);
            this.DataFim.MaximumSize = new System.Drawing.Size(98, 20);
            this.DataFim.MinimumSize = new System.Drawing.Size(98, 20);
            this.DataFim.Name = "DataFim";
            this.DataFim.Size = new System.Drawing.Size(98, 20);
            this.DataFim.TabIndex = 17;
            // 
            // DataInicio
            // 
            this.DataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataInicio.Location = new System.Drawing.Point(18, 63);
            this.DataInicio.MaximumSize = new System.Drawing.Size(98, 20);
            this.DataInicio.MinimumSize = new System.Drawing.Size(98, 20);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(98, 20);
            this.DataInicio.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "até";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(948, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 55);
            this.label1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(948, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 55);
            this.label2.TabIndex = 22;
            // 
            // frmChamadoSlaV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 670);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRefresh);
            this.Controls.Add(this.DataFim);
            this.Controls.Add(this.DataInicio);
            this.Controls.Add(this.reportViewerChamadosPorSla);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmChamadoSlaV2";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Chamados Por SLA";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmChamadoSlaV2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChamadoSlaV2_KeyDown);
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
    }
}
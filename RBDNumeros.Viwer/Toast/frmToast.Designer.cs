namespace RBDNumeros.Viwer.Toast
{
    partial class frmToast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToast));
            this.label1 = new System.Windows.Forms.Label();
            this.TimerClose = new System.Windows.Forms.Timer(this.components);
            this.Info = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.okay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerClose
            // 
            this.TimerClose.Interval = 3000;
            this.TimerClose.Tick += new System.EventHandler(this.TimerClose_Tick);
            // 
            // Info
            // 
            this.Info.Image = ((System.Drawing.Image)(resources.GetObject("Info.Image")));
            this.Info.Location = new System.Drawing.Point(0, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(72, 66);
            this.Info.TabIndex = 1;
            // 
            // error
            // 
            this.error.Image = ((System.Drawing.Image)(resources.GetObject("error.Image")));
            this.error.Location = new System.Drawing.Point(0, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(72, 66);
            this.error.TabIndex = 2;
            // 
            // okay
            // 
            this.okay.Image = ((System.Drawing.Image)(resources.GetObject("okay.Image")));
            this.okay.Location = new System.Drawing.Point(0, 0);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(72, 66);
            this.okay.TabIndex = 3;
            // 
            // frmToast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(322, 67);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.error);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmToast";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmToast";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.frmToast_Deactivate);
            this.Load += new System.EventHandler(this.frmToast_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerClose;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label okay;
    }
}
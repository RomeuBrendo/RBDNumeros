namespace RBDNumeros.Viwer.Formulario.Configuracao
{
    partial class frmTempoSla
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDentroSla = new MetroFramework.Controls.MetroTextBox();
            this.txtAcima20 = new MetroFramework.Controls.MetroTextBox();
            this.txtEstourado = new MetroFramework.Controls.MetroTextBox();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dentro do SLA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SLA +20%:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fora do SLA:";
            // 
            // txtDentroSla
            // 
            // 
            // 
            // 
            this.txtDentroSla.CustomButton.Image = null;
            this.txtDentroSla.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtDentroSla.CustomButton.Name = "";
            this.txtDentroSla.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDentroSla.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDentroSla.CustomButton.TabIndex = 1;
            this.txtDentroSla.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDentroSla.CustomButton.UseSelectable = true;
            this.txtDentroSla.CustomButton.Visible = false;
            this.txtDentroSla.Lines = new string[0];
            this.txtDentroSla.Location = new System.Drawing.Point(205, 112);
            this.txtDentroSla.MaxLength = 32767;
            this.txtDentroSla.Name = "txtDentroSla";
            this.txtDentroSla.PasswordChar = '\0';
            this.txtDentroSla.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDentroSla.SelectedText = "";
            this.txtDentroSla.SelectionLength = 0;
            this.txtDentroSla.SelectionStart = 0;
            this.txtDentroSla.ShortcutsEnabled = true;
            this.txtDentroSla.Size = new System.Drawing.Size(101, 23);
            this.txtDentroSla.TabIndex = 0;
            this.txtDentroSla.UseSelectable = true;
            this.txtDentroSla.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDentroSla.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDentroSla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDentroSla_KeyDown);
            this.txtDentroSla.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmTempoSla_PreviewKeyDown);
            // 
            // txtAcima20
            // 
            // 
            // 
            // 
            this.txtAcima20.CustomButton.Image = null;
            this.txtAcima20.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtAcima20.CustomButton.Name = "";
            this.txtAcima20.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAcima20.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAcima20.CustomButton.TabIndex = 1;
            this.txtAcima20.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAcima20.CustomButton.UseSelectable = true;
            this.txtAcima20.CustomButton.Visible = false;
            this.txtAcima20.Lines = new string[0];
            this.txtAcima20.Location = new System.Drawing.Point(205, 159);
            this.txtAcima20.MaxLength = 32767;
            this.txtAcima20.Name = "txtAcima20";
            this.txtAcima20.PasswordChar = '\0';
            this.txtAcima20.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAcima20.SelectedText = "";
            this.txtAcima20.SelectionLength = 0;
            this.txtAcima20.SelectionStart = 0;
            this.txtAcima20.ShortcutsEnabled = true;
            this.txtAcima20.Size = new System.Drawing.Size(101, 23);
            this.txtAcima20.TabIndex = 1;
            this.txtAcima20.UseSelectable = true;
            this.txtAcima20.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAcima20.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAcima20.Click += new System.EventHandler(this.txtAcima20_Click);
            this.txtAcima20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcima20_KeyDown);
            this.txtAcima20.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmTempoSla_PreviewKeyDown);
            // 
            // txtEstourado
            // 
            // 
            // 
            // 
            this.txtEstourado.CustomButton.Image = null;
            this.txtEstourado.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtEstourado.CustomButton.Name = "";
            this.txtEstourado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEstourado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEstourado.CustomButton.TabIndex = 1;
            this.txtEstourado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEstourado.CustomButton.UseSelectable = true;
            this.txtEstourado.CustomButton.Visible = false;
            this.txtEstourado.Lines = new string[0];
            this.txtEstourado.Location = new System.Drawing.Point(205, 206);
            this.txtEstourado.MaxLength = 32767;
            this.txtEstourado.Name = "txtEstourado";
            this.txtEstourado.PasswordChar = '\0';
            this.txtEstourado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEstourado.SelectedText = "";
            this.txtEstourado.SelectionLength = 0;
            this.txtEstourado.SelectionStart = 0;
            this.txtEstourado.ShortcutsEnabled = true;
            this.txtEstourado.Size = new System.Drawing.Size(101, 23);
            this.txtEstourado.TabIndex = 2;
            this.txtEstourado.UseSelectable = true;
            this.txtEstourado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEstourado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEstourado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstourado_KeyDown);
            this.txtEstourado.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmTempoSla_PreviewKeyDown);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(110, 336);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmTempoSla_PreviewKeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(225, 336);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmTempoSla_PreviewKeyDown);
            // 
            // frmTempoSla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEstourado);
            this.Controls.Add(this.txtAcima20);
            this.Controls.Add(this.txtDentroSla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTempoSla";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Tempo SLA";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmTempoSla_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txtDentroSla;
        private MetroFramework.Controls.MetroTextBox txtAcima20;
        private MetroFramework.Controls.MetroTextBox txtEstourado;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroButton btnCancelar;
    }
}
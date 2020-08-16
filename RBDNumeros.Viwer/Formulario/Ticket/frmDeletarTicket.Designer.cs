namespace RBDNumeros.Viwer.Formulario.Ticket
{
    partial class frmDeletarTicket
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
            this.lblInicio = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DateInicio = new MetroFramework.Controls.MetroDateTime();
            this.DateFim = new MetroFramework.Controls.MetroDateTime();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(24, 149);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(73, 19);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Data Inicio:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 202);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Data Fim:";
            // 
            // DateInicio
            // 
            this.DateInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateInicio.Location = new System.Drawing.Point(111, 144);
            this.DateInicio.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateInicio.Name = "DateInicio";
            this.DateInicio.Size = new System.Drawing.Size(106, 29);
            this.DateInicio.TabIndex = 0;
            this.DateInicio.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDeletarTicket_PreviewKeyDown);
            // 
            // DateFim
            // 
            this.DateFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFim.Location = new System.Drawing.Point(111, 197);
            this.DateFim.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateFim.Name = "DateFim";
            this.DateFim.Size = new System.Drawing.Size(106, 29);
            this.DateFim.TabIndex = 1;
            this.DateFim.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDeletarTicket_PreviewKeyDown);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(137, 324);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDeletarTicket_PreviewKeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(259, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDeletarTicket_PreviewKeyDown);
            // 
            // frmDeletarTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 370);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.DateFim);
            this.Controls.Add(this.DateInicio);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblInicio);
            this.KeyPreview = true;
            this.Name = "frmDeletarTicket";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Exluir Tickets Importados";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frmDeletarTicket_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblInicio;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime DateInicio;
        private MetroFramework.Controls.MetroDateTime DateFim;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroButton btnCancelar;
    }
}
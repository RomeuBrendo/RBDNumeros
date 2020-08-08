namespace RBDNumeros.Viwer.Formulario.Configuracao
{
    partial class frmConfiguracaoExcel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.CBNumeroTicket = new System.Windows.Forms.ComboBox();
            this.CBNomeCliente = new System.Windows.Forms.ComboBox();
            this.CBCategoria = new System.Windows.Forms.ComboBox();
            this.CBDataAbertura = new System.Windows.Forms.ComboBox();
            this.CBDataResolvido = new System.Windows.Forms.ComboBox();
            this.CBTecnico = new System.Windows.Forms.ComboBox();
            this.CBCarteira = new System.Windows.Forms.ComboBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.cbcTempoVida = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número do Ticket:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Abertura Ticket:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Resolvido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tecnico:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(201, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Carteira:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(204, 423);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(76, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(364, 423);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CBNumeroTicket
            // 
            this.CBNumeroTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBNumeroTicket.FormattingEnabled = true;
            this.CBNumeroTicket.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.CBNumeroTicket.Location = new System.Drawing.Point(364, 90);
            this.CBNumeroTicket.Name = "CBNumeroTicket";
            this.CBNumeroTicket.Size = new System.Drawing.Size(76, 21);
            this.CBNumeroTicket.TabIndex = 0;
            // 
            // CBNomeCliente
            // 
            this.CBNomeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBNomeCliente.FormattingEnabled = true;
            this.CBNomeCliente.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.CBNomeCliente.Location = new System.Drawing.Point(364, 127);
            this.CBNomeCliente.Name = "CBNomeCliente";
            this.CBNomeCliente.Size = new System.Drawing.Size(76, 21);
            this.CBNomeCliente.TabIndex = 1;
            // 
            // CBCategoria
            // 
            this.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCategoria.FormattingEnabled = true;
            this.CBCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.CBCategoria.Location = new System.Drawing.Point(364, 164);
            this.CBCategoria.Name = "CBCategoria";
            this.CBCategoria.Size = new System.Drawing.Size(76, 21);
            this.CBCategoria.TabIndex = 2;
            // 
            // CBDataAbertura
            // 
            this.CBDataAbertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDataAbertura.FormattingEnabled = true;
            this.CBDataAbertura.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.CBDataAbertura.Location = new System.Drawing.Point(364, 201);
            this.CBDataAbertura.Name = "CBDataAbertura";
            this.CBDataAbertura.Size = new System.Drawing.Size(76, 21);
            this.CBDataAbertura.TabIndex = 3;
            // 
            // CBDataResolvido
            // 
            this.CBDataResolvido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDataResolvido.FormattingEnabled = true;
            this.CBDataResolvido.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.CBDataResolvido.Location = new System.Drawing.Point(364, 238);
            this.CBDataResolvido.Name = "CBDataResolvido";
            this.CBDataResolvido.Size = new System.Drawing.Size(76, 21);
            this.CBDataResolvido.TabIndex = 4;
            // 
            // CBTecnico
            // 
            this.CBTecnico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTecnico.FormattingEnabled = true;
            this.CBTecnico.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.CBTecnico.Location = new System.Drawing.Point(364, 275);
            this.CBTecnico.Name = "CBTecnico";
            this.CBTecnico.Size = new System.Drawing.Size(76, 21);
            this.CBTecnico.TabIndex = 5;
            // 
            // CBCarteira
            // 
            this.CBCarteira.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCarteira.FormattingEnabled = true;
            this.CBCarteira.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.CBCarteira.Location = new System.Drawing.Point(364, 313);
            this.CBCarteira.Name = "CBCarteira";
            this.CBCarteira.Size = new System.Drawing.Size(76, 21);
            this.CBCarteira.TabIndex = 6;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            // 
            // cbcTempoVida
            // 
            this.cbcTempoVida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcTempoVida.FormattingEnabled = true;
            this.cbcTempoVida.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbcTempoVida.Location = new System.Drawing.Point(364, 349);
            this.cbcTempoVida.Name = "cbcTempoVida";
            this.cbcTempoVida.Size = new System.Drawing.Size(76, 21);
            this.cbcTempoVida.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tempo Vida Ticket:";
            // 
            // frmConfiguracaoExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 488);
            this.Controls.Add(this.cbcTempoVida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CBCarteira);
            this.Controls.Add(this.CBTecnico);
            this.Controls.Add(this.CBDataResolvido);
            this.Controls.Add(this.CBDataAbertura);
            this.Controls.Add(this.CBCategoria);
            this.Controls.Add(this.CBNomeCliente);
            this.Controls.Add(this.CBNumeroTicket);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguracaoExcel";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Configuração Planilha";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.frmConfiguracaoExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox CBNumeroTicket;
        private System.Windows.Forms.ComboBox CBNomeCliente;
        private System.Windows.Forms.ComboBox CBCategoria;
        private System.Windows.Forms.ComboBox CBDataAbertura;
        private System.Windows.Forms.ComboBox CBDataResolvido;
        private System.Windows.Forms.ComboBox CBTecnico;
        private System.Windows.Forms.ComboBox CBCarteira;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ComboBox cbcTempoVida;
        private System.Windows.Forms.Label label9;
    }
}
using System;
using System.Windows.Forms;

namespace RBDNumeros.Viwer.Formulario.Barra
{
    public partial class frmBarraProgresso : MetroFramework.Forms.MetroForm
    {
        public frmBarraProgresso()
        {

            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            progressBar1.Value = 0;
          
        }

        public void CarregaBarraProgresso(int valor, string processo)
        {
            try
            {
                lbl1.BeginInvoke(
                   new Action(() =>
                    {
                         this.lbl1.Text = processo+" "+valor.ToString()+"%";
                    }
                ));

                this.backgroundWorker1.ReportProgress(valor);

                if(valor == 100)
                {
                    //MessageBox.Show("Importação Realizada com sucesso! Commit será finalizado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    return;
                }
            }
            catch (Exception)
            {

                return;
            }            


        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.BeginInvoke(
                new Action(() =>
                {
                    this.progressBar1.Value = e.ProgressPercentage;
                }));

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

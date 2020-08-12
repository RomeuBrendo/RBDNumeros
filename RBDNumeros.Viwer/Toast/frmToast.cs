using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBDNumeros.Viwer.Toast
{
    public partial class frmToast : Form
    {
        public frmToast(String Message, Color bgColor, String Action)
        {
            InitializeComponent();

            Info.Visible = false;
            error.Visible = false;
            okay.Visible = false;

            label1.Text = Message;
            this.BackColor = bgColor;

            if (Action == "Okay" || Action == "okay")
                okay.Visible = true;
            else if (Action == "Erro" || Action == "erro")
                error.Visible = true;
            else
                Info.Visible = true;



        }

        private void frmToast_Load(object sender, EventArgs e)
        {
            ArredondaCantosdoForm();
            Top = 40;
            Left = Screen.PrimaryScreen.Bounds.Width - 342;
            TimerClose.Start();
        }

        private void TimerClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmToast_Deactivate(object sender, EventArgs e)
        {
           
        }

        public void ArredondaCantosdoForm()
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, this.Size.Width, this.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(this.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, this.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, this.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(this.Width - 12, this.Height - 13, 13, 13));
            PastaGrafica.AddPie(this.Width - 24, this.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            this.Region = new Region(PastaGrafica);
        }

    }
}

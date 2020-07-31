using MetroFramework.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBDNumeros.Viwer.Formulario.Configuracao
{
    public partial class frmConfiguracaoSLA : MetroFramework.Forms.MetroForm
    {
        public frmConfiguracaoSLA()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(metroComboBox1.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    break;

                case 1:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;
            }
        }
    }
}

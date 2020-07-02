using RBDNumeros.Domain.Commands;
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
    public partial class frmConfiguracaoExcel : Form
    {
        public frmConfiguracaoExcel()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AdicionarConfiguracaoPlanilhaRequest adicionarConfiguracaoPlanilhaRequest = new AdicionarConfiguracaoPlanilhaRequest();
        
        }
    }
}

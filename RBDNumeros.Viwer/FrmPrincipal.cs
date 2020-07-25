using Microsoft.Extensions.DependencyInjection;
using RBDNumeros.Domain.Interfaces.Repositories;
using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Domain.Services;
using RBDNumeros.Infra.Repositories;
using RBDNumeros.Viwer.Formulario.Configuracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBDNumeros.Viwer
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void importaçãoPlanilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmConf = new frmConfiguracaoExcel();
            frmConf.MdiParent = this;
            frmConf.Show();
        }
    }
}

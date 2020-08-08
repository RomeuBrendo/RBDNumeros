using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Infra.Repositories.Transactions;
using System.Windows.Forms;

namespace RBDNumeros.Viwer.Formulario.Tecnico
{
    public partial class frmTecnico : MetroFramework.Forms.MetroForm
    {
        private IServiceTecnico _serviceTicket;
        private IUnitOfWork _unitOfWork;
        public frmTecnico()
        {
            InitializeComponent();
            ConsultarDepedencias();
            this.StyleManager = metroStyleManager1;
            dataGridTecnico.AutoGenerateColumns = false;
            AtualizaGrid();
        }
        void ConsultarDepedencias()
        {
            _serviceTicket = (IServiceTecnico)Program.ServiceProvider.GetService(typeof(IServiceTecnico));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));
        }
        public void AtualizaGrid()
        {
            dataGridTecnico.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridTecnico.DataSource = null;

            dataGridTecnico.DataSource = _serviceTicket.ListarTecnico(); 

            dataGridTecnico.Update();
            dataGridTecnico.Refresh();

        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            _unitOfWork.SaveChanges();
            MessageBox.Show("Alterações realizada com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Infra.Repositories.Transactions;
using RBDNumeros.Viwer.Toast;
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
            try
            {
                _unitOfWork.SaveChanges();
                frmToast toast = new frmToast("Alteração Salva com Sucesso!!", "Okay");
                toast.Show();
                this.Close();
            }
            catch
            {
                frmToast taoastErro = new frmToast("Erro ao Salvar informações no Banco de dados", "Erro");
                taoastErro.Show();
                this.Focus();
            }

        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void frmTecnico_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.F4)
                btnSalvar.PerformClick();
        }

        private void dataGridTecnico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
                e.Handled = true;
        }
    }
}

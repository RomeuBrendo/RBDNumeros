using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Infra.Repositories.Transactions;
using RBDNumeros.Viwer.Toast;
using System;
using System.Windows.Forms;

namespace RBDNumeros.Viwer.Formulario.Ticket
{
    public partial class frmDeletarTicket : MetroFramework.Forms.MetroForm
    {
        private IServiceTicket _serviceTicket;
        private IUnitOfWork _unitOfWork;

        void ConsultarDepedencias()
        {
            _serviceTicket = (IServiceTicket)Program.ServiceProvider.GetService(typeof(IServiceTicket));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));
        }
        public frmDeletarTicket()
        {
            InitializeComponent();
            ConsultarDepedencias();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
               var result = _serviceTicket.DeletarTickets(DateInicio.Value, DateFim.Value);
                _unitOfWork.SaveChanges();

                if (result)
                {
                    frmToast toast = new frmToast("Operação realizada com sucesso!!", "Okay");
                    toast.Show();
                    this.Close();
                }
                else
                {
                    frmToast toast = new frmToast("Erro ao realizar operação!!", "Erro");
                    toast.Show();
                }

            }
            catch
            {

                frmToast toast = new frmToast("Erro ao realizar operação!!", "Erro");
                toast.Show();
            }
        }

        private void frmDeletarTicket_PreviewKeyDown(object sender, System.Windows.Forms.PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
                btnExcluir.PerformClick();

            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}

using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Infra.Repositories.Transactions;
using System;
using System.Windows.Forms;

namespace RBDNumeros.Viwer.Formulario.Configuracao
{
    public partial class frmConfiguracaoExcel : Form
    {
        private IServiceConfiguracaoPlanilha _serviceConfiguracaoPlanilha;
        private IUnitOfWork _unitOfWork;

        void ConsultarDepedencias()
        {
            _serviceConfiguracaoPlanilha = (IServiceConfiguracaoPlanilha)Program.ServiceProvider.GetService(typeof(IServiceConfiguracaoPlanilha));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));
        }

        public frmConfiguracaoExcel()
        {
            ConsultarDepedencias();
            InitializeComponent();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarConfiguração();
        }

        public void SalvarConfiguração()
        {
            AdicionarConfiguracaoPlanilhaRequest confRequest = new AdicionarConfiguracaoPlanilhaRequest();

            try
            {
                confRequest.NumeroTicket = char.Parse(txtNumeroTicket.Text);
                confRequest.ClienteNome = char.Parse(txtNomeCliente.Text);
                confRequest.Categoria = char.Parse(txtCategoria.Text);
                confRequest.DataAberturaTicket = char.Parse(txtDataAbertura.Text);
                confRequest.DataResolvido = char.Parse(txtDataResolvido.Text);
                confRequest.Tecnico = char.Parse(txtTecnico.Text);
                confRequest.Carteira = char.Parse(txtCarteira.Text);

                _serviceConfiguracaoPlanilha.Adicionar(confRequest);

                _unitOfWork.SaveChanges();
            }
            catch (Exception)
            {

                Close();
            }


        }

        private void txtNumeroTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCampos(e);
            
            if(e.KeyChar == 13)
              txtNomeCliente.Focus();
        }

        void validaCampos(KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;

            //if ((txtNumeroTicket.TextLength > 0) && (e.KeyChar != 8))
            //    e.Handled = true;
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCampos(e);

            if (e.KeyChar == 13)
                txtCategoria.Focus();
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCampos(e);

            if (e.KeyChar == 13)
                txtDataAbertura.Focus();
        }

        private void txtDataAbertura_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCampos(e);

            if (e.KeyChar == 13)
                txtDataResolvido.Focus();
        }

        private void txtDataResolvido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCampos(e);

            if (e.KeyChar == 13)
                txtTecnico.Focus();
        }

        private void txtTecnico_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCampos(e);

            if (e.KeyChar == 13)
                txtCarteira.Focus();
        }

        private void txtCarteira_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCampos(e);

            if (e.KeyChar == 13)
                txtNumeroTicket.Focus();
        }
    }
}

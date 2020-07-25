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
            CarregarTela();

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                Close();
            }


        }

        void CarregarTela()
        {
            var conf = _serviceConfiguracaoPlanilha.CarregarConfiguracao();

            if (conf != null)
            {
                txtNumeroTicket.Text = conf.NumeroTicket.ToString();
                txtNomeCliente.Text = conf.ClienteNome.ToString();
                txtCategoria.Text = conf.Categoria.ToString();
                txtDataAbertura.Text = conf.DataAberturaTicket.ToString();
                txtDataResolvido.Text = conf.DataResolvido.ToString();
                txtTecnico.Text = conf.Tecnico.ToString();
                txtCarteira.Text = conf.Carteira.ToString();
             
            }
        }

        private void txtNumeroTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCampos(e);
            
            if(e.KeyChar == 13)
              txtNomeCliente.Focus();
            
            if ((txtNumeroTicket.TextLength > 0) && (e.KeyChar != 8))
                e.Handled = true;
        }

        void validaCampos(KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCampos(e);

            if (e.KeyChar == 13)
                txtCategoria.Focus();
            
            if ((txtNomeCliente.TextLength > 0) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCampos(e);

            if (e.KeyChar == 13)
                txtDataAbertura.Focus();
            
            if ((txtCategoria.TextLength > 0) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void txtDataAbertura_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCampos(e);

            if (e.KeyChar == 13)
                txtDataResolvido.Focus();

            if ((txtDataAbertura.TextLength > 0) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void txtDataResolvido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCampos(e);

            if (e.KeyChar == 13)
                txtTecnico.Focus();

            if ((txtDataResolvido.TextLength > 0) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void txtTecnico_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCampos(e);

            if (e.KeyChar == 13)
                txtCarteira.Focus();

            if ((txtTecnico.TextLength > 0) && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void txtCarteira_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaCampos(e);

            if (e.KeyChar == 13)
                txtNumeroTicket.Focus();

            if ((txtCarteira.TextLength > 0) && (e.KeyChar != 8))
                e.Handled = true;
        }


    }
}

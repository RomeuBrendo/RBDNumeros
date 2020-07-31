using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Infra.Repositories.Transactions;
using RBDNumeros.Viwer;
using System;
using System.Windows.Forms;

namespace RBDNumeros.Viwer.Formulario.Configuracao
{
    public partial class frmConfiguracaoExcel : MetroFramework.Forms.MetroForm
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
            this.StyleManager = metroStyleManager1;
            CarregarTela();

        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidaCampo())
            {
                MessageBox.Show("Verifique os campos!");
                return;
            }

            if (SalvarConfiguração())
            {
                MessageBox.Show("Registro salvo com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao salvar registro!");
            }
        }

        public Boolean ValidaCampo ()
        {
            if (CBNumeroTicket.Text == "" || 
                CBNomeCliente.Text == "" ||  
                CBCategoria.Text == "" ||  
                CBDataAbertura.Text == "" || 
                CBDataResolvido.Text == "" || 
                CBTecnico.Text == "" || 
                CBCarteira.Text == "")
              {
                 return false;
              } 
            else
              {
                 return true;
              }
                   
        }

        public Boolean SalvarConfiguração()
        {
            AdicionarConfiguracaoPlanilhaRequest confRequest = new AdicionarConfiguracaoPlanilhaRequest();

            try
            {
                confRequest.NumeroTicket = char.Parse(CBNumeroTicket.Text);
                confRequest.ClienteNome = char.Parse(CBNomeCliente.Text);
                confRequest.Categoria = char.Parse(CBCategoria.Text);
                confRequest.DataAberturaTicket = char.Parse(CBDataAbertura.Text);
                confRequest.DataResolvido = char.Parse(CBDataResolvido.Text);
                confRequest.Tecnico = char.Parse(CBTecnico.Text);
                confRequest.Carteira = char.Parse(CBCarteira.Text);

                _serviceConfiguracaoPlanilha.Adicionar(confRequest);

                _unitOfWork.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

                return false;

            }


        }

        void CarregarTela()
        {
            var conf = _serviceConfiguracaoPlanilha.CarregarConfiguracao();

            if (conf != null)
            {
                CBNumeroTicket.Text = conf.NumeroTicket.ToString();
                CBNomeCliente.Text = conf.ClienteNome.ToString();
                CBCategoria.Text = conf.Categoria.ToString();
                CBDataAbertura.Text = conf.DataAberturaTicket.ToString();
                CBDataResolvido.Text = conf.DataResolvido.ToString();
                CBTecnico.Text = conf.Tecnico.ToString();
                CBCarteira.Text = conf.Carteira.ToString();

            }
        }

        //private void txtNumeroTicket_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    validaCampos(e);
            
        //    if(e.KeyChar == 13)
        //      txtNomeCliente.Focus();
            
        //    if ((txtNumeroTicket.TextLength > 0) && (e.KeyChar != 8))
        //        e.Handled = true;
        //}

        //void validaCampos(KeyPressEventArgs e)
        //{
        //    if ((Char.IsNumber(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
        //        e.Handled = true;
        //}

        //private void txtNomeCliente_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    validaCampos(e);

        //    if (e.KeyChar == 13)
        //        txtCategoria.Focus();
            
        //    if ((txtNomeCliente.TextLength > 0) && (e.KeyChar != 8))
        //        e.Handled = true;
        //}

        //private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    validaCampos(e);

        //    if (e.KeyChar == 13)
        //        txtDataAbertura.Focus();
            
        //    if ((txtCategoria.TextLength > 0) && (e.KeyChar != 8))
        //        e.Handled = true;
        //}

        //private void txtDataAbertura_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    validaCampos(e);

        //    if (e.KeyChar == 13)
        //        txtDataResolvido.Focus();

        //    if ((txtDataAbertura.TextLength > 0) && (e.KeyChar != 8))
        //        e.Handled = true;
        //}

        //private void txtDataResolvido_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    validaCampos(e);

        //    if (e.KeyChar == 13)
        //        txtTecnico.Focus();

        //    if ((txtDataResolvido.TextLength > 0) && (e.KeyChar != 8))
        //        e.Handled = true;
        //}

        //private void txtTecnico_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    validaCampos(e);

        //    if (e.KeyChar == 13)
        //        txtCarteira.Focus();

        //    if ((txtTecnico.TextLength > 0) && (e.KeyChar != 8))
        //        e.Handled = true;
        //}

        //private void txtCarteira_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    validaCampos(e);

        //    if (e.KeyChar == 13)
        //        txtNumeroTicket.Focus();

        //    if ((txtCarteira.TextLength > 0) && (e.KeyChar != 8))
        //        e.Handled = true;
        //}

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmConfiguracaoExcel_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

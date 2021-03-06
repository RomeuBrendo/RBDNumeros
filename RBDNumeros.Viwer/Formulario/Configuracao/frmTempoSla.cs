﻿using RBDNumeros.Domain.Commands;
using RBDNumeros.Domain.Interfaces.Services;
using RBDNumeros.Infra.Repositories.Transactions;
using RBDNumeros.Viwer.Toast;
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
    public partial class frmTempoSla : MetroFramework.Forms.MetroForm
    {
        private IServiceSla _serviceSla;
        private IUnitOfWork _unitOfWork;
        public frmTempoSla()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            ConsultarDepedencias();
            CarregarTela();
        }

        void ConsultarDepedencias()
        {
            _serviceSla = (IServiceSla)Program.ServiceProvider.GetService(typeof(IServiceSla));
            _unitOfWork = (IUnitOfWork)Program.ServiceProvider.GetService(typeof(IUnitOfWork));


        }

        void CarregarTela()
        {
            var sla = _serviceSla.ObterRegistro();

            txtDentroSla.Text = sla.Dentro.ToString();
            txtAcima20.Text = sla.Acima20.ToString();
            txtEstourado.Text = sla.Estourado.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDentroSla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtAcima20.Focus();
        }

        private void txtAcima20_Click(object sender, EventArgs e)
        {
            
        }

        private void txtAcima20_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtEstourado.Focus();
        }

        private void txtEstourado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSalvar.PerformClick();


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var request = new AdicionarAlterarSlaRequest();
            try
            {
                request.Dentro = TimeSpan.Parse(txtDentroSla.Text);
                request.Acima20 = TimeSpan.Parse(txtAcima20.Text);
                request.Estourado =TimeSpan.Parse(txtEstourado.Text);
            }
            catch (Exception)
            {
                frmToast taoastErro = new frmToast("Verifique Formatação dos campos", "Erro");
                taoastErro.Show();
                this.Focus();
                return;
            }


            _serviceSla.InserirAlterar(request);
            _unitOfWork.SaveChanges();
            frmToast toast = new frmToast("Salvo com Sucesso!!", "Okay");
            toast.Show();
            this.Close();

        }


        private void frmTempoSla_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.KeyCode == Keys.F4)
                btnSalvar.PerformClick();
        }
    }
}

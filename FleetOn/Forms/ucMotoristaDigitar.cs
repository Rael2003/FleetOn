using FleetOn.Controllers;
using FleetOn.Models;
using FleetOn.Repositories;
using FleetOn.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleetOn.Forms
{
    public partial class ucMotoristaDigitar : UserControl
    {
        Form1 forms;
        private MotoristaController _controller;
        int id = 0;
        public ucMotoristaDigitar(Form1 form)
        {
            // Inicialização das camadas
            var repo = new MotoristaRepository();
            var service = new MotoristaService(repo);
            _controller = new MotoristaController(service);

            InitializeComponent();
            forms = form;
        }
        public ucMotoristaDigitar(Form1 form, int id)
        {
            // Inicialização das camadas
            var repo = new MotoristaRepository();
            var service = new MotoristaService(repo);
            _controller = new MotoristaController(service);

            InitializeComponent();
            forms = form;
            this.id = id;
            carregarDados();
        }

        private void carregarDados()
        {
            Motorista Motoristas = _controller.BuscarMotorista(this.id);

            txtCNH.Text = Motoristas.Cnh.ToString();
            txtNome.Text = Motoristas.Nome.ToString();
            txtCategoria.Text = Motoristas.Categoria_cnh.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Motorista m = new Motorista(this.id,txtNome.Text,txtCNH.Text, txtCategoria.Text);

            if (this.id.Equals(0))
            {
                _controller.AdicionarMotorista(m);
            }
            else
            {
                _controller.AtualizaMotorista(this.id, m);
            }
                
            this.forms.AbrirUserControl(new ucMotorista(this.forms));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.forms.AbrirUserControl(new ucMotorista(this.forms));
        }

        private void txtCNH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

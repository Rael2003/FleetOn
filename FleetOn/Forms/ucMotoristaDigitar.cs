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
        public ucMotoristaDigitar(Form1 form)
        {
            // Inicialização das camadas
            var repo = new MotoristaRepository();
            var service = new MotoristaService(repo);
            _controller = new MotoristaController(service);

            InitializeComponent();
            forms = form;
        }
        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Motorista m = new Motorista(txtNome.Text,txtCNH.Text, txtCategoria.Text);

            _controller.AdicionarMotorista(m);
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

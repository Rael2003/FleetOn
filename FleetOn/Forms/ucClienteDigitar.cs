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
    public partial class ucClienteDigitar : UserControl
    {
        Form1 forms;
        private ClienteController _controller;
        public ucClienteDigitar(Form1 form)
        {
            // Inicialização das camadas
            var repo = new ClienteRepository();
            var service = new ClienteService(repo);
            _controller = new ClienteController(service);

            InitializeComponent();
            forms = form;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Cliente m = new Cliente(0,txtNome.Text, txtCNH.Text, true);

            _controller.AdicionarCliente(m);
            this.forms.AbrirUserControl(new ucCliente(this.forms));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.forms.AbrirUserControl(new ucCliente(this.forms));
        }
    }
}

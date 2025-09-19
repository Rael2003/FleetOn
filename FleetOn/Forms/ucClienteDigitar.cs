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
        int id = 0;
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

        public ucClienteDigitar(Form1 form, int id)
        {
            // Inicialização das camadas
            var repo = new ClienteRepository();
            var service = new ClienteService(repo);
            _controller = new ClienteController(service);

            InitializeComponent();
            forms = form;
            this.id = id;
            carregarDados();
        }

        private void carregarDados()
        {
            Cliente Clientes = _controller.BuscarCliente(this.id);

            txtCNH.Text = Clientes.Doc.ToString();
            txtNome.Text = Clientes.Nome.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Cliente m = new Cliente(this.id,txtNome.Text, txtCNH.Text, true);

            if (this.id.Equals(0))
            {
                _controller.AdicionarCliente(m);
            }
            else
            {
                _controller.AtualizaCliente(this.id, m);
            }
                this.forms.AbrirUserControl(new ucCliente(this.forms));

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.forms.AbrirUserControl(new ucCliente(this.forms));
        }
    }
}

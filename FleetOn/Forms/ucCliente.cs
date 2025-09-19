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
    public partial class ucCliente : UserControl
    {
        private Form1 forms;
        private ClienteController _controller;
        public ucCliente(Form1 form)
        {
            forms = form;
            InitializeComponent();

            // Inicialização das camadas
            var repo = new ClienteRepository();
            var service = new ClienteService(repo);
            _controller = new ClienteController(service);

            carregarDados();
        }

        private void carregarDados()
        {
            IEnumerable<Cliente> Clientes = _controller.ConsultarClientes();

            tbCliente.Rows.Clear();
            foreach (Cliente item in Clientes)
            {
                tbCliente.Rows.Add(item.Id,item.Nome);
            }
        }

        private void deletar()
        {
            //Console.WriteLine(tbCliente.CurrentRow.Cells[0].Value);
            _controller.DeletaCliente((int)tbCliente.CurrentRow.Cells[0].Value);
        }

        private void atualizar()
        {
            this.forms.AbrirUserControl(new ucClienteDigitar(this.forms, (int)tbCliente.CurrentRow.Cells[0].Value));
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.forms.AbrirUserControl(new ucClienteDigitar(this.forms));
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletar();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atualizar();
        }
    }
}

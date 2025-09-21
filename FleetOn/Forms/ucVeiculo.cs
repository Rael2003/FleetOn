using FleetOn.Controllers;
using FleetOn.Interfaces;
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
    public partial class ucVeiculo : UserControl
    {
        Form1 forms;
        VeiculoController _controller;
        public ucVeiculo(Form1 form)
        {
            InitializeComponent();
            forms = form;

            // Inicialização das camadas
            var repo = new VeiculoRepository();
            var service = new VeiculoService(repo);
            _controller = new VeiculoController(service);

            carregarDados();
        }

        public void carregarDados()
        {
            IEnumerable<Veiculo> veiculos = _controller.ConsultarVeiculos();

            tbVeiculo.Rows.Clear();
            foreach (Veiculo item in veiculos)
            {
                tbVeiculo.Rows.Add(item.Id, item.NomeVeiculo, item.Placa);
            }
        }

        private void deletar()
        {
            //Console.WriteLine(tbCliente.CurrentRow.Cells[0].Value);
            _controller.DeletaVeiculo((int)tbVeiculo.CurrentRow.Cells[0].Value);
        }

        private void atualizar()
        {
            this.forms.AbrirUserControl(new ucVeiculoDigitar(this.forms, (int)tbVeiculo.CurrentRow.Cells[0].Value));
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            forms.AbrirUserControl(new ucVeiculoDigitar(forms));
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            atualizar();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deletar();
        }
    }
}

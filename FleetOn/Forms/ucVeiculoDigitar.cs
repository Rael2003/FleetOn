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
    public partial class ucVeiculoDigitar : UserControl
    {
        Form1 forms;
        VeiculoController _controller;
        public ucVeiculoDigitar(Form1 form)
        {
            InitializeComponent();
            forms = form;

            // Inicialização das camadas
            var repo = new VeiculoRepository();
            var service = new VeiculoService(repo);
            _controller = new VeiculoController(service);
        }

        private void ucVeiculoDigitar_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Veiculo v = new Veiculo(0, txtVeiculo.Text, txtPlaca.Text, true);
            _controller.AdicionarVeiculo(v);
            forms.AbrirUserControl(new ucVeiculo(forms));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            forms.AbrirUserControl(new ucVeiculo(forms));
        }
    }
}

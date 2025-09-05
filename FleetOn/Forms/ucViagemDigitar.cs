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
    public partial class ucViagemDigitar : UserControl
    {
        Form1 forms;
        ViagemController _controller;
        ClienteController _cliente;
        MotoristaController _motorista;
        public ucViagemDigitar(Form1 form)
        {
            InitializeComponent();
            this.forms = form;

            // Inicialização das camadas
            var repo = new ViagemRepository();
            var service = new ViagemService(repo);
            _controller = new ViagemController(service);

            // Inicialização das camadas
            var repoCli = new ClienteRepository();
            var serviceCli = new ClienteService(repoCli);
            _cliente = new ClienteController(serviceCli);

            // Inicialização das camadas
            var repoMot = new MotoristaRepository();
            var serviceMot = new MotoristaService(repoMot);
            _motorista = new MotoristaController(serviceMot);

        }

        private void ucViagemDigitar_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Viagem v = new Viagem(0, _cliente.BuscarCliente(int.Parse(txtCliente.Text)), _motorista.BuscarMotorista(int.Parse(txtMotorista.Text)),dtpData.Value, true);
            _controller.AdicionarViagem(v);
            forms.AbrirUserControl(new ucViagem(forms));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            forms.AbrirUserControl(new ucViagem(forms));
        }
    }
}

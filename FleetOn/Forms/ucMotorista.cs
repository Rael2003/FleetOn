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
    public partial class ucMotorista : UserControl
    {
        private Form1 forms;
        private MotoristaController _controller;
        public ucMotorista(Form1 form)
        {
            forms = form;
            InitializeComponent();

            // Inicialização das camadas
            var repo = new MotoristaRepository();
            var service = new MotoristaService(repo);
            _controller = new MotoristaController(service);

            carregarDados();
        }

        private void carregarDados()
        {
            IEnumerable<Motorista> motoristas = _controller.ConsultarMotoristas();

            tbMotorista.Rows.Clear();
            foreach (Motorista item in motoristas)
            {
                tbMotorista.Rows.Add(item.Nome);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.forms.AbrirUserControl(new ucMotoristaDigitar(this.forms));
        }

        private void ucMotorista_Load(object sender, EventArgs e)
        {

        }
    }
}

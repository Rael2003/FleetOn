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
    public partial class ucViagem : UserControl
    {
        private Form1 forms;
        ViagemController _controller;
        public ucViagem(Form1 forms)
        {
            InitializeComponent();
            this.forms = forms;

            // Inicialização das camadas
            var repo = new ViagemRepository();
            var service = new ViagemService(repo);
            _controller = new ViagemController(service);

            carregarDados();
        }

        public void carregarDados()
        {
            IEnumerable<Viagem> Viagens = _controller.ConsultarViagems();

            tbViagem.Rows.Clear();
            foreach (Viagem item in Viagens)
            {
                tbViagem.Rows.Add(item.cliente.Nome, item.motorista.Nome,item.date);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            this.forms.AbrirUserControl(new ucViagemDigitar(this.forms));
        }
    }
}

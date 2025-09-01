using FleetOn.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleetOn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AbrirUserControl(UserControl uc)
        {
            // Limpa o painel principal antes de abrir outro
            pnlPrincipal.Controls.Clear();

            // Ajusta o tamanho do UserControl para ocupar o painel
            uc.Dock = DockStyle.Fill;

            // Adiciona o UserControl no painel principal
            pnlPrincipal.Controls.Add(uc);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucMotorista(this));
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucVeiculo(this));
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucCliente(this));
        }

        private void btnViagem_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucViagem());
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucFinanceiro());
        }
    }
}

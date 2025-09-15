using FleetOn.Controllers;
using FleetOn.DTOs;
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
    public partial class ucFinanceiro : UserControl
    {
        private Form1 forms;
        private FinanceiroController _controller;
        public ucFinanceiro(Form1 form)
        {
            InitializeComponent();
            forms = form;

            // Inicialização das camadas
            var repo = new FinanceiroRepository();
            var service = new FinanceiroService(repo);
            _controller = new FinanceiroController(service);

            carregarDados();
        }

        public void carregarDados()
        {
            IEnumerable<FinanceiroDTO> Financeiros = _controller.ConsultarFinanceiro();

            float valor = 0;
            float gasto = 0;
            tbFinanceiro.Rows.Clear();
            foreach (FinanceiroDTO item in Financeiros)
            {
                tbFinanceiro.Rows.Add(item.data_lancamento,item.id_financeiro,item.valor,0,item.valor-0);
                valor = valor + item.valor;
                gasto = gasto + 0;
            }
            lblRecebido.Text = valor.ToString();
            lblGasto.Text = gasto.ToString();
            lblTotal.Text = (valor - gasto).ToString();
        }
    }
}

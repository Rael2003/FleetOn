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
    public partial class ucMotoristaDigitar : UserControl
    {
        Form1 forms;
        public ucMotoristaDigitar(Form1 form)
        {
            InitializeComponent();
            forms = form;
        }
        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.forms.AbrirUserControl(new ucMotorista(this.forms));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.forms.AbrirUserControl(new ucMotorista(this.forms));
        }
    }
}

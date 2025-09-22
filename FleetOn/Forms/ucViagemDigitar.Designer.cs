namespace FleetOn.Forms
{
    partial class ucViagemDigitar
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMotorista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtMotorista
            // 
            this.txtMotorista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMotorista.Location = new System.Drawing.Point(297, 122);
            this.txtMotorista.MaximumSize = new System.Drawing.Size(100, 20);
            this.txtMotorista.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtMotorista.Name = "txtMotorista";
            this.txtMotorista.Size = new System.Drawing.Size(100, 20);
            this.txtMotorista.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Motorista";
            // 
            // txtCliente
            // 
            this.txtCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCliente.Location = new System.Drawing.Point(297, 96);
            this.txtCliente.MaximumSize = new System.Drawing.Size(100, 20);
            this.txtCliente.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(355, 344);
            this.btnCancelar.MaximumSize = new System.Drawing.Size(75, 23);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.Location = new System.Drawing.Point(241, 344);
            this.btnConfirmar.MaximumSize = new System.Drawing.Size(75, 23);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpData.Location = new System.Drawing.Point(297, 154);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 13;
            // 
            // ucViagemDigitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMotorista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "ucViagemDigitar";
            this.Size = new System.Drawing.Size(681, 381);
            this.Load += new System.EventHandler(this.ucViagemDigitar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMotorista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpData;
    }
}

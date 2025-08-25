namespace FleetOn
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cadastros = new System.Windows.Forms.Label();
            this.btnViagem = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnVeiculo = new System.Windows.Forms.Button();
            this.btnMotorista = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnFinanceiro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Cadastros);
            this.panel1.Controls.Add(this.btnViagem);
            this.panel1.Controls.Add(this.btnCliente);
            this.panel1.Controls.Add(this.btnVeiculo);
            this.panel1.Controls.Add(this.btnMotorista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Location = new System.Drawing.Point(49, 233);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(75, 23);
            this.btnFinanceiro.TabIndex = 6;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            this.btnFinanceiro.Click += new System.EventHandler(this.btnFinanceiro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gerenciamento";
            // 
            // Cadastros
            // 
            this.Cadastros.AutoSize = true;
            this.Cadastros.Location = new System.Drawing.Point(59, 38);
            this.Cadastros.Name = "Cadastros";
            this.Cadastros.Size = new System.Drawing.Size(54, 13);
            this.Cadastros.TabIndex = 4;
            this.Cadastros.Text = "Cadastros";
            // 
            // btnViagem
            // 
            this.btnViagem.Location = new System.Drawing.Point(49, 204);
            this.btnViagem.Name = "btnViagem";
            this.btnViagem.Size = new System.Drawing.Size(75, 23);
            this.btnViagem.TabIndex = 3;
            this.btnViagem.Text = "Viagens";
            this.btnViagem.UseVisualStyleBackColor = true;
            this.btnViagem.Click += new System.EventHandler(this.btnViagem_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(49, 112);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnVeiculo
            // 
            this.btnVeiculo.Location = new System.Drawing.Point(49, 83);
            this.btnVeiculo.Name = "btnVeiculo";
            this.btnVeiculo.Size = new System.Drawing.Size(75, 23);
            this.btnVeiculo.TabIndex = 1;
            this.btnVeiculo.Text = "Veículos";
            this.btnVeiculo.UseVisualStyleBackColor = true;
            this.btnVeiculo.Click += new System.EventHandler(this.btnVeiculo_Click);
            // 
            // btnMotorista
            // 
            this.btnMotorista.Location = new System.Drawing.Point(49, 54);
            this.btnMotorista.Name = "btnMotorista";
            this.btnMotorista.Size = new System.Drawing.Size(75, 23);
            this.btnMotorista.TabIndex = 0;
            this.btnMotorista.Text = "Motoristas";
            this.btnMotorista.UseVisualStyleBackColor = true;
            this.btnMotorista.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(183, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(617, 450);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Cadastros;
        private System.Windows.Forms.Button btnViagem;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnVeiculo;
        private System.Windows.Forms.Button btnMotorista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Panel pnlPrincipal;
    }
}


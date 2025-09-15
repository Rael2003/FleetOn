namespace FleetOn.Forms
{
    partial class ucFinanceiro
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbFinanceiro = new System.Windows.Forms.DataGridView();
            this.cData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cViagens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValorRecebido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValorGasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRecebido = new System.Windows.Forms.Label();
            this.lblGasto = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbFinanceiro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Financeiro";
            // 
            // tbFinanceiro
            // 
            this.tbFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbFinanceiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cData,
            this.cViagens,
            this.cValorRecebido,
            this.cValorGasto,
            this.cTotal});
            this.tbFinanceiro.Location = new System.Drawing.Point(3, 58);
            this.tbFinanceiro.Name = "tbFinanceiro";
            this.tbFinanceiro.Size = new System.Drawing.Size(658, 279);
            this.tbFinanceiro.TabIndex = 1;
            // 
            // cData
            // 
            this.cData.HeaderText = "Data";
            this.cData.Name = "cData";
            // 
            // cViagens
            // 
            this.cViagens.HeaderText = "Q. Viagens";
            this.cViagens.Name = "cViagens";
            // 
            // cValorRecebido
            // 
            this.cValorRecebido.HeaderText = "Valor recebido";
            this.cValorRecebido.Name = "cValorRecebido";
            // 
            // cValorGasto
            // 
            this.cValorGasto.HeaderText = "Valor Gasto";
            this.cValorGasto.Name = "cValorGasto";
            // 
            // cTotal
            // 
            this.cTotal.HeaderText = "Total";
            this.cTotal.Name = "cTotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor recebido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor gasto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total:";
            // 
            // lblRecebido
            // 
            this.lblRecebido.AutoSize = true;
            this.lblRecebido.Location = new System.Drawing.Point(108, 340);
            this.lblRecebido.Name = "lblRecebido";
            this.lblRecebido.Size = new System.Drawing.Size(13, 13);
            this.lblRecebido.TabIndex = 5;
            this.lblRecebido.Text = "0";
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Location = new System.Drawing.Point(353, 340);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(13, 13);
            this.lblGasto.TabIndex = 6;
            this.lblGasto.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(595, 340);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "0";
            // 
            // ucFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblGasto);
            this.Controls.Add(this.lblRecebido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFinanceiro);
            this.Controls.Add(this.label1);
            this.Name = "ucFinanceiro";
            this.Size = new System.Drawing.Size(664, 385);
            ((System.ComponentModel.ISupportInitialize)(this.tbFinanceiro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tbFinanceiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cData;
        private System.Windows.Forms.DataGridViewTextBoxColumn cViagens;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValorRecebido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValorGasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecebido;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.Label lblTotal;
    }
}

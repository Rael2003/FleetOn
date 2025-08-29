namespace FleetOn.Forms
{
    partial class ucVeiculo
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
            this.tbVeiculo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbVeiculo
            // 
            this.tbVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbVeiculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cVeiculo,
            this.cPlaca});
            this.tbVeiculo.Location = new System.Drawing.Point(0, 47);
            this.tbVeiculo.Name = "tbVeiculo";
            this.tbVeiculo.Size = new System.Drawing.Size(522, 302);
            this.tbVeiculo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veículos";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(430, 14);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cVeiculo
            // 
            this.cVeiculo.HeaderText = "Veículo";
            this.cVeiculo.Name = "cVeiculo";
            this.cVeiculo.ReadOnly = true;
            // 
            // cPlaca
            // 
            this.cPlaca.HeaderText = "Placa";
            this.cPlaca.Name = "cPlaca";
            this.cPlaca.ReadOnly = true;
            // 
            // ucVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbVeiculo);
            this.Name = "ucVeiculo";
            this.Size = new System.Drawing.Size(523, 350);
            ((System.ComponentModel.ISupportInitialize)(this.tbVeiculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPlaca;
    }
}

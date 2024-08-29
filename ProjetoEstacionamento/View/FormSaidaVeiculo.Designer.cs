namespace ProjetoEstacionamento
{
    partial class FormSaidaVeiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvVeiculos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Cor = new DataGridViewTextBoxColumn();
            Placa = new DataGridViewTextBoxColumn();
            HoraEntrada = new DataGridViewTextBoxColumn();
            HoraSaida = new DataGridViewTextBoxColumn();
            btnFechar = new Button();
            txtPlaca = new TextBox();
            lblPlaca = new Label();
            txtCor = new TextBox();
            lblCor = new Label();
            txtModelo = new TextBox();
            lblModelo = new Label();
            txtId = new TextBox();
            lblId = new Label();
            txtEntrada = new TextBox();
            lblEntrada = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).BeginInit();
            SuspendLayout();
            // 
            // dgvVeiculos
            // 
            dgvVeiculos.AllowUserToAddRows = false;
            dgvVeiculos.AllowUserToDeleteRows = false;
            dgvVeiculos.AllowUserToResizeRows = false;
            dgvVeiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeiculos.Columns.AddRange(new DataGridViewColumn[] { Id, Modelo, Cor, Placa, HoraEntrada, HoraSaida });
            dgvVeiculos.Location = new Point(12, 38);
            dgvVeiculos.MultiSelect = false;
            dgvVeiculos.Name = "dgvVeiculos";
            dgvVeiculos.ReadOnly = true;
            dgvVeiculos.RowHeadersVisible = false;
            dgvVeiculos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeiculos.Size = new Size(355, 262);
            dgvVeiculos.TabIndex = 0;
            dgvVeiculos.CellClick += dgvVeiculos_CellClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 42;
            // 
            // Modelo
            // 
            Modelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            Modelo.Width = 73;
            // 
            // Cor
            // 
            Cor.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Cor.HeaderText = "Cor";
            Cor.Name = "Cor";
            Cor.ReadOnly = true;
            Cor.Width = 51;
            // 
            // Placa
            // 
            Placa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Placa.HeaderText = "Placa";
            Placa.Name = "Placa";
            Placa.ReadOnly = true;
            Placa.Width = 60;
            // 
            // HoraEntrada
            // 
            HoraEntrada.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            HoraEntrada.HeaderText = "Hora de Entrada";
            HoraEntrada.Name = "HoraEntrada";
            HoraEntrada.ReadOnly = true;
            HoraEntrada.Width = 107;
            // 
            // HoraSaida
            // 
            HoraSaida.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            HoraSaida.HeaderText = "Hora de Saída";
            HoraSaida.Name = "HoraSaida";
            HoraSaida.ReadOnly = true;
            HoraSaida.Width = 97;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Arial", 20F);
            btnFechar.Location = new Point(716, 284);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(110, 42);
            btnFechar.TabIndex = 15;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtPlaca
            // 
            txtPlaca.Font = new Font("Arial", 20F);
            txtPlaca.Location = new Point(501, 196);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.ReadOnly = true;
            txtPlaca.Size = new Size(325, 38);
            txtPlaca.TabIndex = 14;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Arial", 20F);
            lblPlaca.Location = new Point(392, 196);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(81, 32);
            lblPlaca.TabIndex = 13;
            lblPlaca.Text = "Placa";
            // 
            // txtCor
            // 
            txtCor.Font = new Font("Arial", 20F);
            txtCor.Location = new Point(501, 152);
            txtCor.Name = "txtCor";
            txtCor.ReadOnly = true;
            txtCor.Size = new Size(325, 38);
            txtCor.TabIndex = 12;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Font = new Font("Arial", 20F);
            lblCor.Location = new Point(392, 152);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(58, 32);
            lblCor.TabIndex = 11;
            lblCor.Text = "Cor";
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Arial", 20F);
            txtModelo.Location = new Point(501, 105);
            txtModelo.Name = "txtModelo";
            txtModelo.ReadOnly = true;
            txtModelo.Size = new Size(325, 38);
            txtModelo.TabIndex = 10;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Arial", 20F);
            lblModelo.Location = new Point(392, 111);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(103, 32);
            lblModelo.TabIndex = 9;
            lblModelo.Text = "Modelo";
            // 
            // txtId
            // 
            txtId.Font = new Font("Arial", 20F);
            txtId.Location = new Point(501, 61);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(325, 38);
            txtId.TabIndex = 17;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Arial", 20F);
            lblId.Location = new Point(392, 67);
            lblId.Name = "lblId";
            lblId.Size = new Size(37, 32);
            lblId.TabIndex = 16;
            lblId.Text = "Id";
            // 
            // txtEntrada
            // 
            txtEntrada.Font = new Font("Arial", 20F);
            txtEntrada.Location = new Point(501, 240);
            txtEntrada.Name = "txtEntrada";
            txtEntrada.ReadOnly = true;
            txtEntrada.Size = new Size(325, 38);
            txtEntrada.TabIndex = 19;
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Font = new Font("Arial", 20F);
            lblEntrada.Location = new Point(392, 243);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(109, 32);
            lblEntrada.TabIndex = 18;
            lblEntrada.Text = "Entrada";
            // 
            // FormSaidaVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 360);
            ControlBox = false;
            Controls.Add(txtEntrada);
            Controls.Add(lblEntrada);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(btnFechar);
            Controls.Add(txtPlaca);
            Controls.Add(lblPlaca);
            Controls.Add(txtCor);
            Controls.Add(lblCor);
            Controls.Add(txtModelo);
            Controls.Add(lblModelo);
            Controls.Add(dgvVeiculos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSaidaVeiculo";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvVeiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVeiculos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Cor;
        private DataGridViewTextBoxColumn Placa;
        private DataGridViewTextBoxColumn HoraEntrada;
        private DataGridViewTextBoxColumn HoraSaida;
        private Button btnFechar;
        private TextBox txtPlaca;
        private Label lblPlaca;
        private TextBox txtCor;
        private Label lblCor;
        private TextBox txtModelo;
        private Label lblModelo;
        private TextBox txtId;
        private Label lblId;
        private TextBox txtEntrada;
        private Label lblEntrada;
    }
}
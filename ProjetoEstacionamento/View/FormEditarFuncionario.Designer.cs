namespace ProjetoEstacionamento
{
    partial class FormEditarFuncionario
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
            lblId = new Label();
            lblNome = new Label();
            lblCargo = new Label();
            lblUsuario = new Label();
            lblSenha = new Label();
            txtNome = new TextBox();
            txtCargo = new TextBox();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            btnSalvar = new Button();
            dgvFuncionario = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Usuário = new DataGridViewTextBoxColumn();
            Senha = new DataGridViewTextBoxColumn();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Arial", 20F);
            lblId.Location = new Point(356, 44);
            lblId.Name = "lblId";
            lblId.Size = new Size(45, 32);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 20F);
            lblNome.Location = new Point(311, 87);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(93, 32);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Arial", 20F);
            lblCargo.Location = new Point(305, 131);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(96, 32);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Cargo:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial", 20F);
            lblUsuario.Location = new Point(286, 175);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(115, 32);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial", 20F);
            lblSenha.Location = new Point(301, 219);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(100, 32);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 20F);
            txtNome.Location = new Point(410, 81);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(223, 38);
            txtNome.TabIndex = 6;
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Arial", 20F);
            txtCargo.Location = new Point(410, 125);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(223, 38);
            txtCargo.TabIndex = 7;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial", 20F);
            txtUsuario.Location = new Point(410, 169);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(223, 38);
            txtUsuario.TabIndex = 8;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Arial", 20F);
            txtSenha.Location = new Point(410, 213);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(223, 38);
            txtSenha.TabIndex = 9;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Arial", 20F);
            btnSalvar.Location = new Point(523, 257);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(110, 46);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvFuncionario
            // 
            dgvFuncionario.AllowUserToAddRows = false;
            dgvFuncionario.AllowUserToDeleteRows = false;
            dgvFuncionario.AllowUserToResizeRows = false;
            dgvFuncionario.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgvFuncionario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionario.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Cargo, Usuário, Senha });
            dgvFuncionario.Location = new Point(12, 38);
            dgvFuncionario.MultiSelect = false;
            dgvFuncionario.Name = "dgvFuncionario";
            dgvFuncionario.ReadOnly = true;
            dgvFuncionario.RowHeadersVisible = false;
            dgvFuncionario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFuncionario.Size = new Size(268, 265);
            dgvFuncionario.TabIndex = 11;
            dgvFuncionario.CellClick += dgvFuncionario_CellClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 42;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 65;
            // 
            // Cargo
            // 
            Cargo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            Cargo.ReadOnly = true;
            Cargo.Width = 64;
            // 
            // Usuário
            // 
            Usuário.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Usuário.HeaderText = "Usuário";
            Usuário.Name = "Usuário";
            Usuário.ReadOnly = true;
            Usuário.Width = 72;
            // 
            // Senha
            // 
            Senha.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Senha.HeaderText = "Senha";
            Senha.Name = "Senha";
            Senha.ReadOnly = true;
            Senha.Width = 64;
            // 
            // txtId
            // 
            txtId.Font = new Font("Arial", 20F);
            txtId.Location = new Point(410, 38);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(223, 38);
            txtId.TabIndex = 12;
            // 
            // FormEditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 336);
            ControlBox = false;
            Controls.Add(txtId);
            Controls.Add(dgvFuncionario);
            Controls.Add(btnSalvar);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(txtCargo);
            Controls.Add(txtNome);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(lblCargo);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Name = "FormEditarFuncionario";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNome;
        private Label lblCargo;
        private Label lblUsuario;
        private Label lblSenha;
        private TextBox txtNome;
        private TextBox txtCargo;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Button btnSalvar;
        private DataGridView dgvFuncionario;
        private TextBox txtId;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Usuário;
        private DataGridViewTextBoxColumn Senha;
    }
}
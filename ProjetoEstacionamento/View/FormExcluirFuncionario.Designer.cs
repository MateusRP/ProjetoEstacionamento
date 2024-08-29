namespace ProjetoEstacionamento
{
    partial class FormExcluirFuncionario
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
            lblFuncionario = new Label();
            lblNome = new Label();
            lblCargo = new Label();
            lblUsuario = new Label();
            lblSenha = new Label();
            cmbListaFunc = new ComboBox();
            btnExcluir = new Button();
            SuspendLayout();
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Font = new Font("Arial", 20F);
            lblFuncionario.Location = new Point(32, 31);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(164, 32);
            lblFuncionario.TabIndex = 0;
            lblFuncionario.Text = "Funcionário:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 20F);
            lblNome.Location = new Point(32, 63);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(93, 32);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Arial", 20F);
            lblCargo.Location = new Point(32, 95);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(96, 32);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Cargo:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial", 20F);
            lblUsuario.Location = new Point(32, 127);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(107, 32);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial", 20F);
            lblSenha.Location = new Point(32, 159);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(100, 32);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // cmbListaFunc
            // 
            cmbListaFunc.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbListaFunc.Font = new Font("Arial", 20F);
            cmbListaFunc.FormattingEnabled = true;
            cmbListaFunc.Location = new Point(202, 23);
            cmbListaFunc.Name = "cmbListaFunc";
            cmbListaFunc.Size = new Size(211, 40);
            cmbListaFunc.TabIndex = 5;
            cmbListaFunc.SelectedIndexChanged += cmbListaFunc_SelectedIndexChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Arial", 20F);
            btnExcluir.Location = new Point(291, 200);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(122, 49);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormExcluirFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 278);
            ControlBox = false;
            Controls.Add(btnExcluir);
            Controls.Add(cmbListaFunc);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(lblCargo);
            Controls.Add(lblNome);
            Controls.Add(lblFuncionario);
            Name = "FormExcluirFuncionario";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFuncionario;
        private Label lblNome;
        private Label lblCargo;
        private Label lblUsuario;
        private Label lblSenha;
        private ComboBox cmbListaFunc;
        private Button btnExcluir;
    }
}
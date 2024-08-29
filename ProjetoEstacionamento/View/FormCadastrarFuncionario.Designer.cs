namespace ProjetoEstacionamento
{
    partial class FormCadastrarFuncionario
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
            lblNome = new Label();
            txtNome = new TextBox();
            txtCargo = new TextBox();
            lblCargo = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            txtSenha = new TextBox();
            lblSenha = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 20F);
            lblNome.Location = new Point(40, 39);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(93, 32);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial", 20F);
            txtNome.Location = new Point(139, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(315, 38);
            txtNome.TabIndex = 1;
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Arial", 20F);
            txtCargo.Location = new Point(139, 83);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(315, 38);
            txtCargo.TabIndex = 3;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Arial", 20F);
            lblCargo.Location = new Point(37, 83);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(96, 32);
            lblCargo.TabIndex = 2;
            lblCargo.Text = "Cargo:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial", 20F);
            txtUsuario.Location = new Point(139, 127);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(315, 38);
            txtUsuario.TabIndex = 5;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial", 20F);
            lblUsuario.Location = new Point(18, 127);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(115, 32);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuário:";
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Arial", 20F);
            txtSenha.Location = new Point(139, 171);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(315, 38);
            txtSenha.TabIndex = 7;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial", 20F);
            lblSenha.Location = new Point(33, 171);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(100, 32);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha:";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Arial", 20F);
            btnSalvar.Location = new Point(348, 215);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(106, 46);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCadastrarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 288);
            ControlBox = false;
            Controls.Add(btnSalvar);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(txtCargo);
            Controls.Add(lblCargo);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Name = "FormCadastrarFuncionario";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private TextBox txtNome;
        private TextBox txtCargo;
        private Label lblCargo;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private TextBox txtSenha;
        private Label lblSenha;
        private Button btnSalvar;
    }
}
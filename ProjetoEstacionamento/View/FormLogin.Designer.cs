namespace ProjetoEstacionamento
{
    partial class FormLogin
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
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial", 20F);
            lblUsuario.Location = new Point(98, 53);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(115, 32);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial", 20F);
            txtUsuario.Location = new Point(219, 47);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(216, 38);
            txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Arial", 20F);
            txtSenha.Location = new Point(219, 91);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(216, 38);
            txtSenha.TabIndex = 3;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial", 20F);
            lblSenha.Location = new Point(113, 97);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(100, 32);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha:";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 20F);
            button1.Location = new Point(337, 135);
            button1.Name = "button1";
            button1.Size = new Size(98, 48);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 262);
            ControlBox = false;
            Controls.Add(button1);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Name = "FormLogin";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label lblSenha;
        private Button button1;
    }
}
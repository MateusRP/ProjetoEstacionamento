namespace ProjetoEstacionamento
{
    partial class FormEntradaVeiculo
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
            txtModelo = new TextBox();
            lblModelo = new Label();
            txtCor = new TextBox();
            lblCor = new Label();
            txtPlaca = new TextBox();
            lblPlaca = new Label();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtModelo
            // 
            txtModelo.Font = new Font("Arial", 20F);
            txtModelo.Location = new Point(127, 47);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(204, 38);
            txtModelo.TabIndex = 3;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Arial", 20F);
            lblModelo.Location = new Point(18, 53);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(103, 32);
            lblModelo.TabIndex = 2;
            lblModelo.Text = "Modelo";
            // 
            // txtCor
            // 
            txtCor.Font = new Font("Arial", 20F);
            txtCor.Location = new Point(127, 94);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(204, 38);
            txtCor.TabIndex = 5;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Font = new Font("Arial", 20F);
            lblCor.Location = new Point(18, 94);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(58, 32);
            lblCor.TabIndex = 4;
            lblCor.Text = "Cor";
            // 
            // txtPlaca
            // 
            txtPlaca.Font = new Font("Arial", 20F);
            txtPlaca.Location = new Point(127, 138);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(204, 38);
            txtPlaca.TabIndex = 7;
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Font = new Font("Arial", 20F);
            lblPlaca.Location = new Point(18, 138);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(81, 32);
            lblPlaca.TabIndex = 6;
            lblPlaca.Text = "Placa";
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Arial", 20F);
            btnSalvar.Location = new Point(233, 182);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(98, 42);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormEntradaVeiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 314);
            ControlBox = false;
            Controls.Add(btnSalvar);
            Controls.Add(txtPlaca);
            Controls.Add(lblPlaca);
            Controls.Add(txtCor);
            Controls.Add(lblCor);
            Controls.Add(txtModelo);
            Controls.Add(lblModelo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEntradaVeiculo";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtModelo;
        private Label lblModelo;
        private TextBox txtCor;
        private Label lblCor;
        private TextBox txtPlaca;
        private Label lblPlaca;
        private Button btnSalvar;
    }
}
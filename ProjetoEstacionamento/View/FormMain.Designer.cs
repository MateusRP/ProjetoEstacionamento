namespace ProjetoEstacionamento
{
    partial class formMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuAplicacao = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem1 = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            veículoToolStripMenuItem = new ToolStripMenuItem();
            registrarEntradaToolStripMenuItem = new ToolStripMenuItem();
            registrarSaídaToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            excluirToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            gerarRelatórioToolStripMenuItem = new ToolStripMenuItem();
            menuAplicacao.SuspendLayout();
            SuspendLayout();
            // 
            // menuAplicacao
            // 
            menuAplicacao.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, veículoToolStripMenuItem, funcionárioToolStripMenuItem, relatórioToolStripMenuItem });
            menuAplicacao.Location = new Point(0, 0);
            menuAplicacao.Name = "menuAplicacao";
            menuAplicacao.Size = new Size(626, 24);
            menuAplicacao.TabIndex = 1;
            menuAplicacao.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem1, logoutToolStripMenuItem });
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(60, 20);
            loginToolStripMenuItem.Text = "Sistema";
            // 
            // loginToolStripMenuItem1
            // 
            loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            loginToolStripMenuItem1.Size = new Size(112, 22);
            loginToolStripMenuItem1.Text = "Login";
            loginToolStripMenuItem1.Click += loginToolStripMenuItem1_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(112, 22);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // veículoToolStripMenuItem
            // 
            veículoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarEntradaToolStripMenuItem, registrarSaídaToolStripMenuItem });
            veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            veículoToolStripMenuItem.Size = new Size(57, 20);
            veículoToolStripMenuItem.Text = "Veículo";
            // 
            // registrarEntradaToolStripMenuItem
            // 
            registrarEntradaToolStripMenuItem.Name = "registrarEntradaToolStripMenuItem";
            registrarEntradaToolStripMenuItem.Size = new Size(180, 22);
            registrarEntradaToolStripMenuItem.Text = "Registrar Entrada";
            registrarEntradaToolStripMenuItem.Click += registrarEntradaToolStripMenuItem_Click;
            // 
            // registrarSaídaToolStripMenuItem
            // 
            registrarSaídaToolStripMenuItem.Name = "registrarSaídaToolStripMenuItem";
            registrarSaídaToolStripMenuItem.Size = new Size(180, 22);
            registrarSaídaToolStripMenuItem.Text = "Registrar Saída";
            registrarSaídaToolStripMenuItem.Click += registrarSaídaToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, editarToolStripMenuItem, excluirToolStripMenuItem });
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(82, 20);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(180, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(180, 22);
            editarToolStripMenuItem.Text = "Editar";
            editarToolStripMenuItem.Click += editarToolStripMenuItem_Click;
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new Size(180, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gerarRelatórioToolStripMenuItem });
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(66, 20);
            relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // gerarRelatórioToolStripMenuItem
            // 
            gerarRelatórioToolStripMenuItem.Name = "gerarRelatórioToolStripMenuItem";
            gerarRelatórioToolStripMenuItem.Size = new Size(152, 22);
            gerarRelatórioToolStripMenuItem.Text = "Gerar Relatório";
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 307);
            Controls.Add(menuAplicacao);
            IsMdiContainer = true;
            MainMenuStrip = menuAplicacao;
            Name = "formMain";
            Text = "Sistema de Estacionamento";
            WindowState = FormWindowState.Maximized;
            menuAplicacao.ResumeLayout(false);
            menuAplicacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuAplicacao;
        private ToolStripMenuItem veículoToolStripMenuItem;
        private ToolStripMenuItem registrarEntradaToolStripMenuItem;
        private ToolStripMenuItem registrarSaídaToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private ToolStripMenuItem gerarRelatórioToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem1;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoEstacionamento.Controller;

namespace ProjetoEstacionamento
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            Controller.ControllerLogin c = new Controller.ControllerLogin();
            int r = c.Login(usuario, senha);
            if (r == 1)
            {
                MessageBox.Show("Logado como funcionário.");
                this.Close();
            }
            else if (r == 2)
            {
                MessageBox.Show("Logado como gerente.");
                this.Close();
            }
            else if (r == 0)
            {
                MessageBox.Show("Usuário e/ou senha errados!");
                txtUsuario.Text = txtSenha.Text = "";
            }
        }
    }
}

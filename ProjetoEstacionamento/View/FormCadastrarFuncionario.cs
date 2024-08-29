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
    public partial class FormCadastrarFuncionario : Form
    {
        public FormCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cargo = txtCargo.Text;
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            ControllerFuncionario control = new ControllerFuncionario();
            int r = control.salvarFuncionario(nome, cargo, usuario, senha);

            if (r > 0) {
                MessageBox.Show("Sucesso!");
            }
            else
            {
                MessageBox.Show("Erro!");
            }
            this.Close();
        }
    }
}

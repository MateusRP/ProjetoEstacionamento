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
using ProjetoEstacionamento.DTO;

namespace ProjetoEstacionamento
{
    public partial class FormExcluirFuncionario : Form
    {
        private Controller.ControllerLogin c;
        public FormExcluirFuncionario()
        {
            InitializeComponent();
            c = new Controller.ControllerLogin();
            cmbListaFunc.DataSource = c.Funcionario_lista;
            cmbListaFunc.DisplayMember = "Nome";
        }

        private void cmbListaFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            FuncionarioDTO f = (FuncionarioDTO)cmbListaFunc.SelectedItem;
            lblNome.Text = "Nome: " + f.Nome;
            lblCargo.Text = "Cargo: " + f.Cargo;
            lblUsuario.Text = "Usuário: " + f.Usuario;
            lblSenha.Text = "Senha: " + f.Senha;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FuncionarioDTO f = (FuncionarioDTO) cmbListaFunc.SelectedItem;
            string message = "Tem certeza que deseja excluir o funcionário " + f.Nome + "?";
            string titulo = "Exclusão";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult r = MessageBox.Show(message,titulo, buttons);
            if (r == DialogResult.Yes)
            {
                MessageBox.Show("Descubra como remover!");
            }
        }
    }
}

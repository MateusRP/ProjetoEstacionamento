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
    public partial class FormEditarFuncionario : Form
    {
        public FormEditarFuncionario()
        {
            InitializeComponent();

            preencherDataGrid();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ControllerFuncionario control = new ControllerFuncionario();
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            string cargo = txtCargo.Text;
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;
            int resultado = control.atualizarFuncionario(id,nome,cargo,usuario,senha);

            if (resultado > 0)
            {
                MessageBox.Show("Sucessor!");
            }
            else 
            {
                MessageBox.Show("Erro!");
            }
            preencherDataGrid();
            txtId.Text = txtNome.Text = txtCargo.Text = txtUsuario.Text = txtSenha.Text = "";
        }

        private void preencherDataGrid()
        {
            string[] dados = new string[5];
            dgvFuncionario.AutoGenerateColumns = false;
            dgvFuncionario.Rows.Clear();

            ControllerFuncionario control = new ControllerFuncionario();
            List<FuncionarioDTO> lista = control.listarFuncionarios();
            foreach (FuncionarioDTO func in lista)
            {
                dados[0] = func.Id.ToString();
                dados[1] = func.Nome;
                dados[2] = func.Cargo;
                dados[3] = func.Usuario;
                dados[4] = func.Senha;
                dgvFuncionario.Rows.Add(dados);
            }
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtId.Text = dgvFuncionario.Rows[index].Cells[0].Value.ToString();
                txtNome.Text = dgvFuncionario.Rows[index].Cells[1].Value.ToString();
                txtCargo.Text = dgvFuncionario.Rows[index].Cells[2].Value.ToString();
                txtUsuario.Text = dgvFuncionario.Rows[index].Cells[3].Value.ToString();
                txtSenha.Text = dgvFuncionario.Rows[index].Cells[4].Value.ToString();
            }
        }
    }
}

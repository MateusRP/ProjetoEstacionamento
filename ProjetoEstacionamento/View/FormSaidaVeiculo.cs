using ProjetoEstacionamento.Controller;
using ProjetoEstacionamento.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstacionamento
{
    public partial class FormSaidaVeiculo : Form
    {
        public FormSaidaVeiculo()
        {
            InitializeComponent();
            preencherDataGrid();
        }
        private void preencherDataGrid()
        {
            string[] dados = new string[6];
            dgvVeiculos.AutoGenerateColumns = false;
            dgvVeiculos.Rows.Clear();

            ControllerVeiculo control = new ControllerVeiculo();
            List<VeiculoDTO> lista = control.listaVeiculos();

            foreach (VeiculoDTO v in lista)
            {
                dados[0] = v.Id.ToString();
                dados[1] = v.Modelo;
                dados[2] = v.Cor;
                dados[3] = v.Placa;
                dados[4] = v.HorEntrada.ToString();
                dados[5] = v.HorSaida.ToString();
                dgvVeiculos.Rows.Add(dados);
            }
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string modelo = txtModelo.Text;
            string cor = txtCor.Text;
            string placa = txtPlaca.Text;
            DateTime hora_entrada = Convert.ToDateTime(txtEntrada.Text);

            ControllerVeiculo control = new ControllerVeiculo();
            int resultado = control.fecharVeiculo(id,modelo,cor,placa,hora_entrada);

            if (resultado > 0)
            {
                MessageBox.Show("Sucesso!");
            }
            else
            {
                MessageBox.Show("Erro!");
            }
            preencherDataGrid();
        }

        private void dgvVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0){
                txtId.Text = dgvVeiculos.Rows[index].Cells[0].Value.ToString();
                txtModelo.Text = dgvVeiculos.Rows[index].Cells[1].Value.ToString();
                txtCor.Text = dgvVeiculos.Rows[index].Cells[2].Value.ToString();
                txtPlaca.Text = dgvVeiculos.Rows[index].Cells[3].Value.ToString();
                txtEntrada.Text = dgvVeiculos.Rows[index].Cells[4].Value.ToString();
            }

        }
    }
}

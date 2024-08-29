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
    public partial class FormEntradaVeiculo : Form
    {
        public FormEntradaVeiculo()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string modelo = txtModelo.Text;
            string cor = txtCor.Text;
            string placa = txtPlaca.Text;

            ControllerVeiculo control = new ControllerVeiculo();
            int resultado = control.salvarVeiculo(modelo, cor, placa);

            if (resultado > 0)
            {
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

namespace ProjetoEstacionamento
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }
        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
            FormLogin f = new FormLogin();
            f.MdiParent = this;
            f.Show();
        }
        private void registrarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
            FormEntradaVeiculo entradaVeiculo = new FormEntradaVeiculo();
            entradaVeiculo.MdiParent = this;
            entradaVeiculo.Show();
        }

        private void registrarSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
            FormSaidaVeiculo f = new FormSaidaVeiculo();
            f.MdiParent = this;
            f.Show();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
            FormCadastrarFuncionario f = new FormCadastrarFuncionario();
            f.MdiParent = this;
            f.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
            FormEditarFuncionario f = new FormEditarFuncionario();
            f.MdiParent = this;
            f.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
            FormExcluirFuncionario f = new FormExcluirFuncionario();
            f.MdiParent = this;
            f.Show();
        }
    }
}

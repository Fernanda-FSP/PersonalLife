using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalLife.Controle;

namespace PersonalLife.View
{
    public partial class frmListUsuario : Form
    {
        public frmListUsuario()
        {
            InitializeComponent();
        }
        //
        private void frmListUsuario_Load_1(object sender, EventArgs e)
        {
            try
            {
                List<Entidade> Lista = new List<Entidade>();
                Lista = new BD().ListarUsuario();
                grid.AutoGenerateColumns = false;
                grid.DataSource = Lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar dados: " + ex.Message);
            }
        }
        //Método para coltar a tela anterior
        private void picVoltar_Click(object sender, EventArgs e)
        {
            frmAdm tela = new frmAdm();
            tela.Show();
            Close();
        }
        //Método para listar no grid
        private void FrmListUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                List<Entidade> Lista = new List<Entidade>();
                Lista = new BD().ListarUsuario();
                grid.AutoGenerateColumns = false;
                grid.DataSource = Lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar dados: " + ex.Message);
            }
        }
        //Método para atualizar usuario 
        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            //Instanciando a classe UsuarioEnt
            Entidade objTabela = new Entidade();
            BD cont = new BD();
            try
            {
                objTabela.IdUsuario = Convert.ToInt32(txtId.Text);
                objTabela.Nome = Convert.ToString(txtNome.Text);
                objTabela.Telefone = Convert.ToString(txtTelefone.Text);
                objTabela.Idade = Convert.ToInt32(txtIdade.Text);
                objTabela.Altura = Convert.ToDouble(txtAltura.Text);
                objTabela.Peso = Convert.ToDouble(txtPeso.Text);
                objTabela.MetaPeso = Convert.ToString(txtMeta.Text);
                objTabela.Usuario = Convert.ToString(txtUsuario.Text);
                objTabela.Senha = Convert.ToString(txtSenha.Text);
                objTabela.Email = Convert.ToString(txtEmail.Text);
                //Método para atualizar usuario
                int x = cont.AtualizarUsuario(objTabela);
                //Verificando se deu certo
                if (x > 0)
                {
                    MessageBox.Show("Usuário: " + txtNome.Text + ", atualizar com sucesso!");
                    //Atualizando o conteúdo da tela após a ação executada
                    frmListUsuario tela = new frmListUsuario();
                    tela.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Não atualizar!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar. Erro: " + ex.Message);
            }
        }
        //Método para voltar a tela anterior
        private void picVoltar_Click_2(object sender, EventArgs e)
        {
            frmAdm tela = new frmAdm();
            tela.Show();
            this.Hide();
        }
        //Método botão excluir 
        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            //Instanciando classes
            Entidade objTabela = new Entidade();
            BD cont = new BD();
            try
            {
                objTabela.IdUsuario = Convert.ToInt32(txtId.Text); // cammpo inexistente (erro)
                int x = cont.ExcluirUsuario(objTabela);
                if (x > 0)
                {
                    MessageBox.Show("Usuário: " + txtNome.Text + ", excluído com sucesso!");

                    //Atualizando o conteúdo da tela após a ação executada
                    frmListUsuario tela = new frmListUsuario();
                    tela.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Não excluído!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir. Erro: " + ex.Message);
            }
        }
        //Método para pesquisar usuario
        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            //Instanciando classes
            Entidade objTabela = new Entidade();
            try
            {
                objTabela.Nome = txtPesquisa.Text;
                List<Entidade> Pesquisa = new List<Entidade>();
                Pesquisa = new BD().PesquisarUsuario(objTabela);
                grid.AutoGenerateColumns = false;
                grid.DataSource = Pesquisa;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar dados: " + ex.Message);
            }
        }
        //Método cellclick 
        private void grid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtTelefone.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtIdade.Text = grid.CurrentRow.Cells[4].Value.ToString();
            txtAltura.Text = grid.CurrentRow.Cells[5].Value.ToString();
            txtPeso.Text = grid.CurrentRow.Cells[6].Value.ToString();
            txtMeta.Text = grid.CurrentRow.Cells[7].Value.ToString();
            txtUsuario.Text = grid.CurrentRow.Cells[8].Value.ToString();
            txtSenha.Text = grid.CurrentRow.Cells[9].Value.ToString();
        }
        //Após pesquisar algum dado, voltar com tota a listagem inicial
        private void btnListarTudo_Click(object sender, EventArgs e)
        {
            try
            {
                List<Entidade> Lista = new List<Entidade>();
                Lista = new BD().ListarUsuario();
                grid.AutoGenerateColumns = false;
                grid.DataSource = Lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar dados: " + ex.Message);
            }
        }
    }
}

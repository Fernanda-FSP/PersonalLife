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
    public partial class frmListExercicio : Form
    {
        public frmListExercicio()
        {
            InitializeComponent();
        }

        //Método para que os dados apareçam no dataGrid
        private void frmListExericio_Load(object sender, EventArgs e)
        {
            try
            {
                List<Entidade> Lista = new List<Entidade>();
                Lista = new BD().ListarExercicio();
                grid.AutoGenerateColumns = false;
                grid.DataSource = Lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar dados: " + ex.Message);
            }
        }
        //PictureBox VOLTAR
        private void picVoltar_Click_1(object sender, EventArgs e)
        {
            frmAdm tela = new frmAdm();
            tela.Show();
            this.Hide();
        }
        //Desenvolvimento da função do botão EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Instanciando classes
            Entidade objTabela = new Entidade();
            BD cont = new BD();
            try
            {
                objTabela.IdExercicio = Convert.ToInt32(txtId.Text); // cammpo inexistente (erro)
                int x = cont.ExcluirExercicio(objTabela);
                if (x > 0)
                {
                    MessageBox.Show("Exercício: " + txtNome.Text + ", excluído com sucesso!");

                    //Atualizando o conteúdo da tela após a ação executada
                    frmListExercicio tela = new frmListExercicio();
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
        //Desenvolvimento da função do botão ATUALIZAR
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Instanciando a classe UsuarioEnt
            Entidade objTabela = new Entidade();
            BD cont = new BD();
            try
            {
                objTabela.IdExercicio = Convert.ToInt32(txtId.Text);
                objTabela.Exercicio = Convert.ToString(txtNome.Text);
                objTabela.Repeticao = Convert.ToInt32(txtRepeticao.Text);
                objTabela.Descanso = Convert.ToInt32(txtDescanso.Text);
                objTabela.Sessao = Convert.ToInt32(txtSessoes.Text);
                //Método para atualizar usuario
                int x = cont.AtualizarExercicio(objTabela);
                //Verificando se deu certo
                if (x > 0)
                {
                    MessageBox.Show("Exercício: " + txtNome.Text + ", atualizado com sucesso!");
                    //Atualizando o conteúdo da tela após a ação executada
                    frmListExercicio tela = new frmListExercicio();
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
        //Desenvolvimento da função do botão PESQUISAR
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciando a classse Entidade
                Entidade objTabela = new Entidade();
                objTabela.Exercicio = txtPesquisa.Text;
                //Listando os exercicios pesquisados
                List<Entidade> Pesquisa = new List<Entidade>();
                Pesquisa = new BD().PesquisarExercicio(objTabela);
                grid.AutoGenerateColumns = false;
                grid.DataSource = Pesquisa;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao listar dados: " + ex.Message);
            }
        }
        //Quando clicar em uma linha do grid os dados vão para o txt
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtRepeticao.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtDescanso.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtSessoes.Text = grid.CurrentRow.Cells[4].Value.ToString();
        }
        //Após pesquisar algum dado, voltar com tota a listagem inicial
        private void btnListarTudo_Click(object sender, EventArgs e)
        {
            try
            {
                List<Entidade> Lista = new List<Entidade>();
                Lista = new BD().ListarExercicio();
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

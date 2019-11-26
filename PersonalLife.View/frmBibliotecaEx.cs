using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PersonalLife.Controle;

namespace PersonalLife.View
{
    public partial class frmBibliotecaEx : Form
    {
        public frmBibliotecaEx()
        {
            InitializeComponent();
        }
        //Método para listar exercícios para escolha do usuário
        private void frmBibliotecaEx_Load(object sender, EventArgs e)
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
        //Metódo para voltar para a tela anterior
        private void picVoltar_Click(object sender, EventArgs e)
        {
            frmPerfilCliente voltar = new frmPerfilCliente();
            voltar.Show();
            this.Hide();
        }
        //Enviando os exercícios do dataGrid de exercicios para o usuário
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Referenciando a lista que os exercícios estão presentes
            List<Entidade> dados = new List<Entidade>(); 
            foreach (DataGridViewRow item in grid.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    dados.Add(new Entidade
                    {
                        IdExercicio = Convert.ToInt32(item.Cells[1].Value.ToString()),
                        Exercicio = item.Cells[2].Value.ToString(),
                        Repeticao = Convert.ToInt32(item.Cells[3].Value.ToString()),
                        Descanso = Convert.ToInt32(item.Cells[4].Value.ToString()),
                        Sessao = Convert.ToInt32(item.Cells[5].Value.ToString())
                    });
                }
            }
            //Abre o datagrid do Usuário após a inserção dos exercícios
            frmMeusEx tela = new frmMeusEx();
            tela.Values = dados;
            tela.Show();
            this.Hide();
            //Login para confirmar
            frmConfirmar t = new frmConfirmar();
            t.Show();
        }
        //Abre o a tela de exercícios do usuário
        private void meusExercíciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeusEx tela = new frmMeusEx();
            tela.Show();
            this.Hide();
        }
        //Desenvolvimento do botão AJUDA
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Biblioteca de Exercícios\n\n\nAqui encontram-se todos os exercícios existentes no sistema," +
                "para colocá-los dentro do seu cronograma de exercícios basta clicar nos que você quer e, em seguida, " +
                "clique no botão ADICIONAR.");
        }
    }
}

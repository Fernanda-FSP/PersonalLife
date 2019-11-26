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
using System.Data.SqlClient;

namespace PersonalLife.View
{
    public partial class frmMeusEx : Form
    {
        public frmMeusEx()
        {
            InitializeComponent();
        }
        //Método para passar login
        public frmMeusEx(string usuario)
        {
            InitializeComponent();
            //Instanciando classes
            Entidade objTabela = new Entidade();
            txtUsu.Text = usuario;
            objTabela.Usuario = usuario;
        }
        //Método que retorna ao form anterior
        private void picVoltar_Click(object sender, EventArgs e)
        {
            frmPerfilCliente voltar = new frmPerfilCliente();
            voltar.Show();
            this.Hide();
            Close();
        }
        //Método que leva o usuário a biblioteca de exercícios do sistema
        private void meusExercíciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBibliotecaEx tela = new frmBibliotecaEx();
            tela.Show();
            Hide();
        }
        //Método que traz os exercícios escolhidos da biblioteca de exercícios do sistema
        public List<Entidade> Values { get; set; }
        public void AdicionarGrid(List<Entidade> val)
        {
            if (val != null)
            {
                foreach (Entidade item in val)
                {
                    int n = gridUsuario.Rows.Add();
                    gridUsuario.Rows[n].Cells[0].Value = item.IdExercicio;
                    gridUsuario.Rows[n].Cells[1].Value = item.Exercicio;
                    gridUsuario.Rows[n].Cells[2].Value = item.Repeticao;
                    gridUsuario.Rows[n].Cells[3].Value = item.Descanso;
                    gridUsuario.Rows[n].Cells[4].Value = item.Sessao;
                }
            }
        }
        //Adiciona os exercícios escolhidos
        private void frmMeusEx_Load(object sender, EventArgs e)
        {
            //Instanciando classes
            Entidade objTabela = new Entidade();
            BD cont = new BD();
            AdicionarGrid(Values);

            //Teste 1
            for (int i = 0; i < gridUsuario.Rows.Count; i++)
            {
                string[] dados = new[]
                {
                    objTabela.Id1 = gridUsuario.Rows[i].Cells["IdExercicio"].Value.ToString(),
                    objTabela.Exercicio = gridUsuario.Rows[i].Cells["Nome"].Value.ToString(),
                    objTabela.Repeticao1 =  gridUsuario.Rows[i].Cells["NumeroRepeticoes"].Value.ToString(),
                    objTabela.Descanso1 =  gridUsuario.Rows[i].Cells["TempoDescanso"].Value.ToString(),
                    objTabela.Sessao1 =  gridUsuario.Rows[i].Cells["NumeroSessoes"].Value.ToString(),
                };
                //Convocando método para salvar dados
                cont.ExUsu(objTabela);
            }

            //Teste 2
            //List<Entidade> Lista = new List<Entidade>();
            //Lista = new BD().ListaEx();
            //gridUsuario.AutoGenerateColumns = false;
            //gridUsuario.DataSource = Lista;
        }
    }
}

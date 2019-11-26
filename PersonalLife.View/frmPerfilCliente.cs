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
    public partial class frmPerfilCliente : Form
    {
        public int conte;
        public frmPerfilCliente()
        {
            InitializeComponent();
        }
        //Passando  usuário por parâmetro
        public frmPerfilCliente(string usuario)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;
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
        //Método load perfil cliente
        private void frmPerfilCliente_Load(object sender, EventArgs e)
        {
            try
            {
                //Métodos para exibir os dados no datagrid Exercicio
                Entidade objTabela = new Entidade();
                objTabela.Usuario = txtUsuario.Text;
                List<Entidade> Lista = new List<Entidade>();
                Lista = new BD().PerfilCliente(objTabela);
                grid.AutoGenerateColumns = false;
                grid.DataSource = Lista;
                //Pegando ID
                txtId.Text = grid.Rows[0].Cells["Id"].Value.ToString();
                //Preenchendo o dataGrid de Exercícios
                try
                {
                    List<Entidade> ListaEx = new List<Entidade>();
                    ListaEx = new BD().ListarExercicio();
                    gridExercicio.AutoGenerateColumns = false;
                    gridExercicio.DataSource = ListaEx;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao listar dados: " + ex.Message);
                }
                //Atribuindo um valor à label
                BD cont = new BD();
                lblImc.Text = cont.CalcImc(objTabela);
                //Verificando se está dentro do IMC ideal
                if (Convert.ToDouble(lblImc.Text) < 18.5)
                {
                    lblImc.BackColor = Color.White;
                    lblImc.ForeColor = Color.DodgerBlue;
                }
                if ((Convert.ToDouble(lblImc.Text) >= 18.5) &&
                    Convert.ToDouble(lblImc.Text) < 25)
                {
                    lblImc.ForeColor = Color.LightGreen;
                }
                else if ((Convert.ToDouble(lblImc.Text) >= 25) &&
                    Convert.ToDouble(lblImc.Text) < 30)
                {
                    lblImc.ForeColor = Color.LightYellow;
                }
                else if ((Convert.ToDouble(lblImc.Text) >= 30) &&
                    Convert.ToDouble(lblImc.Text) < 35)
                {
                    lblImc.ForeColor = Color.LightPink;
                }
                else if ((Convert.ToDouble(lblImc.Text) >= 35) &&
                    Convert.ToDouble(lblImc.Text) < 40)
                {
                    lblImc.ForeColor = Color.Orange;
                }
                else if ((Convert.ToDouble(lblImc.Text) >= 40))
                {
                    lblImc.ForeColor = Color.Red;
                }
                //Passando de um datagrid para outro
                AdicionarGrid(Values);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar dados: " + ex.Message);
            }

        }
        //Método para preencher a barra de status
        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if (chk1.Checked == true)
            {
                pgbProgresso.Value += 20;
                //Verificando preenchimento da barra
                if (pgbProgresso.Value == 100)
                {
                    try
                    {
                        MessageBox.Show("Duas palavras para você: PARA e BÉNS.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro no sistema.\n\nTente novamente mais tarde." + ex.Message);
                    }
                }
            }
            else
            {
                pgbProgresso.Value -= 20;
            }
        }
        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2.Checked == true)
            {
                pgbProgresso.Value += 20;
                //Verificando preenchimento da barra
                if (pgbProgresso.Value == 100)
                {
                    try
                    {
                        MessageBox.Show("Duas palavras para você: PARA e BÉNS.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro no sistema.\n\nTente novamente mais tarde." + ex.Message);
                    }
                }
            }
            else
            {
                pgbProgresso.Value -= 20;
            }
        }
        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3.Checked == true)
            {
                pgbProgresso.Value += 20;
                //Verificando preenchimento da barra
                if (pgbProgresso.Value == 100)
                {
                    try
                    {
                        MessageBox.Show("Duas palavras para você: PARA e BÉNS.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro no sistema.\n\nTente novamente mais tarde." + ex.Message);
                    }
                }
            }
            else
            {
                pgbProgresso.Value -= 20;
            }
        }
        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4.Checked == true)
            {
                pgbProgresso.Value += 20;
                //Verificando preenchimento da barra
                if (pgbProgresso.Value == 100)
                {
                    try
                    {
                        MessageBox.Show("Duas palavras para você: PARA e BÉNS.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro no sistema.\n\nTente novamente mais tarde." + ex.Message);
                    }
                }
            }
            else
            {
                pgbProgresso.Value -= 20;
            }
        }
        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5.Checked == true)
            {
                pgbProgresso.Value += 20;
                //Verificando preenchimento da barra
                if (pgbProgresso.Value == 100)
                {
                    try
                    {
                        MessageBox.Show("Duas palavras para você: PARA e BÉNS.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro no sistema.\n\nTente novamente mais tarde." + ex.Message);
                    }
                }
            }
            else
            {
                pgbProgresso.Value -= 20;
            }
        }
        //Abrindo biblioteca de exercicios
        private void bibiotecaDeExercíciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBibliotecaEx tela = new frmBibliotecaEx();
            this.Hide();
            tela.Show();
        }
        //Método para abrir meus exercicios
        private void meusExercíciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeusEx tela = new frmMeusEx();
            this.Hide();
            tela.Show();
        }
        //Desenvolvimento do botão de AJUDA
        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá, esta é a sua página, página do usuário do sistema. \n\n Nesta página você pode: \n - Verificar o seu progresso semanal ,marcando os dias em que você se exercitou \n - Acompanhar seu progresso semanal através da barra de progresso \n - Visualizar seus dados \n - Visualizar os exercícios no sistema e adicioná-los a sua lista (Adicionar e Listar) \n\n Mais informações, contate os adiministradores do sistema. \n\n A equipe Personal Life agradece por usar nosso sistema");
        }
        //Desenvolvimento do botão ADICIONAR 
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Login para confirmar
            //frmConfirmar t = new frmConfirmar();
            //t.Show();
            //Referenciando a lista que os exercícios estão presentes
            List<Entidade> dados = new List<Entidade>();
            foreach (DataGridViewRow item in gridExercicio.Rows)
            {
                if (Convert.ToBoolean(item.Cells[0].Value))
                {
                    int n = gridUsuario.Rows.Add();
                    gridUsuario.Rows[n].Cells[0].Value = item.Cells[1].Value.ToString();
                    gridUsuario.Rows[n].Cells[1].Value = item.Cells[2].Value.ToString();
                    gridUsuario.Rows[n].Cells[2].Value = item.Cells[3].Value.ToString();
                    gridUsuario.Rows[n].Cells[3].Value = item.Cells[4].Value.ToString();
                    gridUsuario.Rows[n].Cells[4].Value = item.Cells[5].Value.ToString();
                }
            }
            btnListar.Enabled = false;

        }
        //Botão para salvar e sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando classes
            BD cont = new BD();
            Entidade objTabela = new Entidade();
            objTabela.Id2 = txtId.Text;      
            //Estrutura para salvar todos os exercicios do usuário
            for (int i = 0; i < gridUsuario.Rows.Count; i++)
            {
                string[] dados = new[]
                {
                        objTabela.Id1 = gridUsuario.Rows[i].Cells["IdExercicio"].Value.ToString(),
                        objTabela.Id2 = grid.Rows[0].Cells["Id"].Value.ToString(),
                        objTabela.Exercicio = gridUsuario.Rows[i].Cells["Exercicio"].Value.ToString(),
                        objTabela.Repeticao1 =  gridUsuario.Rows[i].Cells["Repeticao"].Value.ToString(),
                        objTabela.Descanso1 =  gridUsuario.Rows[i].Cells["Descanso"].Value.ToString(),
                        objTabela.Sessao1 =  gridUsuario.Rows[i].Cells["Sessao"].Value.ToString(),
                };
                //Convocando método para salvar dados
                cont.ExUsu(objTabela);
            }
        }
        //Botão para listar no datagrid
        private void btnListar_Click(object sender, EventArgs e)
        {
            conte = 1;
            //Instanciando classes
            Entidade objTabela = new Entidade();
            //Chamando os exercicios do cliente especifico
            try
            {
                //Métodos para exibir os dados no datagrid Exercicio
                objTabela.Id2 = txtId.Text;
                List<Entidade> ListaUsu = new List<Entidade>();
                ListaUsu = new BD().ListaEx(objTabela);
                gridUsuario.AutoGenerateColumns = false;
                gridUsuario.DataSource = ListaUsu;
                //Deixando o botão desabilitado
                btnAdicionar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar dados: " + ex.Message);
            }
        }
        //Método para salvar e sair
        private void frmPerfilCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Instanciando classes
            BD cont = new BD();
            Entidade objTabela = new Entidade();
            objTabela.Id2 = txtId.Text;
            //Estrutura para salvar todos os exercicios do usuário
            for (int i = 0; i < gridUsuario.Rows.Count; i++)
            {
                string[] dados = new[]
                {
                        objTabela.Id1 = gridUsuario.Rows[i].Cells["IdExercicio"].Value.ToString(),
                        objTabela.Id2 = grid.Rows[0].Cells["Id"].Value.ToString(),
                        objTabela.Exercicio = gridUsuario.Rows[i].Cells["Exercicio"].Value.ToString(),
                        objTabela.Repeticao1 =  gridUsuario.Rows[i].Cells["Repeticao"].Value.ToString(),
                        objTabela.Descanso1 =  gridUsuario.Rows[i].Cells["Descanso"].Value.ToString(),
                        objTabela.Sessao1 =  gridUsuario.Rows[i].Cells["Sessao"].Value.ToString(),
                };
                //Verificando clique
                if (conte == 1)
                {
                    
                }
                else
                {
                    //Convocando método para salvar dados
                    cont.ExUsu(objTabela);
                }
            }
            //Método para fechar bonitamente
            const string message = "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }

            Application.OpenForms["frmLogin"].Show();
        }
        //Caso ele queira saber a tabela do IMC
        private void lblImc_Click(object sender, EventArgs e)
        {
            frmIMC tela = new frmIMC();
            tela.Show();
        }
    }
}

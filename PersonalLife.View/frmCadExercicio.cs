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
    public partial class frmCadExercicio : Form
    {
        public frmCadExercicio()
        {
            InitializeComponent(); 
        }
        //Método para cadastrar exercicio
        private void btnCadastroExercicio_Click_1(object sender, EventArgs e)
        {
            //Instanciando classes
            Entidade objTabela = new Entidade();
            BD cont = new BD();
            //Condicional que verifica se todos os campos foram preenchidos, caso contrário o cadastro não é efetuado
            if ((txtNomeExercicio.Text != "") && (txtNumeroRepeticoes.Text != "") && (txtNumeroSessoes.Text != "") &&
                (txtTempoDescanso.Text != ""))
            {
                try
                {
                    //Atribuindo os valores inserdos nos campos aos atributos
                    objTabela.Exercicio = txtNomeExercicio.Text;
                    objTabela.Repeticao = int.Parse(txtNumeroRepeticoes.Text);
                    objTabela.Descanso = int.Parse(txtTempoDescanso.Text);
                    objTabela.Sessao = int.Parse(txtNumeroSessoes.Text);
                    //Método usado para cadastrar exercicio
                    int x = cont.InserirExercicio(objTabela);
                    //Condicional que verifica se o usuário foi inserido
                    if (x > 0)
                    {
                        MessageBox.Show("Exercício: " + txtNomeExercicio.Text + ", inserido com sucesso!");
                        //Assim que o usuário executar o cadastro a tela retorna em branco
                        frmCadExercicio tela = new frmCadExercicio();
                        tela.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuário não inserido.");
                    }
                }
                //Se houver alguma falha na execução a mensagem de erro é exibida
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
            //Se algum campo não for preenchido a mensagem de falha é exibida
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
        //Método para voltar ao form anterior
        private void picVoltar_Click_1(object sender, EventArgs e)
        {
            frmAdm voltar = new frmAdm();
            voltar.Show();
            this.Hide();
        }
    }
}

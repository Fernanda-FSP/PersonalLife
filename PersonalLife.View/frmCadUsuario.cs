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
    public partial class frmCadUsuario : Form
    {
        public Form telaprincipal;
        public frmCadUsuario()
        {
            InitializeComponent();
        }
        //Método para cadstrar usuario
        private void btnCadastroExercicio_Click_1(object sender, EventArgs e)
        {
            //Instanciando classes 
            Entidade objTabela = new Entidade();
            BD cont = new BD();
            //Condicional que determina que para que o cadastro seja efetuado, todos os campos devem ser preenchidos
            if ((txtNomeCadastro.Text != "") && (txtIdadeCadastro.Text != "") && (txtPesoCadastro.Text != "") &&
                (txtAlturaCadastro.Text != "") && (txtTelefoneCadastro.Text != "") && (txtLogin.Text != "") &&
                (txtSenha.Text != "") && (txtEmailCadastro.Text != "") && ((rbtPerderPeso.Checked) || (rbtGanharMassa.Checked)))
            {
                try
                {
                    //Os atributos recebem o que for inserido no campo
                    objTabela.Nome = txtNomeCadastro.Text;
                    objTabela.Idade = int.Parse(txtIdadeCadastro.Text);
                    objTabela.Peso = double.Parse(txtPesoCadastro.Text);
                    objTabela.Altura = double.Parse(txtAlturaCadastro.Text);
                    objTabela.Telefone = txtTelefoneCadastro.Text;
                    objTabela.Usuario = txtLogin.Text;
                    objTabela.Senha = txtSenha.Text;
                    objTabela.Email = txtEmailCadastro.Text;
                    //Condição de preenchimento da meta de peso
                    if (rbtPerderPeso.Checked)
                    {
                        objTabela.MetaPeso = "Perder peso";
                    }
                    if (rbtGanharMassa.Checked)
                    {
                        objTabela.MetaPeso = "Ganhar massa";
                    }
                    //Conferindo se existe outro usuário com o mesmo nome                    
                    //Verificando o resultado do método
                    if (cont.ExistUsu(objTabela) == 0)
                    {
                        MessageBox.Show("Nome de usuário indisponível.\n\nTente outro nome.");
                        txtLogin.Clear();
                        txtLogin.Focus();
                    }
                    else
                    {
                        //Método para inserir usuário
                        int x = cont.InserirUsuario(objTabela);

                        //Verificando se o usuário foi inserido com sucesso
                        if (x > 0)
                        {
                            MessageBox.Show("Usuário: " + txtNomeCadastro.Text + ", inserido com sucesso.");
                            //Assim que o usuário executar o cadastro volta para a tela de login
                            frmLogin tela = new frmLogin();
                            tela.Show();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuário não inserido.");
                        }
                    }
                }
                //Se houver erro na execução a mensagem de erro é exibida
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
            //Se houver algum campo não preenchido esta mensagem aparece
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
        //Método para voltar a tela anterior
        private void picVoltar_Click(object sender, EventArgs e)
        {
            frmLogin tela = new frmLogin();
            tela.Show();
            this.Hide();
        }
        //Método para verificar se o email já existe e está no formato correto
        private void txtEmailCadastro_Leave(object sender, EventArgs e)
        {
            string login = new string(txtEmailCadastro.Text.Reverse().ToArray());
            for (int i = 0; i < txtEmailCadastro.Text.Length; i++)
            {
                //compara se o email tem @
                if (txtEmailCadastro.Text.ElementAt(i) == '@')
                {
                    //compara se termina com .com (como está invertido fica moc.)
                    if (login.Substring(0, 4) == "moc.")
                    {
                        //se estiver tudo certo, o índice estoura e termina a checagem
                        i = txtEmailCadastro.Text.Length;
                        //tratamento da interface
                        lblLogin2.Visible = false;
                        Entidade objTabela = new Entidade();
                        BD cont = new BD();
                        objTabela.Email = txtEmailCadastro.Text;
                        //esse método compara se o login já checado está registrado
                        if (cont.PegaEmail(objTabela) == 0)
                        {
                            //tratamento da interface
                            lblLogin1.Visible = false;
                            btnCadastroExercicio.Enabled = true;
                        }
                        else
                        {
                            //tratamento da interface
                            lblLogin1.Visible = true;
                            btnCadastroExercicio.Enabled = false; 
                        }
                    }
                    else
                    {
                        //tratamento da interface
                        lblLogin2.Visible = true;
                        btnCadastroExercicio.Enabled = false;
                        lblLogin1.Visible = false;
                    }
                }
                else
                {
                    //tratamento da interface
                    lblLogin2.Visible = true;
                    btnCadastroExercicio.Enabled = false;
                }
            }
        }
    }
}

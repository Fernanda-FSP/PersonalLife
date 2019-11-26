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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //Método para exibir senha 
        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if(txtSenha.UseSystemPasswordChar == false)
            {
                txtSenha.UseSystemPasswordChar = true;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = false;
            }
        }
        //Método para fazer login 
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "adm") && (txtSenha.Text == "12345"))
            {
                //Instanciando e mostrando a tela
                frmAdm admtela = new frmAdm() { telaprincipal = this };
                this.Hide();
                admtela.Show();
            }
            else
            {
                try
                {
                    //Verificando o preenchimento do campo USUÁRIO
                    if (txtUsuario.Text == "")
                    {
                        MessageBox.Show("Preencha o campo Usuário!");
                        txtUsuario.Focus();
                        lblMensagem.Text = null;
                        return;
                    }
                    //Verificando o preenchimento do campo SENHA
                    if (txtSenha.Text == "")
                    {
                        MessageBox.Show("Preencha o campo Senha!");
                        txtSenha.Focus();
                        lblMensagem.Text = null;
                        return;
                    }
                    //Instanciando classes
                    Entidade obj = new Entidade();
                    BD cont = new BD();
                    //Atribuiu o campo ao objeto
                    obj.Usuario = txtUsuario.Text;
                    obj.Senha = txtSenha.Text;
                    //Atribuição do método ao objeto
                    obj = new BD().Login(obj);
                    //Verificação da existência do usuário
                    if (obj.Usuario == null)
                    {
                        lblMensagem.Text = "Usuário ou/e senha incorretos!";
                        lblMensagem.ForeColor = Color.Red;
                        //Limpando os campos
                        txtUsuario.Clear();
                        txtSenha.Clear();
                        txtUsuario.Focus();
                        return;
                    }
                    else
                    {                        
                        //Instanciando a classe
                        var aux = new frmPerfilCliente(txtUsuario.Text);
                        //Limpando campos e fazendo o focus
                        txtUsuario.Clear(); txtUsuario.Focus();
                        txtSenha.Clear();
                        this.Hide();
                        aux.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao logar: " + ex.Message);
                }
            }
        }
        //Método para cadastro de novos usuário
        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            //Instanciando e abrindo a tela e fechando tela de login
            frmCadUsuario telaCadastro = new frmCadUsuario() { telaprincipal = this };
            this.Hide();
            telaCadastro.Show();
        }
        //Método para caso o usuário perca senha
        private void lblEsqueciSenha_Click_1(object sender, EventArgs e)
        {
            frmEsqSenha tela = new frmEsqSenha();
            tela.Show();
            this.Hide();
        }
    }
}

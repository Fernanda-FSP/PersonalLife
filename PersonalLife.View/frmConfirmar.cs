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
    public partial class frmConfirmar : Form
    {
        public frmConfirmar()
        {
            InitializeComponent();
        }
        //Método para confirmação do usuário
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verificando o preenchimento do campo USUÁRIO
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Preencha o campo Usuário!");
                    txtUsuario.Focus();
                }
                //Verificando o preenchimento do campo SENHA
                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Preencha o campo Senha!");
                    txtSenha.Focus();
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
                    MessageBox.Show("Usuário não encontrado.");
                    //Retornando a tela anterior
                    frmBibliotecaEx tela = new frmBibliotecaEx();
                    tela.Show();
                    this.Hide();
                }
                //Caso dê certo
                else
                {
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao logar: " + ex.Message);
            }
        }
    }
}

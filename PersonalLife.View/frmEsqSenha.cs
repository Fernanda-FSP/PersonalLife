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
    public partial class frmEsqSenha : Form
    {
        public frmEsqSenha()
        {
            InitializeComponent();
        }
        //Método para verificar existência do usuário
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //Verificando preenchimento
            if ((txtEmail.Text != "") && (txtId.Text != "") && (txtUsuario.Text != ""))
            {
                try
                {
                    //Instanciando classes
                    Entidade objTabela = new Entidade();
                    BD cont = new BD();
                    //Atribuindo campos aos atributos    
                    objTabela.Email = txtEmail.Text;
                    objTabela.IdUsuario = Convert.ToInt32(txtId.Text);
                    objTabela.Usuario = txtUsuario.Text;
                    //Método para verificar existência
                    objTabela = cont.EsqSenha(objTabela);
                    //Verificando se há retorno do bd
                    if (objTabela.Usuario == null)
                    {
                        MessageBox.Show("Usuário não cadastrado.");
                        //Limpando os campos
                        txtUsuario.Clear();
                        txtId.Clear();
                        txtEmail.Clear();
                        txtId.Focus();
                        return;
                    }
                    else
                    {
                        txtConSenha.Enabled = true;
                        txtSenha.Enabled = true;
                        btnAtualizar.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro no sistema.\n\nTente novamente mais tarde." + ex);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }
        //Método para atualizar senha do usuário
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Instanciando a classe UsuarioEnt
            Entidade objTabela = new Entidade();
            BD cont = new BD();
            try
            {
                //Conferindo se as senha batem
                if (txtSenha.Text == txtConSenha.Text)
                {
                    objTabela.Senha = Convert.ToString(txtSenha.Text);
                    objTabela.IdUsuario = Convert.ToInt32(txtId.Text);
                    //Método para atualizar usuario
                    int x = cont.AtuSenha(objTabela);
                    //Verificando se deu certo
                    if (x > 0)
                    {
                        MessageBox.Show("Usuário: " + txtUsuario.Text + ", atualizado com sucesso!");
                        //Atualizando o conteúdo da tela após a ação executada
                        frmLogin tela = new frmLogin();
                        tela.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro no sistema.\n\nTente novamente mais tarde!");
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não coincidem!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar. Erro: " + ex.Message);
            }
        }

        private void picVoltar_Click(object sender, EventArgs e)
        {
            frmLogin voltar = new frmLogin();
            voltar.Show();
            Close();
        }
    }
}

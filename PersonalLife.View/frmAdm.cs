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
    public partial class frmAdm : Form
    {
        public Form telaprincipal;
        public frmAdm()
        {
            InitializeComponent();
        }
        //Método para chamar tela de cadastro exercicio
        private void btnCadastrarExercicio_Click_1(object sender, EventArgs e)
        {
            frmCadExercicio cadE = new frmCadExercicio();
            cadE.Show();
            this.Hide();
        }
        //Método para chamar tela de listagem dos usuários
        private void btnListarExercicio_Click_1(object sender, EventArgs e)
        {
            frmListExercicio tela = new frmListExercicio();
            tela.Show();
            this.Hide();
        }
        //Método para chamar tela de listagem dos exercicios
        private void btnListarUsuarios_Click_1(object sender, EventArgs e)
        {
            frmListUsuario listar = new frmListUsuario();
            listar.Show();
            Close();
        }
        //Método para clicar na seta e voltar ao form anterior(frmLogin)
        private void picVoltar_Click(object sender, EventArgs e)
        {
            frmLogin voltar = new frmLogin();
            voltar.Show();
            Close();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Menu do Administrador \n\n\nClique no botão CADASTRAR EXERCÍCIO para cadastrar exercícios.\n\n\n" +
                "Clique no botão LISTAR EXERCÍCIO para ter acesso a todos os exercícios do sistema.\n\n\n" +
                "Clique no botão LISTAR USUÁRIO para ter acesso a todos os usuário do sistema.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShelf
{
    public partial class Tela_Cadastro : UserControl
    {
        public Tela_Cadastro()
        {
            InitializeComponent();
        }

        private Tela_princpal _formPrincipal;

        public Tela_Cadastro(Tela_princpal formPrincipal)
        {
            InitializeComponent();
            _formPrincipal = formPrincipal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void btn_cad_Click_1(object sender, EventArgs e)
        {
            try
            {
                Usuarios usuario = new Usuarios();
                usuario.Senha = txt_senha.Text;
                usuario.Email = txt_email.Text;
                usuario.Login = txt_login.Text;
                usuario.Nome = txt_nome.Text;

                if (!txt_nome.Text.Equals("") && !txt_senha.Text.Equals("") && !txt_email.Text.Equals("") && !txt_login.Text.Equals(""))
                {
                    bool cadastrado = usuario.CadastrarUser();
                    if (cadastrado)
                    {
                        txt_nome.Clear();
                        txt_senha.Clear();
                        txt_email.Clear();
                        txt_login.Clear();

                        Tela_BuscarLivro tela_buscarlivro = new Tela_BuscarLivro();
                        tela_buscarlivro.Show();

                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente!", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_nome.Clear();
                    txt_senha.Clear();
                    txt_email.Clear();
                    txt_login.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado na tela de cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tela_princpal formPrincipal = this.FindForm() as Tela_princpal;

            if (formPrincipal != null)
            {
                Tela_Login telaLogin = new Tela_Login();
                formPrincipal.CarregarUser(telaLogin);
            }
        }
    }
}

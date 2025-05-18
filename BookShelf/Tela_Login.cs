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
    public partial class Tela_Login : UserControl
    {
        public Tela_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios usuario = new Usuarios();
                usuario.Senha = txt_senha.Text;
                usuario.Login = txt_login.Text;

                if (!string.IsNullOrWhiteSpace(txt_login.Text) && !string.IsNullOrWhiteSpace(txt_senha.Text))
                {
                    bool logado = usuario.Logar();
                    if (logado)
                    {
                        Tela_BuscarLivro tela_buscarlivro = new Tela_BuscarLivro();
                        tela_buscarlivro.Show();

                        Tela_princpal formPrincipal = this.FindForm() as Tela_princpal;
                        if (formPrincipal != null)
                        {
                            formPrincipal.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Preencha corretamente os campos.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado na tela de login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tela_princpal formPrincipal = this.FindForm() as Tela_princpal;

            if (formPrincipal != null)
            {
                Tela_Cadastro telaCad = new Tela_Cadastro();
                formPrincipal.CarregarUser(telaCad);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Tela_princpal formPrincipal = this.FindForm() as Tela_princpal;

            if (formPrincipal != null)
            {
                Tela_recuperar telaRecuperar = new Tela_recuperar();
                formPrincipal.CarregarUser(telaRecuperar);
            }
        }
    }
}

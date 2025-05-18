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
    public partial class Tela_recuperar : UserControl
    {
        public Tela_recuperar()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Senha = txt_senha.Text;
            usuarios.Email = txt_email.Text;

            try
            {
                if (!string.IsNullOrWhiteSpace(txt_senha.Text) && !string.IsNullOrWhiteSpace(txt_email.Text))
                {
                    usuarios.Redefinir_senha(usuarios.Senha, usuarios.Email);
                    txt_email.Clear();
                    txt_senha.Clear();
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado ao tentar redefinir a senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tela_princpal formPrincipal = this.FindForm() as Tela_princpal;

            if (formPrincipal != null)
            {
                Tela_Login telalogin = new Tela_Login();
                formPrincipal.CarregarUser(telalogin);
            }
        }
    }
}

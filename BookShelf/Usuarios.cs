﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace BookShelf
{
    internal class Usuarios
    {
        private string nome;
        private string login;
        private string email;
        private string senha;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public bool CadastrarUser()
        {
            try
            {
                if (!verificarEmail(Email))
                {
                    MessageBox.Show("E-mail inválido. Digite um e-mail válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                string SenhaCriptografada = CriptografarSenha(Senha);

                using (MySqlConnection conexaoBanco = new BancoDb().Conectar())
                {
                    string inserir = "insert into usuarios (nome, login, email, senha) value (@nome, @login, @email, @senha)";

                    MySqlCommand comando = new MySqlCommand(inserir, conexaoBanco);
                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@login", Login);
                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@senha", SenhaCriptografada);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o usuário. Verifique os dados e tente novamente.", "Falha no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message, "Erro - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Redefinir_senha(string novasenha, string email)
        {
            try
            {
                using (MySqlConnection conexaoBanco = new BancoDb().Conectar())
                {
                    if (!verificarEmail(email))
                    {
                        MessageBox.Show("E-mail inválido. Digite um e-mail válido.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    string senhaCriptografada = CriptografarSenha(novasenha);

                    string alterar = "UPDATE usuarios SET senha = @senha WHERE email = @email;";

                    MySqlCommand comando = new MySqlCommand(alterar, conexaoBanco);
                    comando.Parameters.AddWithValue("@senha", senhaCriptografada);
                    comando.Parameters.AddWithValue("@email", email);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        MessageBox.Show("Senha redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma senha foi alterada. Verifique se o e-mail está correto.", "Falha na Redefinição", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar senha: " + ex.Message, "Erro - Redefinir Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Logar()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new BancoDb().Conectar())
                {
                    string senhacripto = CriptografarSenha(Senha);
                    string query = "SELECT COUNT(*) FROM usuarios WHERE login = @login AND senha = @senha";

                    MySqlCommand comando = new MySqlCommand(query, conexaoBanco);
                    comando.Parameters.AddWithValue("@login", Login);
                    comando.Parameters.AddWithValue("@senha", senhacripto);

                    int resultado = Convert.ToInt32(comando.ExecuteScalar());

                    if (resultado > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso. Bem-vindo!", "Login Efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretos. Tente novamente.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar login: " + ex.Message, "Erro - Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string CriptografarSenha(string senha)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha ?? ""));
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in bytes)
                        builder.Append(b.ToString("x2"));
                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criptografar a senha: " + ex.Message, "Erro - Método Criptografar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public static bool verificarEmail(string email)
        {
            string emailValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailValido);
            return regex.IsMatch(email);
        }

        public bool Verificar_se_User_existe()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new BancoDb().Conectar())
                {
                    string query = "SELECT COUNT(*) FROM usuarios";

                    MySqlCommand comando = new MySqlCommand(query, conexaoBanco);

                    int resultado = Convert.ToInt32(comando.ExecuteScalar());

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum usuário foi encontrado no sistema.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar usuários: " + ex.Message, "Erro - Verificação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}

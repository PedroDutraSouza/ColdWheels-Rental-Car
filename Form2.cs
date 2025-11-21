using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdWheels
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void aloneTextBox1_TextChanged(object sender, EventArgs e)
        {
            /*string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (email == "" || senha == "")
            {
                MessageBox.Show("Preencha e-mail e senha.");
                return;
            }

            try
            {
                using var conn = Db.GetConnection();

                string sql = @"SELECT id_usuario, senha, tipo, id_referencia, cargo
                           FROM usuarios 
                           WHERE email = @email";

                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", email);

                using var reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Usuário não encontrado.");
                    return;
                }

                string senhaBanco = reader.GetString("senha");

                if (senha != senhaBanco)
                {
                    MessageBox.Show("Senha incorreta.");
                    return;
                }

                // Preenche sessão
                Sessao.IdUsuario = reader.GetInt32("id_usuario");
                Sessao.Tipo = reader.GetString("tipo");
                Sessao.IdReferencia = reader.GetInt32("id_referencia");
                Sessao.Cargo = reader["cargo"] == DBNull.Value ? null : reader.GetString("cargo");

                if (Sessao.IsCliente)
                {
                   // var telaCli = new Form3();
                   // telaCli.Show();
                   // this.Hide();
                }
                else if (Sessao.IsFuncionario)
                {
                    var tela = new Form1();
                    tela.Show();
                    this.Hide();

                    if (Sessao.IsGerente)
                    {
                        var tel = new Form1();
                        tel.Show();
                        this.Hide();
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }*/
        }

        private void parrotForm1_WorkingArea_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (email == "" || senha == "")
            {
                MessageBox.Show("Preencha e-mail e senha.");
                return;
            }

            try
            {
                using var conn = Db.GetConnection();

                string sql = @"SELECT id_usuario, senha, tipo, id_referencia, cargo
                           FROM usuarios 
                           WHERE email = @email";

                using var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", email);

                using var reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Usuário não encontrado.");
                    return;
                }

                string senhaBanco = reader.GetString("senha");

                if (senha != senhaBanco)
                {
                    MessageBox.Show("Senha incorreta.");
                    return;
                }

                // Preenche sessão
                Sessao.IdUsuario = reader.GetInt32("id_usuario");
                Sessao.Tipo = reader.GetString("tipo");
                Sessao.IdReferencia = reader.GetInt32("id_referencia");
                Sessao.Cargo = reader["cargo"] == DBNull.Value ? null : reader.GetString("cargo");

                if (Sessao.IsCliente)
                {
                    // var telaCli = new Form3();
                    // telaCli.Show();
                    // this.Hide();
                }
                if (Sessao.IsFuncionario)
                {
                    var tela = new Form1();
                    tela.Show();
                    this.Hide();
                }

                if (Sessao.IsGerente)
                {
                        var tel = new Form1();
                        tel.Show();
                        this.Hide();
                }

                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}

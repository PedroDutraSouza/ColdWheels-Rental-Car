using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdWheels.Dados
{
    internal class CadastroC
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Habilitacao { get; set; }
        public string Senha { get; set; }

        string conexao = "Server=localhost;Database=coldwheels;Uid=root;";

        public void CadastrarCliente()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string sql = "INSERT INTO clientes (nome, cpf, email, telefone, habilitacao, senha) VALUES (@nome, @cpf, @email, @telefone, @habilitacao, @senha)";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@cpf", CPF);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@telefone", Telefone);
                    cmd.Parameters.AddWithValue("@habilitacao", Habilitacao);
                    cmd.Parameters.AddWithValue("@senha", Senha);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir Cliente: " + ex.Message);
            }
        }

        public void EditarCliente()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    string sql = "UPDATE clientes SET nome=@nome, cpf=@cpf, email=@email, telefone=@telefone, habilitacao=@habilitacao, senha=@senha WHERE id_cliente=@id_cliente";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id_cliente", IdCliente);
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@cpf", CPF);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@telefone", Telefone);
                    cmd.Parameters.AddWithValue("@habilitacao", Habilitacao);
                    cmd.Parameters.AddWithValue("@senha", Senha);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente atualizado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar: " + ex.Message);
            }
        }
        public void Excluir()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string sql = "DELETE FROM clientes WHERE id_cliente = @id_cliente";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id_cliente", IdCliente);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Veiculo excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir professor:\n" + ex.Message);
            }
        }


    }
}

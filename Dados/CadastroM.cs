using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdWheels.Dados
{
    internal class CadastroM
    {
        public int IdMulta { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; }
        public int IdReserva { get; set; }

        string conexao = "Server=localhost;Database=coldwheels;Uid=root;";
        public void Excluir()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string sql = "DELETE FROM multa WHERE id_multa = @id_multa";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id_multa", IdMulta);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Multa excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir professor:\n" + ex.Message);
            }
        }
        public void EditarMulta()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    string sql = "UPDATE multa SET valor=@valor, descricao=@descricao WHERE id_multa=@id_multa";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id_multa", IdMulta);
                    cmd.Parameters.AddWithValue("@valor", Valor);
                    cmd.Parameters.AddWithValue("@descricao", Descricao);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Multa atualizado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar: " + ex.Message);
            }
        }
        public void CadastrarMulta()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string sql = "INSERT INTO multa (valor, descricao, id_reserva) VALUES (@valor, @descricao, @id_reserva)";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@valor", Valor);
                    cmd.Parameters.AddWithValue("@descricao", Descricao);
                    cmd.Parameters.AddWithValue("@id_reserva", IdReserva);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir Cliente: " + ex.Message);
            }
        }



    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ColdWheels.Dados
{
    public class CadastroR
    {
        public int IdReserva { get; set; }
        public DateTime DataFim { get; set; }
        public DateTime DataInicio { get; set; }
        public string Status { get; set; }
        public int IdCliente { get; set; }
        public int IdVeiculo { get; set; }

        string conexao = "Server=localhost;Database=coldwheels;Uid=root;";

        public void CadastrarReserva()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string sql = "INSERT INTO reservas (id_cliente, id_veiculo, status, data_inicio, data_fim) VALUES (@idCliente, @idVeiculo, @status, @inicio, @fim)";


                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idCliente", IdCliente);
                    cmd.Parameters.AddWithValue("@idVeiculo", IdVeiculo);
                    cmd.Parameters.AddWithValue("@status", Status);
                    cmd.Parameters.AddWithValue("@inicio", DataInicio);
                    cmd.Parameters.AddWithValue("@fim", DataFim);
                    

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Cliente cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir Cliente: " + ex.Message);
            }
        }
        public void ExcluirLocacao()
        {

            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string sql = "UPDATE reservas SET status = @status, updated_at = NOW() WHERE id_reserva = @id_reserva";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@status", "Cancelada");
                    cmd.Parameters.AddWithValue("@id_reserva", IdReserva); // o ID da reserva que você quer cancelar

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Reserva cancelada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cancelar reserva:\n" + ex.Message);
            }

        }

        public void EditarLocacao()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    string sql = "UPDATE reservas SET data_inicio=@data_inicio, data_fim=@data_fim, status=@status WHERE id_reserva=@id_reserva";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id_reserva", IdReserva);
                    cmd.Parameters.AddWithValue("@data_inicio", DataInicio);
                    cmd.Parameters.AddWithValue("@data_fim", DataFim);
                    cmd.Parameters.AddWithValue("status", Status);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Locação atualizado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar: " + ex.Message);
            }
        }

    }
}

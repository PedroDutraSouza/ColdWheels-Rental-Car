using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdWheels.Dados
{
    public class CadastroV
    {
        public int IdVeiculo { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }
        public string Placa { get; set; }
        public string KmAtual { get; set; }
        public string IdCategoria { get; set; }
        public string Diaria { get; set; }

        string conexao = "Server=localhost;Database=coldwheels;Uid=root;";

        public void CadastrarVeiculo()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    string sql = "INSERT INTO veiculos (modelo, marca, ano, placa, km_Atual, categoria, diaria) VALUES (@modelo, @marca, @ano, @placa, @km_Atual, @categoria, @diaria)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@modelo", Modelo);
                    cmd.Parameters.AddWithValue("@marca", Marca);
                    cmd.Parameters.AddWithValue("@ano", Ano);
                    cmd.Parameters.AddWithValue("@placa", Placa);
                    cmd.Parameters.AddWithValue("@km_Atual", KmAtual);
                    cmd.Parameters.AddWithValue("@categoria", IdCategoria);
                    cmd.Parameters.AddWithValue("@diaria", Diaria);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Veiculo cadastrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message);
            }
        }
        public void Excluir()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open();

                    string sql = "DELETE FROM veiculos WHERE id_veiculo = @id_veiculo";

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id_veiculo", IdVeiculo);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Veiculo excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir professor:\n" + ex.Message);
            }
        }


        public void EditarVeiculo()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    string sql = "UPDATE veiculos SET modelo=@modelo, marca=@marca, ano=@ano, placa=@placa, km_atual=@km_atual, categoria=@categoria WHERE id_veiculo=@id_veiculo";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id_veiculo", IdVeiculo);
                    cmd.Parameters.AddWithValue("@modelo", Modelo);
                    cmd.Parameters.AddWithValue("@marca", Marca);
                    cmd.Parameters.AddWithValue("@ano", Ano);
                    cmd.Parameters.AddWithValue("@placa", Placa);
                    cmd.Parameters.AddWithValue("@km_Atual", KmAtual);
                    cmd.Parameters.AddWithValue("@categoria", IdCategoria);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Veiculo atualizado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar: " + ex.Message);
            }
        }

    }
}

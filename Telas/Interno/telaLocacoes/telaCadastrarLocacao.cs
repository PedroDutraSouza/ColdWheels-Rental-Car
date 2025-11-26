using ColdWheels.Dados;
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

namespace ColdWheels.Telas.Interno.telaLocacoes
{
    public partial class telaCadastrarLocacao : UserControl
    {
        public telaCadastrarLocacao()
        {
            InitializeComponent();
            CarregarTabela1();
            CarregarTabela2();
        }

        private void telaCadastrarLocacao_Load(object sender, EventArgs e)
        {

        }


        private void CarregarTabela1()
        {
            try
            {
                string conexao = "Server=localhost;Database=coldwheels;Uid=root;";
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    string sql = "SELECT * FROM clientes";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvClientes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela: " + ex.Message);
            }
        }
        private void CarregarTabela2()
        {
            try
            {
                string conexao = "Server=localhost;Database=coldwheels;Uid=root;";
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    string sql = "SELECT * FROM veiculos";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvVeiculos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela: " + ex.Message);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                string conexao = "Server=localhost;Database=coldwheels;Uid=root;";

                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    con.Open(); 

                    string sqlClientes = "SELECT * FROM clientes WHERE nome LIKE @nomeBusca";

                    using (MySqlCommand cmdClientes = new MySqlCommand(sqlClientes, con))
                    {
                        cmdClientes.Parameters.AddWithValue("@nomeBusca", "%" + txtPequisaCliente.Text + "%");

                        MySqlDataAdapter daClientes = new MySqlDataAdapter(cmdClientes);
                        DataTable dtClientes = new DataTable();
                        daClientes.Fill(dtClientes);

                        dgvClientes.DataSource = dtClientes;
                    }

 
                    string sqlVeiculos = "SELECT * FROM veiculos WHERE modelo LIKE @modeloBusca";

                    using (MySqlCommand cmdVeiculos = new MySqlCommand(sqlVeiculos, con))
                    {
                        cmdVeiculos.Parameters.AddWithValue("@modeloBusca", "%" + txtPesquisarVeiculo.Text + "%");

                        MySqlDataAdapter daVeiculos = new MySqlDataAdapter(cmdVeiculos);
                        DataTable dtVeiculos = new DataTable();
                        daVeiculos.Fill(dtVeiculos);

                        dgvVeiculos.DataSource = dtVeiculos;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a pesquisa: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroR reservas = new CadastroR();
            reservas.IdCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["id_cliente"].Value);
            reservas.IdVeiculo = Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["id_veiculo"].Value);
            reservas.Status = "ativa";
            reservas.DataInicio = dataInicio.Value;
            reservas.DataFim = dataFim.Value;
            reservas.CadastrarReserva();
        }

        private void txtPequisaCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

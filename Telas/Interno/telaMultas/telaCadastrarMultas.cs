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

namespace ColdWheels.Telas.Interno.telaMultas
{
    public partial class telaCadastrarMultas : UserControl
    {
        public telaCadastrarMultas()
        {
            InitializeComponent();
            CarregarTabela();
        }
        private void CarregarTabela()
        {
            try
            {
                string conexao = "Server=localhost;Database=coldwheels;Uid=root;";
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    string sql = "SELECT\r\n  r.id_reserva AS 'ID Reserva', c.nome AS 'Nome Cliente',\r\n    v.marca AS 'Marca',\r\n    v.modelo AS 'Modelo',\r\n    v.placa AS 'Placa',\r\n    v.categoria AS 'Categoria',\r\n    r.status AS 'Status',\r\n    r.data_inicio AS 'Inicio',\r\n    r.data_fim AS 'Fim'\r\nFROM\r\n    clientes AS c\r\nINNER JOIN\r\n    reservas AS r ON c.id_cliente = r.id_cliente\r\nINNER JOIN\r\n    veiculos AS v ON r.id_veiculo = v.id_veiculo;";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLançarMulta.DataSource = dt;
                    dgvLançarMulta.Columns["ID Reserva"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela: " + ex.Message);
            }
        }

        private void aloneTextBox13_Enter(object sender, EventArgs e)
        {
            txtValor.Text = string.Empty;
        }

        private void aloneTextBox17_Enter(object sender, EventArgs e)
        {
            txtDescricao.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvLançarMulta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma reserva.");
                return;
            }
            CadastroM aluno = new CadastroM();
            aluno.IdReserva = Convert.ToInt32(dgvLançarMulta.CurrentRow.Cells["ID RESERVA"].Value);
            aluno.Valor = txtValor.Text;
            aluno.Descricao = txtDescricao.Text;
            aluno.CadastrarMulta();
            CarregarTabela();
        }

    }
}

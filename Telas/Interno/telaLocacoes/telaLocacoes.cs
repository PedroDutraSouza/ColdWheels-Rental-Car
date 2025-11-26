using ColdWheels.Telas.Interno.telaLocacoes;
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
using ColdWheels.Dados;

namespace ColdWheels
{
    public partial class telaLocacoes : UserControl
    {
        public telaLocacoes()
        {
            InitializeComponent();
            CarregarTabela();
        }
        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Form1.Instance.TrocarTela(new telaCadastrarLocacao());
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            Form1.Instance.TrocarTela(new telaEditarLocacao());
        }
        private void CarregarTabela()
        {
            try
            {
                string conexao = "Server=localhost;Database=coldwheels;Uid=root;";
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    string sql = "SELECT\r\n    r.id_reserva AS 'ID Reserva',\r\n    c.nome AS 'Nome Cliente',\r\n    v.marca AS 'Marca',\r\n    v.modelo AS 'Modelo',\r\n    v.placa AS 'Placa',\r\n    v.categoria AS 'Categoria',\r\n    r.status AS 'Status',\r\n    r.data_inicio AS 'Inicio',\r\n    r.data_fim AS 'Fim',\r\n    -- NOVAS COLUNAS DE CÁLCULO\r\n    v.diaria AS 'Diária',\r\n    DATEDIFF(r.data_fim, r.data_inicio) AS 'Total Dias',\r\n    DATEDIFF(r.data_fim, r.data_inicio) * v.diaria AS 'Valor Total Calculado'\r\nFROM\r\n    clientes AS c\r\nINNER JOIN\r\n    reservas AS r ON c.id_cliente = r.id_cliente\r\nINNER JOIN\r\n    veiculos AS v ON r.id_veiculo = v.id_veiculo;";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLocacoes.DataSource = dt;
                    dgvLocacoes.Columns["ID Reserva"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvLocacoes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma reserva!");
                return;
            }
            CadastroR Reserva = new CadastroR();
            Reserva.IdReserva = Convert.ToInt32(dgvLocacoes.CurrentRow.Cells["ID Reserva"].Value);
            Reserva.ExcluirLocacao();
            CarregarTabela();
        }

    }
}

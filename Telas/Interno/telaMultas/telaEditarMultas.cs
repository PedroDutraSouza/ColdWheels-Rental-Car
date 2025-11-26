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
    public partial class telaEditarMultas : UserControl
    {
        public telaEditarMultas()
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
                    string sql = "SELECT \r\n    m.id_multa,\r\n   r.id_reserva,\r\n    v.marca AS 'Marca Veículo',\r\n    v.modelo AS 'Modelo Veículo',\r\n    v.categoria AS 'Categoria',\r\n    v.placa AS 'Placa Veículo',\r\n    c.nome AS 'Nome Cliente',\r\n    m.valor AS 'Valor Multa',\r\n    m.descricao AS 'Descrição Multa'\r\nFROM \r\n    multa AS m\r\nINNER JOIN \r\n    reservas AS r ON m.id_reserva = r.id_reserva\r\nINNER JOIN \r\n    veiculos AS v ON r.id_veiculo = v.id_veiculo\r\nINNER JOIN \r\n    clientes AS c ON r.id_cliente = c.id_cliente;";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMultas.DataSource = dt;
                    dgvMultas.Columns["id_multa"].Visible = false;
                    dgvMultas.Columns["id_reserva"].Visible = false;
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
            if (dgvMultas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma Multa!");
                return;
            }
            CadastroM aluno = new CadastroM();
            aluno.IdMulta = Convert.ToInt32(dgvMultas.CurrentRow.Cells["id_multa"].Value);
            aluno.Valor = txtValor.Text;
            aluno.Descricao = txtDescricao.Text;


            aluno.EditarMulta();
            CarregarTabela();
        }

    }
}

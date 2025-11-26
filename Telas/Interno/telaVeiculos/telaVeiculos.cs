using ColdWheels.Dados;
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

namespace ColdWheels
{
    public partial class telaVeiculos : UserControl
    {
        public telaVeiculos()
        {
            InitializeComponent();
            ConfigurarPermissoes();
            CarregarTabela();
            
        }

        private void ConfigurarPermissoes()
        { 
            if (Sessao.IsGerente)
            {
                containerExcluirVeiculos.Visible = true;

            }

        }

        private void CarregarTabela()
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
                    dgvVeiculos.Columns["id_veiculo"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela: " + ex.Message);
            }
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Form1.Instance.TrocarTela(new telaCadastroVeiculos());
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            Form1.Instance.TrocarTela(new telaEditarVeiculos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvVeiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um veiculo para excluir.");
                return;
            }

            CadastroV aluno = new CadastroV();
            aluno.IdVeiculo = Convert.ToInt32(dgvVeiculos.CurrentRow.Cells["id_veiculo"].Value);
            aluno.Excluir();

            CarregarTabela();
        }

    }
}

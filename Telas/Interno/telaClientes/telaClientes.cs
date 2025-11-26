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

namespace ColdWheels
{
    public partial class telaClientes : UserControl
    {
        public telaClientes()
        {
            InitializeComponent();
            ConfigurarPermissoes();
            CarregarTabela();

        }

        private void ConfigurarPermissoes()
        {

            if (Sessao.IsGerente)
            {
                containerExcluirCliente.Visible = true;
                

            }

        }

        private void CarregarTabela()
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
                    dgvCliente.DataSource = dt;
                    dgvCliente.Columns["id_cliente"].Visible = false;
                    dgvCliente.Columns["data_nascimento"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela: " + ex.Message);
            }
        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        } 

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            Form1.Instance.TrocarTela(new telaEditarClientes());

        }

        public void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Form1.Instance.TrocarTela(new telaCadastroClientes());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente para excluir.");
                return;
            }

            CadastroC aluno = new CadastroC();
            aluno.IdCliente = Convert.ToInt32(dgvCliente.CurrentRow.Cells["id_cliente"].Value);
            aluno.Excluir();

            CarregarTabela();
        }

    }
}

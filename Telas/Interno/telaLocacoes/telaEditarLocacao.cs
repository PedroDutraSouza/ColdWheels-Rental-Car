using ColdWheels.Dados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdWheels.Telas.Interno.telaLocacoes
{
    public partial class telaEditarLocacao : UserControl
    {
        public telaEditarLocacao()
        {
            InitializeComponent();
            CarregarTabela();
            PreencherComboBoxComEnumDoBanco();
        }
        private void CarregarTabela()
        {
            try
            {
                string conexao = "Server=localhost;Database=coldwheels;Uid=root;";
                using (MySqlConnection con = new MySqlConnection(conexao))
                {
                    string sql = "SELECT\r\n   r.id_reserva AS 'ID Locação', c.nome AS 'Nome Cliente',\r\n    v.marca AS 'Marca',\r\n    v.modelo AS 'Modelo',\r\n    v.placa AS 'Placa',\r\n    v.categoria AS 'Categoria',\r\n    r.status AS 'Status',\r\n    r.data_inicio AS 'Inicio',\r\n    r.data_fim AS 'Fim'\r\nFROM\r\n    clientes AS c\r\nINNER JOIN\r\n    reservas AS r ON c.id_cliente = r.id_cliente\r\nINNER JOIN\r\n    veiculos AS v ON r.id_veiculo = v.id_veiculo;";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEditarLocação.DataSource = dt;
                    dgvEditarLocação.Columns["ID Locação"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela: " + ex.Message);
            }
        }
        private void PreencherComboBoxComEnumDoBanco()
        {
            // Altere para o nome do seu controle ComboBox
            ComboBox cmb = this.Combo;

            string nomeTabela = "reservas";
            string nomeColuna = "status";

            // ⚠️ ATENÇÃO: Substitua pelos seus dados de conexão!
            string connectionString = "Server=localhost;Database=coldwheels;Uid=root;";

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    // Consulta ao INFORMATION_SCHEMA para obter a definição do tipo ENUM
                    string sql = $@"
         SELECT COLUMN_TYPE
         FROM INFORMATION_SCHEMA.COLUMNS
         WHERE TABLE_SCHEMA = '{conexao.Database}'
           AND TABLE_NAME = '{nomeTabela}'
           AND COLUMN_NAME = '{nomeColuna}';
     ";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        // O resultado é uma string como: "enum('SUV','Compacto','Sedan','Economico')"
                        string enumDefinition = resultado.ToString();

                        // Expressão regular para encontrar todos os valores entre aspas simples ('...')
                        // O padrão @""'([^']+)'"" captura o texto dentro das aspas.
                        MatchCollection matches = Regex.Matches(enumDefinition, @"'([^']+)'");

                        // Limpa o ComboBox antes de adicionar novos itens
                        cmb.Items.Clear();
                        cmb.Items.Add("Selecione uma status"); // Adiciona um item padrão

                        // Adiciona cada valor ENUM encontrado ao ComboBox
                        foreach (Match match in matches)
                        {
                            // O valor do enum está no Group 1 (dentro das aspas)
                            string enumValue = match.Groups[1].Value;
                            cmb.Items.Add(enumValue);
                        }

                        // Define o item padrão como selecionado
                        cmb.SelectedIndex = 0;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro de conexão ou SQL: " + ex.Message, "Erro no Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvEditarLocação.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma locação!");
                return;
            }
            CadastroR alun = new CadastroR();
            alun.IdReserva = Convert.ToInt32(dgvEditarLocação.CurrentRow.Cells["ID Locação"].Value);
            alun.DataInicio = dataInicio.Value;
            alun.DataFim = dataFim.Value;
            alun.Status = Combo.Text;

            alun.EditarLocacao();
            CarregarTabela();
        }

    }
}

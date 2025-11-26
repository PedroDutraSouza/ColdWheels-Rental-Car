using ColdWheels.Dados;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdWheels
{
    public partial class telaEditarVeiculos : UserControl
    {
        public telaEditarVeiculos()
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
                    string sql = "SELECT * FROM veiculos";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEditVeiculos.DataSource = dt;
                    dgvEditVeiculos.Columns["id_veiculo"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvEditVeiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma reserva!");
                return;
            }
            CadastroV alun = new CadastroV();
            alun.IdVeiculo = Convert.ToInt32(dgvEditVeiculos.CurrentRow.Cells["id_veiculo"].Value);
            alun.Marca = txtMarca.Text;
            alun.Modelo = txtModelo.Text;
            alun.Placa = txtPlaca.Text;
            alun.Ano =  txtAno.Text;
            alun.KmAtual = txtKm.Text;
            alun.IdCategoria = Combo.Text;
            alun.EditarVeiculo();
            CarregarTabela();
        }

        private void PreencherComboBoxComEnumDoBanco()
        {
            // Altere para o nome do seu controle ComboBox
            ComboBox cmb = this.Combo;

            string nomeTabela = "veiculos";
            string nomeColuna = "categoria";

            // ⚠ ATENÇÃO: Substitua pelos seus dados de conexão!
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
                        cmb.Items.Add("Selecione uma categoria"); // Adiciona um item padrão

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

        private void txtModelo_Enter(object sender, EventArgs e)
        {
            txtModelo.Text = string.Empty;
        }

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            txtMarca.Text = string.Empty;
        }

        private void txtPlaca_Enter(object sender, EventArgs e)
        {
            txtPlaca.Text = string.Empty;
        }

        private void txtAno_Enter(object sender, EventArgs e)
        {
            txtAno.Text = string.Empty;
        }

        private void txtKm_Enter(object sender, EventArgs e)
        {
            txtKm.Text = string.Empty;
        }
    }
}

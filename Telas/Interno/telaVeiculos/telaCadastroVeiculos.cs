using ColdWheels.Dados;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdWheels
{
    public partial class telaCadastroVeiculos : UserControl
    {
        public telaCadastroVeiculos()
        {
            InitializeComponent();
            PreencherComboBoxComEnumDoBanco();
        }

        private void PreencherComboBoxComEnumDoBanco()
        {
            // Altere para o nome do seu controle ComboBox
            ComboBox cmb = this.Combo;

            string nomeTabela = "veiculos";
            string nomeColuna = "categoria";

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

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroV veiculo = new CadastroV();
            veiculo.Marca = marcaVeiculo.Text;
            veiculo.Modelo = modeloVeiculo.Text;
            veiculo.Placa = placaVeiculo.Text;
            veiculo.Ano = anoVeiculo.Text;
            veiculo.KmAtual = KmAtualVeiculo.Text;
            veiculo.IdCategoria = Combo.Text;
            veiculo.Diaria = diariaVeiculo.Text;

            veiculo.CadastrarVeiculo();
            marcaVeiculo.Text = null;
            modeloVeiculo.Text = null;
            placaVeiculo.Text = null;
            anoVeiculo.Text = null;
            KmAtualVeiculo.Text = null;
            diariaVeiculo.Text = null;
        }

        private void marcaVeiculo_Enter(object sender, EventArgs e)
        {
            marcaVeiculo.Text = null;
        }

        private void modeloVeiculo_Enter(object sender, EventArgs e)
        {
            modeloVeiculo.Text = null;
        }

        private void placaVeiculo_Enter(object sender, EventArgs e)
        {
            placaVeiculo.Text = null;
        }

        private void anoVeiculo_Enter(object sender, EventArgs e)
        {
            anoVeiculo.Text = null;
        }

        private void KmAtualVeiculo_Enter(object sender, EventArgs e)
        {
            KmAtualVeiculo.Text = null;
        }

        private void diariaVeiculo_Enter(object sender, EventArgs e)
        {
            diariaVeiculo.Text = string.Empty;
        }
    }
}

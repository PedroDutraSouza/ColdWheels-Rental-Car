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
    public partial class telaEditarClientes : UserControl
    {
        public telaEditarClientes()
        {
            InitializeComponent();
            CarregarTabela();
        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void crownLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string DDI;
            string DDD;
            string telefone;
            DDI = txtDDI.Text;
            DDD = txtDDD.Text;
            telefone = txtTelefone.Text;
            string numeroParaDb = $"{DDI}{DDD}{telefone}";

            if (dgvEditCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma reserva!");
                return;
            }
            CadastroC aluno = new CadastroC();
            aluno.IdCliente = Convert.ToInt32(dgvEditCliente.CurrentRow.Cells["id_cliente"].Value);
            aluno.Nome = txtNome.Text;
            aluno.Habilitacao = txtCNH.Text;
            aluno.CPF = txtCpf.Text;
            aluno.Email = txtEmail.Text;
            aluno.Senha = txtSenha.Text;
            aluno.Telefone = numeroParaDb;
            aluno.EditarCliente();
            CarregarTabela();

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
                    dgvEditCliente.DataSource = dt;
                    dgvEditCliente.Columns["id_cliente"].Visible = false;
                    dgvEditCliente.Columns["data_nascimento"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar tabela: " + ex.Message);
            }
        }
        
        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
        }

        private void txtCpf_Enter(object sender, EventArgs e)
        {
            txtCpf.Text = string.Empty;
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            txtTelefone.Text = string.Empty;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
        }

        private void aloneTextBox9_Enter(object sender, EventArgs e)
        {
            aloneTextBox9.Text = string.Empty;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = string.Empty;
        }

        private void aloneTextBox11_Enter(object sender, EventArgs e)
        {
            aloneTextBox11.Text = string.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.ImageLocation != "C://Users//pedro//Downloads//ColdWheels - Coso git de erro//ColdWheels - Coso git de erro//Recursos//Imagens//visibility_24dp_000000_FILL0_wght400_GRAD0_opsz24.png")
            {
                string caminho = "C://Users//pedro//Downloads//ColdWheels - Coso git de erro//ColdWheels - Coso git de erro//Recursos//Imagens//visibility_24dp_000000_FILL0_wght400_GRAD0_opsz24.png";
                txtSenha.UseSystemPasswordChar = false;
                pictureBox1.ImageLocation = caminho;
            }
            else
            {
                string caminho = "C://Users//pedro//Downloads//ColdWheels - Coso git de erro//ColdWheels - Coso git de erro//Recursos//Imagens//visibility_off_24dp_000000_FILL0_wght400_GRAD0_opsz24.png";
                txtSenha.UseSystemPasswordChar = true;
                pictureBox1.ImageLocation = caminho;
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.ImageLocation != "C://Users//pedro//Downloads//ColdWheels - Coso git de erro//ColdWheels - Coso git de erro//Recursos//Imagens//visibility_24dp_000000_FILL0_wght400_GRAD0_opsz24.png")
            {
                string caminho = "C://Users//pedro//Downloads//ColdWheels - Coso git de erro//ColdWheels - Coso git de erro//Recursos//Imagens//visibility_24dp_000000_FILL0_wght400_GRAD0_opsz24.png";
                aloneTextBox11.UseSystemPasswordChar = false;
                pictureBox2.ImageLocation = caminho;
            }
            else
            {
                string caminho = "C://Users//pedro//Downloads//ColdWheels - Coso git de erro//ColdWheels - Coso git de erro//Recursos//Imagens//visibility_off_24dp_000000_FILL0_wght400_GRAD0_opsz24.png";
                aloneTextBox11.UseSystemPasswordChar = true;
                pictureBox2.ImageLocation = caminho;
            }
        }
    }
}

using ColdWheels.Dados;
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
    public partial class telaCadastroClientes : UserControl
    {
        public telaCadastroClientes()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == txtConEmail.Text && txtSenha.Text == txtConSenha.Text)
            {
                string DDI;
                string DDD;
                string telefone;
                DDI = txtDDI.Text.Trim();
                DDD = txtDDD.Text.Trim();
                telefone = txtTelefone.Text.Trim();

                string numeroParaDb = $"{DDI}{DDD}{telefone}";
                CadastroC aluno = new CadastroC();
                aluno.Nome = txtNome.Text;
                aluno.CPF = txtCPF.Text;
                aluno.Email = txtEmail.Text;
                aluno.Telefone = numeroParaDb;
                aluno.Habilitacao = txtCNH.Text;
                aluno.Senha = txtSenha.Text;

                aluno.CadastrarCliente();
            }
            else
            {
                MessageBox.Show("Informe email e senhas iguais!");
                return;
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtNome.Text = null;
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            txtCPF.Text = null;
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            txtTelefone.Text = null;
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.Text = null;
        }

        private void txtConEmail_Enter(object sender, EventArgs e)
        {
            txtConEmail.Text = null;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.Text = null;
        }

        private void txtConSenha_Enter(object sender, EventArgs e)
        {
            txtConSenha.Text = null;
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
                txtConSenha.UseSystemPasswordChar = false;
                pictureBox2.ImageLocation = caminho;
            }
            else
            {
                string caminho = "C://Users//pedro//Downloads//ColdWheels - Coso git de erro//ColdWheels - Coso git de erro//Recursos//Imagens//visibility_off_24dp_000000_FILL0_wght400_GRAD0_opsz24.png";
                txtConSenha.UseSystemPasswordChar = true;
                pictureBox2.ImageLocation = caminho;
            }
        }
    }
}

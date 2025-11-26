using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ColdWheels
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        bool abrirBarra;
        public Form1()
        {
            InitializeComponent();
            TrocarTela(new telaHome());
            Instance = this;
            ConfigurarPermissoes();
            
        }
        private void ConfigurarPermissoes()
        {
         
            if (Sessao.IsGerente)
            {
                containerDashboard.Visible = true;
                panel10.Visible = false;
            }
        }

        public void TrocarTela(UserControl novaTela)
        {
            // Como estou no Form1, eu tenho acesso ao painelConteudo
            carregarSubTelas.Carregar(this.pnlContent, novaTela);
        }

        

        private void parrotBatteryPercentage1_Tick(object sender, EventArgs e)
        {

        }

        private void parrotButton1_Click(object sender, EventArgs e)
        {

        }

        private void parrotButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = metroButton2.HoverColor;
        }

        private void metroButton2_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox2.BackColor = metroButton2.NormalColor;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = metroButton2.NormalColor;
        }

       

        private void metroButton2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = metroButton2.HoverColor;
            pictureBox1.BackColor = metroButton2.NormalColor;
            pictureBox3.BackColor = metroButton2.NormalColor;
            pictureBox4.BackColor = metroButton2.NormalColor;
            pictureBox5.BackColor = metroButton2.NormalColor;
            pictureBox4.BackColor = metroButton2.NormalColor;
            pictureBox6.BackColor = metroButton2.NormalColor;
            barraSeletora.Visible = true;
            barraSeletora2.Visible = false;
            barraSeletora3.Visible = false;
            barraSeletora4.Visible = false;
            barraSeletora6.Visible = false;
            barraSeletora5.Visible = false;
            TrocarTela(new telaVeiculos());
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = metroButton1.HoverColor;
            pictureBox2.BackColor = metroButton2.NormalColor;
            pictureBox3.BackColor = metroButton2.NormalColor;
            pictureBox4.BackColor = metroButton2.NormalColor;
            pictureBox5.BackColor = metroButton2.NormalColor;
            pictureBox4.BackColor = metroButton2.NormalColor;
            pictureBox6.BackColor = metroButton2.NormalColor;
            barraSeletora2.Visible = true;
            barraSeletora.Visible = false;
            barraSeletora3.Visible = false;
            barraSeletora4.Visible = false;
            barraSeletora6.Visible = false;
            barraSeletora5.Visible = false;
            TrocarTela(new telaClientes());
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = metroButton3.HoverColor;
            pictureBox1.BackColor = metroButton2.NormalColor;
            pictureBox2.BackColor = metroButton2.NormalColor;
            pictureBox4.BackColor = metroButton2.NormalColor;
            pictureBox5.BackColor = metroButton2.NormalColor;
            pictureBox4.BackColor = metroButton2.NormalColor;
            pictureBox6.BackColor = metroButton2.NormalColor;
            barraSeletora3.Visible = true;
            barraSeletora.Visible = false;
            barraSeletora2.Visible = false;
            barraSeletora4.Visible = false;
            barraSeletora6.Visible = false;
            barraSeletora5.Visible = false;
            TrocarTela(new telaLocacoes());
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            pictureBox4.BackColor = metroButton4.HoverColor;
            pictureBox1.BackColor = metroButton2.NormalColor;
            pictureBox2.BackColor = metroButton2.NormalColor;
            pictureBox3.BackColor = metroButton2.NormalColor;
            pictureBox5.BackColor = metroButton2.NormalColor;
            pictureBox4.BackColor = metroButton2.NormalColor;
            pictureBox6.BackColor = metroButton2.NormalColor;
            barraSeletora4.Visible = true;
            barraSeletora.Visible = false;
            barraSeletora2.Visible = false;
            barraSeletora3.Visible = false;
            barraSeletora6.Visible = false;
            barraSeletora5.Visible = false;
            TrocarTela(new telaMultas());
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            pictureBox5.BackColor = metroButton2.HoverColor;
            pictureBox4.BackColor = metroButton2.NormalColor;
            pictureBox1.BackColor = metroButton2.NormalColor;
            pictureBox2.BackColor = metroButton2.NormalColor;
            pictureBox3.BackColor = metroButton2.NormalColor;
            pictureBox6.BackColor = metroButton2.NormalColor;
            barraSeletora5.Visible = true;
            barraSeletora4.Visible = false;
            barraSeletora.Visible = false;
            barraSeletora2.Visible = false;
            barraSeletora3.Visible = false;
            barraSeletora6.Visible = false;
            TrocarTela(new telaContrato());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pictureBox6.BackColor = metroButton2.HoverColor;
            pictureBox5.BackColor = metroButton2.NormalColor;
            pictureBox4.BackColor = metroButton2.NormalColor;
            pictureBox1.BackColor = metroButton2.NormalColor;
            pictureBox2.BackColor = metroButton2.NormalColor;
            pictureBox3.BackColor = metroButton2.NormalColor;
            barraSeletora6.Visible = true;
            barraSeletora5.Visible = false;
            barraSeletora4.Visible = false;
            barraSeletora.Visible = false;
            barraSeletora2.Visible = false;
            barraSeletora3.Visible = false;
            pnlContent.Controls.Clear();
            TrocarTela(new telaHome());
            string url = "https://app.powerbi.com/groups/me/reports/463170ec-03c3-4e79-81d9-52d8d7cd6230/c09250772505535907ab?language=pt-BR&experience=power-bi";

            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o site: " + ex.Message);
            }
        }


        private void metroButton1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = metroButton1.HoverColor;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = metroButton1.NormalColor;
        }

        private void metroButton3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = metroButton3.HoverColor;
        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = metroButton3.NormalColor;
        }

        private void metroButton4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackColor = metroButton4.HoverColor;
        }

        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = metroButton4.NormalColor;
        }

        private void barraTimer_Tick(object sender, EventArgs e)
        {
            if (abrirBarra)
            {
                pgpBarra.Width -= 10;
                if (pgpBarra.Width == pgpBarra.MinimumSize.Width)
                {
                    abrirBarra = false;
                    barraTimer.Stop();
                }
            }
            else
            {
                pgpBarra.Width += 10;
                if (pgpBarra.Width == pgpBarra.MaximumSize.Width)
                {
                    abrirBarra = true;
                    barraTimer.Stop();
                }
            }
        }

        private void botaoMenu_Click(object sender, EventArgs e)
        {
            barraTimer.Start();
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            var tela = new Form2();
            tela.Show();
            this.Hide();
        }
    }
}

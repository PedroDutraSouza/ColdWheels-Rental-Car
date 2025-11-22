using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Instance = this;
            ConfigurarPermissoes();
        }
        private void ConfigurarPermissoes()
        {
         
            if (Sessao.IsGerente)
            {
                containerDashboard.Visible = true;
                containerRelatorio.Visible = true;
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
            barraSeletora.Visible = true;
            barraSeletora2.Visible = false;
            barraSeletora3.Visible = false;
            barraSeletora4.Visible = false;
            TrocarTela(new telaVeiculos());
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = metroButton2.HoverColor;
            pictureBox2.BackColor = metroButton2.NormalColor;
            pictureBox3.BackColor = metroButton2.NormalColor;
            pictureBox4.BackColor = metroButton2.NormalColor;
            barraSeletora2.Visible = true;
            barraSeletora.Visible = false;
            barraSeletora3.Visible = false;
            barraSeletora4.Visible = false;
            TrocarTela(new telaClientes());
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = metroButton2.HoverColor;
            pictureBox1.BackColor = metroButton2.NormalColor;
            pictureBox2.BackColor = metroButton2.NormalColor;
            pictureBox4.BackColor = metroButton2.NormalColor;
            barraSeletora3.Visible = true;
            barraSeletora.Visible = false;
            barraSeletora2.Visible = false;
            barraSeletora4.Visible = false;
            TrocarTela(new telaLocacoes());
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            pictureBox4.BackColor = metroButton2.HoverColor;
            pictureBox1.BackColor = metroButton2.NormalColor;
            pictureBox2.BackColor = metroButton2.NormalColor;
            pictureBox3.BackColor = metroButton2.NormalColor;
            barraSeletora4.Visible = true;
            barraSeletora.Visible = false;
            barraSeletora2.Visible = false;
            barraSeletora3.Visible = false;
            TrocarTela(new telaMultas());
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            pictureBox4.BackColor = metroButton2.HoverColor;
            pictureBox1.BackColor = metroButton2.NormalColor;
            pictureBox2.BackColor = metroButton2.NormalColor;
            pictureBox3.BackColor = metroButton2.NormalColor;
            barraSeletora4.Visible = true;
            barraSeletora.Visible = false;
            barraSeletora2.Visible = false;
            barraSeletora3.Visible = false;
            TrocarTela(new telaRelatorio());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pictureBox4.BackColor = metroButton2.HoverColor;
            pictureBox1.BackColor = metroButton2.NormalColor;
            pictureBox2.BackColor = metroButton2.NormalColor;
            pictureBox3.BackColor = metroButton2.NormalColor;
            barraSeletora4.Visible = true;
            barraSeletora.Visible = false;
            barraSeletora2.Visible = false;
            barraSeletora3.Visible = false;
            TrocarTela(new telaDashboard());
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
    }
}

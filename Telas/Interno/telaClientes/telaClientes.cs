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
        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void LoadUserControl(UserControl userControl)
        {
            // Limpa qualquer controlo que esteja atualmente no painel
            this.Controls.Clear();

            // Define o controlo para preencher todo o painel
            userControl.Dock = DockStyle.Fill;

            // Adiciona o novo controlo ao painel
            this.Controls.Add(userControl);
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            LoadUserControl(new telaEditarClientes());
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            LoadUserControl(new telaCadastroClientes());
        }
    }
}

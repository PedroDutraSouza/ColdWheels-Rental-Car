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

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            Form1.Instance.TrocarTela(new telaEditarClientes());
        }

        public void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Form1.Instance.TrocarTela(new telaCadastroClientes());
        }
    }
}

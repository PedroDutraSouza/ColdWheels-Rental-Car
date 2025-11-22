using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdWheels
{
    public static class carregarSubTelas
    {
        public static void Carregar(Panel painelPrincipal, UserControl novaTela)
        {
            if (painelPrincipal != null && novaTela != null)
            {
                painelPrincipal.Controls.Clear();
                novaTela.Dock = DockStyle.Fill;
                painelPrincipal.Controls.Add(novaTela);
            }
        }
    }
}

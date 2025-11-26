using PdfiumViewer;
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
    public partial class telaContrato : UserControl
    {
        public telaContrato()
        {
            InitializeComponent();
        }

        /*private void pdfRenderer1_Click(object sender, EventArgs e)
        {
            string caminho = "/Recursos/Contratos/modelo-de-contrato-de-aluguel-de-veiculo.pdf";

            // Abre o documento
            var pdfDocument = PdfDocument.Load(caminho);

            // Atribui ao visualizador
            pdfRenderer1.Document = pdfDocument;
        }*/

        private void pdfViewer1_Load(object sender, EventArgs e)
        {
            string caminho = "C://Users//pedro//OneDrive//Desktop//ColdWheels//ColdWheels - Malta//ColdWheels - Coso git de erro//Recursos//Contratos//modelo-de-contrato-de-aluguel-de-veiculo.pdf";

            // Abre o documento
            var pdfDocument = PdfDocument.Load(caminho);

            // Atribui ao visualizador
            pdfViewer1.Document = pdfDocument;
        }
    }
}

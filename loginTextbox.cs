using System;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class loginTextbox : UserControl
    {
        public loginTextbox()
        {
            InitializeComponent();
        }

        // --- Propriedade para o Texto do Label ---
        private string _labelText = "Label Padrão"; // Campo PRIVADO para guardar o valor

        [Category("Custom Properties")]
        public string LabelText // Propriedade PÚBLICA para aceder ao valor
        {
            get { return _labelText; } // Devolve o valor do campo privado
            set
            {
                _labelText = value; // Guarda o novo valor no campo privado
                label1.Text = value; // Atualiza o controlo visual
            }
        }

        // --- Propriedade para o Modo Senha ---
        private bool _isPassword = false; // Campo PRIVADO

        [Category("Custom Properties")]
        public bool IsPassword // Propriedade PÚBLICA
        {
            get { return _isPassword; } // Devolve o valor do campo privado
            set
            {
                _isPassword = value; // Guarda o novo valor no campo privado
                textBox.UseSystemPasswordChar = value; // Atualiza o controlo visual
            }
        }

        // --- Propriedade para obter o Texto Digitado ---
        [Category("Custom Properties")]
        public string InputText
        {
            get { return textBox.Text; } // Lê diretamente da textBox interna
            set { textBox.Text = value; } // Escreve diretamente na textBox interna
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginTextbox_Load(object sender, EventArgs e)
        {

        }
    }
}
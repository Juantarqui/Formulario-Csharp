using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        private Form3 nuevaVentana = null;

        public Form1()
        {
            InitializeComponent();


           
            BOTONPASAR.Enabled = false;

            TEXTNOMBRE.TextChanged += TEXTNOMBRE_TextChanged_1;
            TEXTCONTRASEÑA.TextChanged += TEXTCONTRASEÑA_TextChanged;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nuevaventana = new Form2(TEXTNOMBRE.Text,TEXTCONTRASEÑA.Text);
            
            nuevaventana.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TEXTNOMBRE_TextChanged_1(object sender, EventArgs e)
        {
            BOTONPASAR.Enabled = !String.IsNullOrWhiteSpace(TEXTNOMBRE.Text);
            VerificarCampos();
        }

        private void TEXTCONTRASEÑA_TextChanged(object sender, EventArgs e)
        {
            BOTONPASAR.Enabled = !String.IsNullOrWhiteSpace(TEXTCONTRASEÑA.Text);
            VerificarCampos();
        }

        private void VerificarCampos()
        {
            // Habilita el botón solo si los dos campos tienen texto
            BOTONPASAR.Enabled =
                !string.IsNullOrWhiteSpace(TEXTNOMBRE.Text) &&
                !string.IsNullOrWhiteSpace(TEXTCONTRASEÑA.Text);
        }

        private void registrase_Click(object sender, EventArgs e)
        {
                Form3 nuevaventana = new Form3();
                nuevaventana.Show();
        }
    }
}

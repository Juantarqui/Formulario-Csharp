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
    public partial class Form2 : Form
    {
        public Form2(string text, string text1)
        {
            InitializeComponent();
            Text = text;
            txtlaber.Text = text;
            Text = text1;
            TXTLABER2.Text = text1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

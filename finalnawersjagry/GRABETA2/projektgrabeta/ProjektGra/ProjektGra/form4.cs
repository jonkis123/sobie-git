using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektGra
{
    public partial class form4 : Form
    {
        public string PrzekazanaWartosc { get; set; }
        string kategoria1; string kategoria2;
        int odpowiedz=0;
        public form4(string a, string b)
        {
            InitializeComponent();
            textBox1.Text = a; textBox2.Text = b;
            kategoria1 = a; kategoria2 = b;
            
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odpowiedz = 1;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            odpowiedz = 2;
            Close();
        }

        private void form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(odpowiedz == 1) { PrzekazanaWartosc = kategoria1; }
            if(odpowiedz == 2) { PrzekazanaWartosc = kategoria2; }
                
            
        }
    }
}

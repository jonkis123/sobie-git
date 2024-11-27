using ProjektGra.Resources;
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
   
    public partial class Form1 : Form
    {
        
        int photoId = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.awantura;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Masz do dyspozyki 1 000 000 złotych, " + "\nMusisz odpowiedzieć na 8 pytań, \nKwota którą stawiasz na pytanie musi być podzielna przez 25 000  " + "\nW kratki obok odpowiedzi musisz wprowadzić kwotę dokladnie taką samą jaką posiadasz aktualnie ilość pieniędzy" + "\nPo wprowadzeniu stawek pytanie zatwierdzamy klikając na przycisk pytanie[1-8");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "") {
                String nickname = textBox1.Text;

                Form2 form = new Form2(photoId, nickname);
                this.Hide();
                form.ShowDialog();
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            photoId++;
            if(photoId == 1) { photoSet(photoId); }
            if(photoId == 2) { photoSet(photoId); }
            if(photoId == 3) { photoSet(photoId); }
            if(photoId == 4) { photoId = 1; photoSet(photoId); }

            

            
            

        }

       private void photoSet(int photoId)
        {
            this.photoId = photoId;
            switch (photoId)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.jonek; 
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.janek;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.stanek;
                    break;
                default:

                    break;
            }
        }

        
    }
}

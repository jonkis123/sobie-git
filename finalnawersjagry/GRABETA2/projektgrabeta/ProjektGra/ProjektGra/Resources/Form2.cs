using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektGra.Resources
{
    public partial class Form2 : Form
    {
        private Timer timer;
        int money = 1000000;
        int question = 0;
        string[] Question1;
        int odpowiedz;
        int moneyRightNow = 1000000;

        public Form2(int photo, string nickname)
        {
            InitializeComponent();
            photoSet(photo);
            textBox1.Text = nickname.ToString();
            textBox2.Text = "Łukasz Nowicki";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
           textBox3.Text = money.ToString();
            button1.Visible = false; button2.Visible = false; button3.Visible = false; button4.Visible = false; button5.Visible = false; button6.Visible = false; button7.Visible = false; button8.Visible = false;
        }
        private void photoSet(int photoId)
        {
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
        private int moneyLose(int answer)
        {
            int losedPrice = 0;
            if (answer == 1)
            {
                losedPrice = int.Parse((string)textBox10.Text) + int.Parse((string)textBox11.Text) + int.Parse((string)textBox12.Text);
            }
            if (answer == 2)
            {
                losedPrice = int.Parse((string)textBox9.Text) + int.Parse((string)textBox11.Text) + int.Parse((string)textBox12.Text);
            }
            if (answer == 3)
            {
                losedPrice = int.Parse((string)textBox9.Text) + int.Parse((string)textBox10.Text) + int.Parse((string)textBox12.Text);
            }
            if (answer == 4)
            {
                losedPrice = int.Parse((string)textBox9.Text) + int.Parse((string)textBox10.Text) + int.Parse((string)textBox11.Text);
            }
            return losedPrice;
        }
        private void chechIsplayerLost()
        {
            if (moneyRightNow <= 0)
            {
                MessageBox.Show("Przegrales");
                this.Close();
                Form1 form1 = new Form1();
                form1.Show();

            }
            else;
        }
        private void clearingTextBoxes()
        {
            textBox9.Text = "0"; textBox10.Text = "0"; textBox11.Text = "0"; textBox12.Text = "0";
            textBox4.Text = string.Empty; textBox5.Text = string.Empty; textBox6.Text = string.Empty; textBox7.Text = string.Empty; textBox8.Text = string.Empty;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            question++;
            
            if (question == 1) { questionButtonVisibility(question); }
            if (question == 2) { questionButtonVisibility(question); }
            if (question == 3) { questionButtonVisibility(question); }
            if (question == 4) { questionButtonVisibility(question); }
            if (question == 5) { questionButtonVisibility(question); }
            if (question == 6) { questionButtonVisibility(question); }
            if (question == 7) { questionButtonVisibility(question); }
            if (question == 8) { questionButtonVisibility(question); }

            button9.Visible = false;
            groupBox1.Visible = true;

            string fileDirecry = Environment.CurrentDirectory + "\\questions\\TextFile1.txt";
            StreamReader sr = new StreamReader(fileDirecry);
            String line;
            line = File.ReadAllText(fileDirecry);

            string[] Question1 = line.Split(';');

            string katergoria1 = Question1[1];
            string katergoria2 = Question1[2];



            form4 form4 = new form4(katergoria1, katergoria2);
            form4.ShowDialog();
            string wartoscZForm4 = form4.PrzekazanaWartosc;
            Console.Write(wartoscZForm4);
            if(wartoscZForm4 == katergoria1)
            {
                textBox4.Text = Question1[3];
                textBox5.Text = Question1[5];
                textBox6.Text = Question1[7];
                textBox7.Text = Question1[9];
                textBox8.Text = Question1[11];
                odpowiedz = int.Parse(Question1[0]);
                odpowiedz = odpowiedz / 10;
            }
            if (wartoscZForm4 == katergoria2)
            {
                textBox4.Text = Question1[4];
                textBox5.Text = Question1[6];
                textBox6.Text = Question1[8];
                textBox7.Text = Question1[10];
                textBox8.Text = Question1[12];
                odpowiedz = int.Parse(Question1[0]);
                odpowiedz = odpowiedz % 10;
            }


            Console.WriteLine(odpowiedz);
            


        }
        private void questionButtonVisibility(int question)
        {
            switch (question)
            {
                case 1:
                    button1.Visible = true;  button2.Visible = false; button3.Visible = false; button4.Visible = false; button5.Visible = false; button6.Visible = false; button7.Visible = false; button8.Visible = false;
                    break;
                case 2:
                    button1.Visible = false; button2.Visible = true; button3.Visible = false; button4.Visible = false; button5.Visible = false; button6.Visible = false; button7.Visible = false; button8.Visible = false;
                    break;
                case 3:
                    button1.Visible = false; button2.Visible = false; button3.Visible = true; button4.Visible = false; button5.Visible = false; button6.Visible = false; button7.Visible = false; button8.Visible = false;
                    break;
                case 4:
                    button1.Visible = false; button2.Visible = false; button3.Visible = false; button4.Visible = true; button5.Visible = false; button6.Visible = false; button7.Visible = false; button8.Visible = false;
                    break;
                case 5:
                    button1.Visible = false; button2.Visible = false; button3.Visible = false; button4.Visible = false; button5.Visible = true; button6.Visible = false; button7.Visible = false; button8.Visible = false;
                    break;
                case 6:
                    button1.Visible = false; button2.Visible = false; button3.Visible = false; button4.Visible = false; button5.Visible = false; button6.Visible = true; button7.Visible = false; button8.Visible = false;
                    break;
                case 7:
                    button1.Visible = false; button2.Visible = false; button3.Visible = false; button4.Visible = false; button5.Visible = false; button6.Visible = false; button7.Visible = true; button8.Visible = false;
                    break;
                case 8:
                    button1.Visible = false; button2.Visible = false; button3.Visible = false; button4.Visible = false; button5.Visible = false; button6.Visible = false; button7.Visible = false; button8.Visible = true;
                    break;
            }   
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == string.Empty)
            {
                textBox9.BackColor = Color.White;
            }
            else
            {
                int Value = int.Parse(textBox9.Text);
                chechIsValueDivide(Value, textBox9);
            }                    
        }
        private void chechIsValueDivide(int Value, TextBox tb)
        { 
                if (Value % 25000 != 0)
                {
                    tb.BackColor = Color.Red;
                }
                else
                {
                    tb.BackColor = Color.White;
                }
        }
        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumerInput(e);                       
        }
        private void onlyNumerInput(KeyPressEventArgs e) {
            
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == string.Empty)
            {
                textBox10.BackColor = Color.White;
            }
            else
            {
                int Value = int.Parse(textBox10.Text);
                chechIsValueDivide(Value, textBox10);
            }
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text == string.Empty)
            {
                textBox11.BackColor = Color.White;
            }
            else
            {
                int Value = int.Parse(textBox11.Text);
                chechIsValueDivide(Value, textBox11);
            }
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text == string.Empty)
            {
                textBox12.BackColor = Color.White;
            }
            else
            {
                int Value = int.Parse(textBox12.Text); 
                chechIsValueDivide(Value, textBox12);
            }
        }
        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumerInput(e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumerInput(e);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumerInput(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            int betsAgregate;
            

            betsAgregate = int.Parse((string)textBox9.Text) + int.Parse((string)textBox10.Text) + int.Parse((string)textBox11.Text) + int.Parse((string)textBox12.Text);
            if (betsAgregate > 1000000 || betsAgregate < moneyRightNow ) { MessageBox.Show("Wprowadzono za małą lub za dużą kwotę"); }
            else
            {
                int moneyLosed = moneyLose(odpowiedz);
                Console.WriteLine(moneyLosed);

               

                int NewMoneyValue = betsAgregate - moneyLosed;

                clearingTextBoxes();
                moneyRightNow = NewMoneyValue;
                textBox3.Text = moneyRightNow.ToString();
                button1.Hide();
                button2.Show();

                string fileDirecry = Environment.CurrentDirectory + "\\questions\\TextFile2.txt";
                StreamReader sr = new StreamReader(fileDirecry);
                String line;
                line = File.ReadAllText(fileDirecry);

                string[] Question1 = line.Split(';');

                string katergoria1 = Question1[1];
                string katergoria2 = Question1[2];



                form4 form4 = new form4(katergoria1, katergoria2);
                form4.ShowDialog();
                string wartoscZForm4 = form4.PrzekazanaWartosc;
                Console.Write(wartoscZForm4);
                if (wartoscZForm4 == katergoria1)
                {
                    textBox4.Text = Question1[3];
                    textBox5.Text = Question1[5];
                    textBox6.Text = Question1[7];
                    textBox7.Text = Question1[9];
                    textBox8.Text = Question1[11];
                    odpowiedz = int.Parse(Question1[0]);
                    odpowiedz = odpowiedz / 10;
                }
                if (wartoscZForm4 == katergoria2)
                {
                    textBox4.Text = Question1[4];
                    textBox5.Text = Question1[6];
                    textBox6.Text = Question1[8];
                    textBox7.Text = Question1[10];
                    textBox8.Text = Question1[12];
                    odpowiedz = int.Parse(Question1[0]);
                    odpowiedz = odpowiedz % 10;
                }

            }

            
            
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (moneyRightNow <= 0)
            {
                chechIsplayerLost();
            }
            else
            {



                int betsAgregate;

                betsAgregate = int.Parse((string)textBox9.Text) + int.Parse((string)textBox10.Text) + int.Parse((string)textBox11.Text) + int.Parse((string)textBox12.Text);
                if (betsAgregate > 1000000 || betsAgregate < moneyRightNow) { MessageBox.Show("Wprowadzono za małą lub za dużą kwotę"); }
                else
                {
                    int moneyLosed = moneyLose(odpowiedz);
                    Console.WriteLine(moneyLosed);



                    int NewMoneyValue = betsAgregate - moneyLosed;

                    clearingTextBoxes();
                    moneyRightNow = NewMoneyValue;
                    textBox3.Text = moneyRightNow.ToString();
                    button2.Hide();
                    button3.Show();

                    string fileDirecry = Environment.CurrentDirectory + "\\questions\\TextFile3.txt";
                    StreamReader sr = new StreamReader(fileDirecry);
                    String line;
                    line = File.ReadAllText(fileDirecry);

                    string[] Question1 = line.Split(';');

                    string katergoria1 = Question1[1];
                    string katergoria2 = Question1[2];



                    form4 form4 = new form4(katergoria1, katergoria2);
                    form4.ShowDialog();
                    string wartoscZForm4 = form4.PrzekazanaWartosc;
                    Console.Write(wartoscZForm4);
                    if (wartoscZForm4 == katergoria1)
                    {
                        textBox4.Text = Question1[3];
                        textBox5.Text = Question1[5];
                        textBox6.Text = Question1[7];
                        textBox7.Text = Question1[9];
                        textBox8.Text = Question1[11];
                        odpowiedz = int.Parse(Question1[0]);
                        odpowiedz = odpowiedz / 10;
                    }
                    if (wartoscZForm4 == katergoria2)
                    {
                        textBox4.Text = Question1[4];
                        textBox5.Text = Question1[6];
                        textBox6.Text = Question1[8];
                        textBox7.Text = Question1[10];
                        textBox8.Text = Question1[12];
                        odpowiedz = int.Parse(Question1[0]);
                        odpowiedz = odpowiedz % 10;
                    }

                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (moneyRightNow <= 0)
            {
                chechIsplayerLost();
            }
            else
            {
                int betsAgregate;

                betsAgregate = int.Parse((string)textBox9.Text) + int.Parse((string)textBox10.Text) + int.Parse((string)textBox11.Text) + int.Parse((string)textBox12.Text);
                if (betsAgregate > 1000000 || betsAgregate < moneyRightNow) { MessageBox.Show("Wprowadzono za małą lub za dużą kwotę"); }
                else
                {
                    int moneyLosed = moneyLose(odpowiedz);
                    Console.WriteLine(moneyLosed);



                    int NewMoneyValue = betsAgregate - moneyLosed;

                    clearingTextBoxes();
                    moneyRightNow = NewMoneyValue;
                    textBox3.Text = moneyRightNow.ToString();
                    button3.Hide();
                    button4.Show();

                    string fileDirecry = Environment.CurrentDirectory + "\\questions\\TextFile4.txt";
                    StreamReader sr = new StreamReader(fileDirecry);
                    String line;
                    line = File.ReadAllText(fileDirecry);

                    string[] Question1 = line.Split(';');

                    string katergoria1 = Question1[1];
                    string katergoria2 = Question1[2];



                    form4 form4 = new form4(katergoria1, katergoria2);
                    form4.ShowDialog();
                    string wartoscZForm4 = form4.PrzekazanaWartosc;
                    Console.Write(wartoscZForm4);
                    if (wartoscZForm4 == katergoria1)
                    {
                        textBox4.Text = Question1[3];
                        textBox5.Text = Question1[5];
                        textBox6.Text = Question1[7];
                        textBox7.Text = Question1[9];
                        textBox8.Text = Question1[11];
                        odpowiedz = int.Parse(Question1[0]);
                        odpowiedz = odpowiedz / 10;
                    }
                    if (wartoscZForm4 == katergoria2)
                    {
                        textBox4.Text = Question1[4];
                        textBox5.Text = Question1[6];
                        textBox6.Text = Question1[8];
                        textBox7.Text = Question1[10];
                        textBox8.Text = Question1[12];
                        odpowiedz = int.Parse(Question1[0]);
                        odpowiedz = odpowiedz % 10;
                    }

                }
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (moneyRightNow <= 0)
            {
                chechIsplayerLost();
            }
            else
            {
                int betsAgregate;

                betsAgregate = int.Parse((string)textBox9.Text) + int.Parse((string)textBox10.Text) + int.Parse((string)textBox11.Text) + int.Parse((string)textBox12.Text);
                if (betsAgregate > 1000000 || betsAgregate < moneyRightNow) { MessageBox.Show("Wprowadzono za małą lub za dużą kwotę"); }
                else
                {
                    int moneyLosed = moneyLose(odpowiedz);
                    Console.WriteLine(moneyLosed);



                    int NewMoneyValue = betsAgregate - moneyLosed;

                    clearingTextBoxes();
                    moneyRightNow = NewMoneyValue;
                    textBox3.Text = moneyRightNow.ToString();
                    button4.Hide();
                    button5.Show();

                    string fileDirecry = Environment.CurrentDirectory + "\\questions\\TextFile5.txt";
                    StreamReader sr = new StreamReader(fileDirecry);
                    String line;
                    line = File.ReadAllText(fileDirecry);

                    string[] Question1 = line.Split(';');

                    string katergoria1 = Question1[1];
                    string katergoria2 = Question1[2];



                    form4 form4 = new form4(katergoria1, katergoria2);
                    form4.ShowDialog();
                    string wartoscZForm4 = form4.PrzekazanaWartosc;
                    Console.Write(wartoscZForm4);
                    if (wartoscZForm4 == katergoria1)
                    {
                        textBox4.Text = Question1[3];
                        textBox5.Text = Question1[5];
                        textBox6.Text = Question1[7];
                        textBox7.Text = Question1[9];
                        textBox8.Text = Question1[11];
                        odpowiedz = int.Parse(Question1[0]);
                        odpowiedz = odpowiedz / 10;
                    }
                    if (wartoscZForm4 == katergoria2)
                    {
                        textBox4.Text = Question1[4];
                        textBox5.Text = Question1[6];
                        textBox6.Text = Question1[8];
                        textBox7.Text = Question1[10];
                        textBox8.Text = Question1[12];
                        odpowiedz = int.Parse(Question1[0]);
                        odpowiedz = odpowiedz % 10;
                    }

                }
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (moneyRightNow <= 0)
            {
                chechIsplayerLost();
            }
            else
            {

                int betsAgregate;

                betsAgregate = int.Parse((string)textBox9.Text) + int.Parse((string)textBox10.Text) + int.Parse((string)textBox11.Text) + int.Parse((string)textBox12.Text);
                if (betsAgregate > 1000000 || betsAgregate < moneyRightNow) { MessageBox.Show("Wprowadzono za małą lub za dużą kwotę"); }
                else
                {
                    int moneyLosed = moneyLose(odpowiedz);
                    Console.WriteLine(moneyLosed);



                    int NewMoneyValue = betsAgregate - moneyLosed;

                    clearingTextBoxes();
                    moneyRightNow = NewMoneyValue;
                    textBox3.Text = moneyRightNow.ToString();
                    button5.Hide();
                    button6.Show();

                    string fileDirecry = Environment.CurrentDirectory + "\\questions\\TextFile6.txt";
                    StreamReader sr = new StreamReader(fileDirecry);
                    String line;
                    line = File.ReadAllText(fileDirecry);

                    string[] Question1 = line.Split(';');

                    string katergoria1 = Question1[1];
                    string katergoria2 = Question1[2];



                    form4 form4 = new form4(katergoria1, katergoria2);
                    form4.ShowDialog();
                    string wartoscZForm4 = form4.PrzekazanaWartosc;
                    Console.Write(wartoscZForm4);
                    if (wartoscZForm4 == katergoria1)
                    {
                        textBox4.Text = Question1[3];
                        textBox5.Text = Question1[5];
                        textBox6.Text = Question1[7];
                        textBox7.Text = Question1[9];
                        textBox8.Text = Question1[11];
                        odpowiedz = int.Parse(Question1[0]);
                        odpowiedz = odpowiedz / 10;
                    }
                    if (wartoscZForm4 == katergoria2)
                    {
                        textBox4.Text = Question1[4];
                        textBox5.Text = Question1[6];
                        textBox6.Text = Question1[8];
                        textBox7.Text = Question1[10];
                        textBox8.Text = Question1[12];
                        odpowiedz = int.Parse(Question1[0]);
                        odpowiedz = odpowiedz % 10;
                    }
                }
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (moneyRightNow <= 0)
            {
                chechIsplayerLost();
            }
            else
            {
                int betsAgregate;

                betsAgregate = int.Parse((string)textBox9.Text) + int.Parse((string)textBox10.Text) + int.Parse((string)textBox11.Text) + int.Parse((string)textBox12.Text);
                if (betsAgregate > 1000000 || betsAgregate < moneyRightNow) { MessageBox.Show("Wprowadzono za małą lub za dużą kwotę"); }
                else
                {
                    int moneyLosed = moneyLose(odpowiedz);
                    Console.WriteLine(moneyLosed);



                    int NewMoneyValue = betsAgregate - moneyLosed;

                    clearingTextBoxes();
                    moneyRightNow = NewMoneyValue;
                    textBox3.Text = moneyRightNow.ToString();
                    button6.Hide();
                    button7.Show();

                    string fileDirecry = Environment.CurrentDirectory + "\\questions\\TextFile7.txt";
                    StreamReader sr = new StreamReader(fileDirecry);
                    String line;
                    line = File.ReadAllText(fileDirecry);

                    string[] Question1 = line.Split(';');

                    string katergoria1 = Question1[1];
                    string katergoria2 = Question1[2];



                    form4 form4 = new form4(katergoria1, katergoria2);
                    form4.ShowDialog();
                    string wartoscZForm4 = form4.PrzekazanaWartosc;
                    Console.Write(wartoscZForm4);
                    if (wartoscZForm4 == katergoria1)
                    {
                        textBox4.Text = Question1[3];
                        textBox5.Text = Question1[5];
                        textBox6.Text = Question1[7];
                        textBox7.Text = Question1[9];
                        textBox8.Text = Question1[11];
                        odpowiedz = int.Parse(Question1[0]);
                        odpowiedz = odpowiedz / 10;
                    }
                    if (wartoscZForm4 == katergoria2)
                    {
                        textBox4.Text = Question1[4];
                        textBox5.Text = Question1[6];
                        textBox6.Text = Question1[8];
                        textBox7.Text = Question1[10];
                        textBox8.Text = Question1[12];
                        odpowiedz = int.Parse(Question1[0]);
                        odpowiedz = odpowiedz % 10;
                    }

                }
                
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (moneyRightNow <= 0)
            {
                chechIsplayerLost();
            }
            else
            {
                int betsAgregate;

                betsAgregate = int.Parse((string)textBox9.Text) + int.Parse((string)textBox10.Text) + int.Parse((string)textBox11.Text) + int.Parse((string)textBox12.Text);
                if (betsAgregate > 1000000 || betsAgregate < moneyRightNow) { MessageBox.Show("Wprowadzono za małą lub za dużą kwotę"); }
                else
                {
                    int moneyLosed = moneyLose(odpowiedz);
                    Console.WriteLine(moneyLosed);



                    int NewMoneyValue = betsAgregate - moneyLosed;

                    clearingTextBoxes();
                    moneyRightNow = NewMoneyValue;
                    textBox3.Text = moneyRightNow.ToString();
                    button7.Hide();
                    button8.Show();

                    string fileDirecry = Environment.CurrentDirectory + "\\questions\\TextFile8.txt";
                    StreamReader sr = new StreamReader(fileDirecry);
                    String line;
                    line = File.ReadAllText(fileDirecry);

                    string[] Question1 = line.Split(';');

                    string katergoria1 = Question1[1];
                    string katergoria2 = Question1[2];



                    form4 form4 = new form4(katergoria1, katergoria2);
                    form4.ShowDialog();
                    string wartoscZForm4 = form4.PrzekazanaWartosc;
                    Console.Write(wartoscZForm4);
                    if (wartoscZForm4 == katergoria1)
                    {
                        textBox4.Text = Question1[3];
                        textBox5.Text = Question1[5];
                        textBox6.Text = Question1[7];
                        textBox7.Text = Question1[9];
                        textBox8.Text = Question1[11];
                        odpowiedz = int.Parse(Question1[0]);
                        odpowiedz = odpowiedz / 10;
                    }
                    if (wartoscZForm4 == katergoria2)
                    {
                        textBox4.Text = Question1[4];
                        textBox5.Text = Question1[6];
                        textBox6.Text = Question1[8];
                        textBox7.Text = Question1[10];
                        textBox8.Text = Question1[12];
                        odpowiedz = int.Parse(Question1[0]);
                        odpowiedz = odpowiedz % 10;
                    }

                }
                
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (moneyRightNow <= 0)
            {
                chechIsplayerLost();
            }
            else
            {
                int betsAgregate;

                betsAgregate = int.Parse((string)textBox9.Text) + int.Parse((string)textBox10.Text) + int.Parse((string)textBox11.Text) + int.Parse((string)textBox12.Text);
                if (betsAgregate > 1000000 || betsAgregate < moneyRightNow) { MessageBox.Show("Wprowadzono za małą lub za dużą kwotę"); }
                if (betsAgregate == moneyRightNow)
                {
                    int moneyLosed = moneyLose(odpowiedz);
                    Console.WriteLine(moneyLosed);



                    int NewMoneyValue = betsAgregate - moneyLosed;

                    clearingTextBoxes();
                    moneyRightNow = NewMoneyValue;
                    textBox3.Text = moneyRightNow.ToString();
                    MessageBox.Show("WYGRAŁES!!!! " + moneyRightNow.ToString() + " ZŁ ");
                    this.Close();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
            }
        }
    }
}

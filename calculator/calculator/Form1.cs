using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double rezultat=0,nrCitit=0;
        int operatie = 0,cifra=1;
        string semn = "neinitializat";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Form1_Click(object sender, EventArgs e)
        {
            //cifre
            if (operatie == 1)
                textBox1.Text = "";
            cifra = 1;
            operatie = 0;
            Button btn1 = (Button)sender;
            textBox1.Text = textBox1.Text + btn1.Text;//resulted number
        }

        public void Form1_Click_1(object sender, EventArgs e)
        {
            //semne
            Button btn2 = (Button)sender;
            if(semn!="neinitializat")
            {
                                if(semn=="+")
                {
                    rezultat=rezultat + double.Parse(textBox1.Text);
                        textBox1.Text=rezultat.ToString();
                }
                                if(semn=="-")
                {
                    rezultat=rezultat - double.Parse(textBox1.Text);
                        textBox1.Text=rezultat.ToString();
                }
                                if(semn=="*")
                {
                    rezultat=rezultat*double.Parse(textBox1.Text);
                        textBox1.Text=rezultat.ToString();
                }
                                if(semn=="/")
                {
                    rezultat=rezultat/double.Parse(textBox1.Text);
                        textBox1.Text=rezultat.ToString();
                }
            }
            else
            {
                rezultat = double.Parse(textBox1.Text);

            }

            semn = btn2.Text;
            operatie = 1;
            cifra = 0;
        }

        public void button11_Click(object sender, EventArgs e)
        {
            //egal
            if(cifra==1)
            {
                if (semn == "+")
                    rezultat = rezultat + double.Parse(textBox1.Text);
                if (semn == "-")
                    rezultat = rezultat - double.Parse(textBox1.Text);
                if (semn == "*")
                    rezultat = rezultat * double.Parse(textBox1.Text);
                if (semn == "/")
                    rezultat = rezultat / double.Parse(textBox1.Text);
            }

             textBox1.Text = "";
             textBox1.Text = rezultat.ToString();

             operatie = 0;
             cifra = 0;

            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //sterge tot
            textBox1.Text = "";
            semn = "neinitializat";
            rezultat = 0;
            operatie = 0;
            cifra = 1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //sterge linie
            textBox1.Text = "";
        }
    }
}

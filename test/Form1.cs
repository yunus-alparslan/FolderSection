using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace test
{
    public partial class Form1 : Form
    {
        string[] dosyayolları = { ".txt", ".pdf", ".pptx" };

        

        public Form1()
        {
            InitializeComponent();
        }
        int tim = 0;
        StreamWriter streamx;
        string seçim;
        string dosyaismi, dosyayolu;
        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK){

                dosyayolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosyayolu;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dosyaismi = textBox2.Text;
            streamx = File.CreateText(dosyayolu + "\\"+dosyaismi + seçim);
            streamx.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            seçim=dosyayolları[0].ToString();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            seçim = dosyayolları[1].ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            seçim = dosyayolları[2].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            tim++;

            if (tim == 1)
            {
                this.BackColor = Color.Aquamarine;
            }
            else if (tim == 5)
            {
                this.BackColor = Color.Chartreuse;
            }
            else if (tim == 7)
            {
                this.BackColor = Color.DarkSalmon;
            }
            else if (tim == 9)
            {
                tim = 0;
                this.BackColor = Color.Chartreuse;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

    }
}

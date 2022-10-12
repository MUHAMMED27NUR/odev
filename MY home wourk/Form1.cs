using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            try
            {
                vize = Convert.ToDouble(numericUpDown1.Value);
                final = Convert.ToDouble(numericUpDown2.Value);
                ortalama = (vize * 0.4 + final * 0.6);
                label3.Text = "ortalama=" + ortalama.ToString();

                if (ortalama < 50 || final < 50)
                {
                    label4.Text = "kaldın";
                    label4.ForeColor = Color.Red;
                }
                else
                {
                    label4.Text = "geçtin";
                    label4.ForeColor = Color.Green;
                }
                if (ortalama < 100 && ortalama >= 90)
                {
                   label5.Text = "AA";
                }
                else if (ortalama < 90 && ortalama >= 80)
                {
                    label5.Text = "BA";
                }
                if (ortalama < 80 && ortalama >= 70)
                {
                    label5.Text = "BB";
                }
                if (ortalama < 70 && ortalama >= 60)
                {
                    label5.Text = "CB";
                }
                if (ortalama < 60 && ortalama >= 50)
                {
                    label5.Text = "CC";
                }
                if (ortalama < 50 && ortalama >= 0)
                {
                    label5.Text = "FF";
                }
            }
            catch (Exception EX)
            {
                throw;
            }
        }
    }
}
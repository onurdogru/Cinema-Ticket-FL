using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasaTutar = 0; //Global alanda tanımlamamız gereklidir
        private void button1_Click(object sender, EventArgs e)
        {

            int misir;
            int su;
            int cay;
            int bilet;
            int toplam;

            misir = Convert.ToInt16(textBox1.Text);
            su = Convert.ToInt16(textBox2.Text);
            cay = Convert.ToInt16(textBox3.Text);
            bilet = Convert.ToInt16(textBox4.Text);

            toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;
            lblToplam.Text = toplam.ToString() + "TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblToplam.Text = "0 TL";
        }
    }
}

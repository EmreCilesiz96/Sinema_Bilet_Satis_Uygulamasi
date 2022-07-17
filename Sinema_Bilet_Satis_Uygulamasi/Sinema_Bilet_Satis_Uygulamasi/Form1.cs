using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bilet_Satis_Uygulamasi
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        int kasatutar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int cay, su, misir, bilet, toplam;

            misir = Convert.ToInt16(TxtMisir.Text);
            cay = Convert.ToInt16(TxtCay.Text);
            su = Convert.ToInt16(TxtSu.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);


           toplam = misir * 4 + cay * 2 + su * 1 + bilet * 8;

            Lbltoplamtutar.Text = Convert.ToString(toplam) + "  ";

            kasatutar = toplam + kasatutar;

            Lblkasa.Text = Convert.ToString(kasatutar) + "  ";



        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lblkasa.Text = "00 TL";
            TxtBilet.Text = " ";
            TxtCay.Text = "";
            TxtMisir.Text = "";
            TxtSu.Text = "";
            Lbltoplamtutar.Text = "00 TL";



                }
    }
}

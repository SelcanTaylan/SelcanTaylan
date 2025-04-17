using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örnek1
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        private char islem;
        private bool ekran_temizle;
        private int ilk_sayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (ekran_temizle) lblSayi.Text = "";
            ekran_temizle = false;
            if (lblSayi.Text == "0") lblSayi.Text = "";
            lblSayi.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (ekran_temizle) lblSayi.Text = "";
            ekran_temizle = false;
            if (lblSayi.Text == "0") lblSayi.Text = "";
            lblSayi.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (ekran_temizle) lblSayi.Text = "";
            ekran_temizle = false;
            if (lblSayi.Text == "0") lblSayi.Text = "";
            lblSayi.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (ekran_temizle) lblSayi.Text = "";
            ekran_temizle = false;
            if (lblSayi.Text == "0") lblSayi.Text = "";
            lblSayi.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (ekran_temizle) lblSayi.Text = "";
            ekran_temizle = false;
            if (lblSayi.Text == "0") lblSayi.Text = "";
            lblSayi.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ekran_temizle) lblSayi.Text = "";
            ekran_temizle = false;
            if (lblSayi.Text == "0") lblSayi.Text = "";
            lblSayi.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (ekran_temizle) lblSayi.Text = "";
            ekran_temizle = false;
            if (lblSayi.Text == "0") lblSayi.Text = "";
            lblSayi.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (ekran_temizle) lblSayi.Text = "";
            ekran_temizle = false;
            if (lblSayi.Text == "0") lblSayi.Text = "";
            lblSayi.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (ekran_temizle) lblSayi.Text = "";
            ekran_temizle = false;
            if (lblSayi.Text == "0") lblSayi.Text = "";
            lblSayi.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (ekran_temizle) lblSayi.Text = "";
            ekran_temizle = false;
            if (lblSayi.Text == "0") lblSayi.Text = "";
            lblSayi.Text += "0";
        }

        private void btnArtı_Click(object sender, EventArgs e)
        {
            islem = '+';
            ekran_temizle = true;
            ilk_sayi = Convert.ToInt32(lblSayi.Text);


         
        
        }

        private void btnEşittir_Click(object sender, EventArgs e)
        {
            int ikinci_sayi = Convert.ToInt32(lblSayi.Text);
            int sonuc = 0;
            switch (islem)
            {
                case '+':
                    sonuc = ilk_sayi + ikinci_sayi; break;
                case '-':
                    sonuc = ilk_sayi - ikinci_sayi; break;
                case '*':
                    sonuc = ilk_sayi * ikinci_sayi; break;
                case '/':
                    sonuc = ilk_sayi / ikinci_sayi; break;
                default:
                    break;
            }
            lblSayi.Text = sonuc.ToString();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        private void btnEksi_Click(object sender, EventArgs e)
        {
            islem = '-';
            ekran_temizle = true;
            ilk_sayi = Convert.ToInt32(lblSayi.Text);

        }

        private void btnÇarpma_Click(object sender, EventArgs e)
        {
            islem = '*';
            ekran_temizle = true;
            ilk_sayi = Convert.ToInt32(lblSayi.Text);

        }

        private void btnBölme_Click(object sender, EventArgs e)
        {
            islem = '/';
            ekran_temizle = true;
            ilk_sayi = Convert.ToInt32(lblSayi.Text);
 
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblSayi.Text = "0";
        }
    }
}
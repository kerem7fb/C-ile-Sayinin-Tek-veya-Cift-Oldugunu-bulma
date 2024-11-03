using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TekÇiftSayı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, islem;
            sayi = Convert.ToInt32(textBox1.Text);
            islem = sayi % 2;
            if (islem == 0) 
            {
                MessageBox.Show(sayi + " Sayısı Çifttir");
            }
            if (islem == 1) 
            {
                MessageBox.Show(sayi + " Sayısı Tektir");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("http://www.teknosa.com/");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "TEKNOSA";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("http://www.n11.com/");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "n.11";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("http://www.hepsiburada.com/");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "Hepsi Burada";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("http://www.aliexpress.com/");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "Ali Express";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("http://www.gittigidiyor.com/");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "Gitti Gidiyor";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("https://www.trendyol.com");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "Trendyol";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("http://www.markafoni.com/");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "Markofoni";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("https://www.morhipo.com/");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "Morhibo";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("http://www.boyner.com.tr/");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "Boyner";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("https://www.ykm.com.tr/");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "Ykm.com.tr";
        }
    }
}

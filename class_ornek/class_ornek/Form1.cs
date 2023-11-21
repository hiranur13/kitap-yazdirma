using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book1=new Book();

            book1.türü = "Kurgu";
            book1.yazar = "Axie Oh";
            book1.adı ="XOXO";
            book1.sayfaSayısı = 296;
            book1.yayınevi = "Artemis Yayınları";
            book1.tipi = "Ciltli";

            label1.Text = book1.adı + " " + book1.sayfaSayısı + " " +
                book1.yazar + " " + book1.tipi + " " + book1.türü + " " + book1.yayınevi;
        }
    }
}

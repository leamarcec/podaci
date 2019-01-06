using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace podaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ispisButton_Click(object sender, EventArgs e)
        {
            string ime = imeTextBox.Text;
            string prezime = prezimeTextBox.Text;
            string adresa = adresaTextBox.Text;
            string posta = postaTextBox.Text;
            string drzava = drzavaTextBox.Text;
            string datumrodenja = datumrodenjaTextBox.Text;
            string oib = oibTextBox.Text;

            string ispis = ime + prezime + adresa + posta + drzava + datumrodenja + oib;
            ispisTextBox.Text = ispis;


        }
    }
}

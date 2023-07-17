using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winThePascaline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            try
            {
                float sayi1 = float.Parse(txtSayi1.Text);
                float sayi2 = float.Parse(txtSayi2.Text);

                float result = sayi1 + sayi2;
                MessageBox.Show(result.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Bir Hata Oluştu");
                throw;
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            try
            {
                float sayi1 = float.Parse(txtSayi1.Text);
                float sayi2 = float.Parse(txtSayi2.Text);

                float result = sayi1 - sayi2;
                MessageBox.Show(result.ToString());

            }
            catch (Exception)
            {
                Console.WriteLine("Bir hata oluştu");
                throw;
            }
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            try
            {

                float sayi1 = float.Parse(txtSayi1.Text);
                float sayi2 = float.Parse(txtSayi2.Text);

                float result = sayi1 * sayi2;
                MessageBox.Show(result.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Bir Hata Oluştu");
                throw;
            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            try
            {

                float sayi1 = float.Parse(txtSayi1.Text);
                float sayi2 = float.Parse(txtSayi2.Text);

                float result = sayi1 / sayi2;
                MessageBox.Show(result.ToString());
            }
            catch (Exception)
            {
                Console.WriteLine("Bir Hata oluştu");
                throw;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_for_Vize
{
    public partial class Form2 : Form
    {
        Dictionary<string,string> ogrenciBilgileri = new Dictionary<string,string>();   
        public Form2()
        {
            InitializeComponent();
        }

        private void OgrenciSistemeEkleButton_Click(object sender, EventArgs e)
        {
            string ogrenciAdi = ogrenciAdiTextBox.Text;
            string ogrenciSoyadi = ogrenciSoyadiTextBox.Text;
            string ogrenciNo = ogrenciNoTextBox.Text;

            ogrenciBilgileri[ogrenciNo] = ogrenciAdi + " " + ogrenciSoyadi;

            MessageBox.Show("! ! ! Öğrenci Başarıyla Kaydedildi ! ! !");

            ogrenciAdiTextBox.Clear();
            ogrenciSoyadiTextBox.Clear();
            ogrenciNoTextBox.Clear();

        }
    }
}

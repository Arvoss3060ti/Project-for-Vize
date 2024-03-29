using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_for_Vize
{
    public partial class Form2 : Form
    {
        private List<Ogrenci> ogrenciler;
        public Form2()
        {
            InitializeComponent();
        }

        private void OgrenciSistemeEkleButton_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.ogrenciAdi = ogrenciAdiTextBox.Text;
            ogrenci.ogrenciSoyAdi = ogrenciSoyadiTextBox.Text;
            ogrenci.ogrenciNo = ogrenciNoTextBox.Text;
            ogrenciler.Add(ogrenci);

            MessageBox.Show("! ! ! Öğrenci Başarıyla Kaydedildi ! ! !");

            ogrenciAdiTextBox.Clear();
            ogrenciSoyadiTextBox.Clear();
            ogrenciNoTextBox.Clear();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonSerializer.Serialize<List<Ogrenci>>(ogrenciler);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string dosya_yolu = dialog.FileName;
                File.WriteAllText(dosya_yolu, yazilacak, Encoding.UTF8);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                ogrenciler = JsonSerializer.Deserialize<List<Ogrenci>>(data);


        }
    }
}
}

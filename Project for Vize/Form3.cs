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
    public partial class Form3 : Form
    {
        private List<Kitap> kitaplar;
        public Form3()
        {
            InitializeComponent();
        }

        private void KitapKaydetButton_Click(object sender, EventArgs e)
        {
            Kitap kitap = new Kitap();
            kitap.kitapAdi = KitapAdiTextBox.Text;
            kitap.kitapYayinYili = YayinYiliTextBox.Text;
            kitap.kitapYayinevi = YayinEviTextBox.Text;
            kitap.KitapKodu = KitapKoduTextBox.Text;
            kitaplar.Add(kitap);

            MessageBox.Show("! ! ! Kitap Başarıyla Kaydedildi ! ! !");

            KitapAdiTextBox.Clear();
            YayinYiliTextBox.Clear();
            YayinEviTextBox.Clear();
            KitapKoduTextBox.Clear();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string yazilacak = JsonSerializer.Serialize<List<Kitap>>(kitaplar);

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
                kitaplar = JsonSerializer.Deserialize<List<Kitap>>(data);


            }
        }
    }
}
}

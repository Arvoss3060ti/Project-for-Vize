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
    public partial class Form3 : Form
    {
        Dictionary<string, string> kitapBilgileri = new Dictionary<string, string>();
        public Form3()
        {
            InitializeComponent();
        }

        private void KitapKaydetButton_Click(object sender, EventArgs e)
        {
            string kitapAdi = KitapAdiTextBox.Text;
            string kitapYayinYili = YayinYiliTextBox.Text;
            string kitapYayinEvi = YayinEviTextBox.Text;
            string kitapKodu = KitapKoduTextBox.Text;

            kitapBilgileri[kitapKodu] = kitapAdi + " " + kitapYayinYili + " " + kitapYayinEvi ;

            MessageBox.Show("! ! ! Kitap Başarıyla Kaydedildi ! ! !");

            KitapAdiTextBox.Clear();
            YayinYiliTextBox.Clear();
            YayinEviTextBox.Clear();
            KitapKoduTextBox.Clear();


        }
    }
}

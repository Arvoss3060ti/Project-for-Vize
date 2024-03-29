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
    public partial class Form7 : Form
    {
        private List<Emanet> emanetler;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Emanet emanet = new Emanet();
            emanet.EmanetTeslimTarihi = EmanetUyeNo.Text;
            emanet.EmanetKitapKodu = EmanetKitapKod.Text;
            emanet.EmanetUyeNo = EmanetUyeNo.Text;
            emanetler.Add(emanet);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonSerializer.Serialize<List<Emanet>>(emanetler);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string dosya_yolu = dialog.FileName;
                File.WriteAllText(dosya_yolu, yazilacak, Encoding.UTF8);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON Dosyasý|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                emanetler = JsonSerializer.Deserialize<List<Emanet>>(data);


            }
        }
    }
}

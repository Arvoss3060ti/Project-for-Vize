using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_Vize
{
    public class Kitap
    {
        private string kitap_adi;
        private string kitap_yayinyili;
        private string kitap_yayinevi;
        private string kitap_kodu;

        public string kitapAdi
        {
            get { return kitap_adi; }
            set { kitap_adi = value; }
        }

        public string kitapYayinYili
        {
            get { return kitap_yayinyili; }
            set { kitap_yayinyili = value; }
        }

        public string kitapYayinevi
        {
            get { return kitap_yayinevi; }
            set { kitap_yayinevi = value; }
        }

        public string KitapKodu
        {
            get { return kitap_kodu; }
            set { kitap_kodu = value; }
        }


    }
}

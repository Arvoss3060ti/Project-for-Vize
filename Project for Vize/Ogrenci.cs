using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_Vize
{
    public class Ogrenci
    {
        private string ogrenci_adi;
        private string ogrenci_soyadi;
        private string ogrenci_no;

        public string ogrenciNo
        { 
          get { return ogrenci_no;}
           set {  ogrenci_no = value; }  
        }

        public string ogrenciAdi
        {
           get { return ogrenci_adi; }
            set { ogrenci_adi = value;}
        }

        public string ogrenciSoyAdi
        {
            get { return ogrenci_soyadi;}
            set { ogrenci_soyadi = value;}
        }

    }
}

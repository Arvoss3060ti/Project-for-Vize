using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_for_Vize
{
    public class Emanet
    {
        private string emanet_TeslimTarihi;
        private string emanet_KitapKod;
        private string emanet_UyeNo;



        public string EmanetTeslimTarihi
        {
            get { return emanet_TeslimTarihi;  }
            set { emanet_TeslimTarihi = value; }
        }

        public string EmanetKitapKodu
        {
            get { return emanet_KitapKod; }
            set { emanet_KitapKod = value; }
        }
        public string EmanetUyeNo
        {
            get { return emanet_UyeNo; }
            set { emanet_UyeNo = value; }
        }


    }
}

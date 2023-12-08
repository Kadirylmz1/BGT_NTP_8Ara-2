using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGT_NTP_8Ara_2
{
    class Araba
    {
        public string marka;
        public string model;
        public int yil;
        public int gunlukUcret;
        public bool kiradaMi;

        public Araba(string Marka,string Model,int Yil, int Ucret,bool Kira)
        {
            this.marka = Marka;
            this.model = Model; 
            this.yil = Yil; 
            this.gunlukUcret = Ucret;
            this.kiradaMi = Kira;
        }


    }
}

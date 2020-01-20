using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2
{
    class Defans : Futbolcu
    {
        int Pozisyon;
        int kafa;
        int sicrama;

        Random rastgele = new Random();

        public int PozisyonAlma
        {
            get { return Pozisyon; }
            set { Pozisyon = value; }
        }
        public int Kafa
        {
            get { return kafa; }
            set { kafa = value; }
        }
        public int Sicrama
        {
            get { return sicrama; }
            set { sicrama = value; }
        }

        public Defans()
        {
            Hiz = rastgele.Next(50, 90);
            Dayaniklilik = rastgele.Next(50, 90);
            Pas = rastgele.Next(50, 90);
            Sut = rastgele.Next(50, 90);
            Yetenek = rastgele.Next(50, 90);
            Kararlilik = rastgele.Next(50, 90);
            DogalForm = rastgele.Next(50, 90);
            Sans = rastgele.Next(50, 90);
            Pozisyon = rastgele.Next(50, 90);
            Kafa = rastgele.Next(50, 90);
        }

        //Sadece Defans classı içerisindeki futbolculara özel PasVer metodu oluşturuldu.
        public override bool PasVer()
        {
            double PasSkor = Pas * 0.3 + Dayaniklilik * 0.1 + DogalForm * 0.1 + PozisyonAlma * 0.1 + Sans * 0.2;
            //Futbolcunun durumunun pas vermesi için yeterli olup olmadığı kontrol edilir.
            if (PasSkor >= 60)
                return true;
            else
                return false;
              
        }
        //Sadece Defans classı içerisindeki futbolculara özel GolVurusu metodu oluşturuldu.
        public override bool GolVurusu()
        {
            double GolSkor = Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + DogalForm * 0.1 + Kafa * 0.1 + Sicrama * 0.1 + Sans * 0.1;
            //Futbolcunun durumunun gol atması için yeterli olup olmadığı kontrol edilir.
            if (GolSkor >= 70)
                return true;
            else
                return false;
        }
    }
}

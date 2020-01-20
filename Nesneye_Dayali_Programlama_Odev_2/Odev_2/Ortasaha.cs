using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2
{
    class Ortasaha : Futbolcu
    {
        int uzuntop;
        int ilkdokunus;
        int uretkenlik;
        int topsurme;
        int ozelyetenek;

        Random rastgele = new Random();

        public int UzunTop
        {
            get { return uzuntop; }
            set { uzuntop = value; }
        }
        public int IlkDokunus
        {
            get { return ilkdokunus; }
            set { ilkdokunus = value; }
        }
        public int Uretkenlik
        {
            get { return uretkenlik; }
            set { uretkenlik = value; }
        }
        public int TopSurme
        {
            get { return topsurme; }
            set { topsurme = value; }
        }
        public int OzelYetenek
        {
            get { return ozelyetenek; }
            set { ozelyetenek = value; }
        }

        public Ortasaha()
        {
            Hiz = rastgele.Next(60, 100);
            Dayaniklilik = rastgele.Next(60, 100);
            Pas = rastgele.Next(60, 100);
            Sut = rastgele.Next(60, 100);
            Yetenek = rastgele.Next(60, 100);
            Kararlilik = rastgele.Next(60, 100);
            DogalForm = rastgele.Next(60, 100);
            Sans = rastgele.Next(60, 100);
            UzunTop = rastgele.Next(60, 100);
            IlkDokunus = rastgele.Next(60, 100);
            Uretkenlik = rastgele.Next(60, 100);
            TopSurme = rastgele.Next(60, 100);
            OzelYetenek = rastgele.Next(60, 100);

        }


        //Sadece Ortasaha classı içerisindeki futbolculara özel PasVer metodu oluşturuldu.
        public override bool PasVer()
        {
            double PasSkor = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklilik * 0.1 + DogalForm * 0.1 + UzunTop * 0.1 + TopSurme * 0.1 + Sans * 0.1;
            //Futbolcunun durumunun pas vermesi için yeterli olup olmadığı kontrol edilir.
            if (PasSkor >= 60)
                return true;
            else
                return false;
        }
        //Sadece Ortasaha classı içerisindeki futbolculara özel GolVurusu metodu oluşturuldu.
        public override bool GolVurusu()
        {
            double GolSkor = Yetenek * 0.3 + OzelYetenek * 0.2 + Sut * 0.2 + IlkDokunus * 0.1 + Kararlilik * 0.1 + DogalForm * 0.1 + Sans * 0.1;
            //Futbolcunun durumunun gol atması için yeterli olup olmadığı kontrol edilir.
            if (GolSkor >= 70)
                return true;
            else
                return false;
        }
    }
}

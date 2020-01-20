using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2
{
    class Forvet : Futbolcu
    {
        int bitiricilik;
        int ilkdokunus;
        int kafa;
        int ozelyetenek;
        int sogukkanlilik;

        Random rastgele = new Random();

        //istenilen değerlere ait propertyler oluşturuldu.
        
        public int Bitiricilik
        {
            get { return bitiricilik; }
            set { bitiricilik = value; }
        }
        public int IlkDokunus
        {
            get { return ilkdokunus; }
            set { ilkdokunus = value; }
        }
        public int Kafa
        {
            get { return kafa; }
            set { kafa = value; }
        }
        public int OzelYetenek
        {
            get { return ozelyetenek; }
            set { ozelyetenek = value; }
        }
        public int SogukKanlilik
        {
            get { return sogukkanlilik; }
            set { sogukkanlilik = value; }
        }

        //Forvet classına ait kurucu fonksiyon içerisinde her bir property değeri için rastgele değişken atandı.
        public Forvet()
        {
            Hiz = rastgele.Next(70, 100);
            Dayaniklilik = rastgele.Next(70, 100);
            Pas = rastgele.Next(70, 100);
            Sut = rastgele.Next(70, 100);
            Yetenek = rastgele.Next(70, 100);
            Kararlilik = rastgele.Next(70, 100);
            DogalForm = rastgele.Next(70, 100);
            Sans = rastgele.Next(70, 100);
            Bitiricilik = rastgele.Next(70, 100);
            IlkDokunus = rastgele.Next(70, 100);
            Kafa = rastgele.Next(70, 100);
            OzelYetenek = rastgele.Next(70, 100);
            SogukKanlilik = rastgele.Next(70, 100);
        }
        //Sadece Forvet classı içerisindeki futbolculara özel PasVer metodu oluşturuldu.
        public override bool PasVer()
        {
            double PasSkor = Pas * 0.3 + Yetenek * 0.2 + OzelYetenek * 0.2 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.1;
            //Futbolcunun durumunun pas vermesi için yeterli olup olmadığı kontrol edilir.
            if (PasSkor >= 60)
                return true;
            else
                return false;
        }
        //Sadece Forvet classı içerisindeki futbolculara özel GolVurusu metodu oluşturudu.
        public override bool GolVurusu()
        {
            double GolSkor = Yetenek * 0.2 + OzelYetenek * 0.2 + Sut * 0.1 + Kafa * 0.1 + IlkDokunus * 0.1 + Bitiricilik * 0.1 + SogukKanlilik * 0.1 + Kararlilik * 0.1 + DogalForm * 0.1 + Sans * 0.1;
            //Futbolcunun durumunun gol atması için yeterli olup olmadığı kontrol edilir.
            if (GolSkor >= 70)
                return true;
            else
                return false;
        }

    }
}

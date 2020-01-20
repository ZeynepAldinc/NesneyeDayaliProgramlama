using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2
{
    class Futbolcu
    {
        string adSoyad;
        int formaNo;
        int hiz;
        int dayaniklilik;
        int pas;
        int sut;
        int yetenek;
        int kararlilik;
        int dogalForm;
        int sans;

        Random rastgele = new Random();

        public string AdSoyad
        {
            get { return adSoyad; }
            set { adSoyad = value; }
        }
        public int FormaNo
        {
            get { return formaNo; }
            set { formaNo = value; }
        }
        public int Hiz
        {
            get { return hiz; }
            set { hiz = value; }
        }
        public int Dayaniklilik
        {
            get { return dayaniklilik; }
            set { dayaniklilik = value; }
        }
        public int Pas
        {
            get { return pas; }
            set { pas = value; }
        }
        public int Sut
        {
            get { return sut; }
            set { sut = value; }
        }
        public int Yetenek
        {
            get { return yetenek; }
            set { yetenek = value; }
        }
        public int Kararlilik
        {
            get { return kararlilik; }
            set { kararlilik = value; }
        }
        public int DogalForm
        {
            get { return dogalForm; }
            set { dogalForm = value; }
        }
        public int Sans
        {
            get { return sans; }
            set { sans = value; }
        }

        public Futbolcu()
        {
            Hiz = rastgele.Next(50, 100);
            Dayaniklilik = rastgele.Next(50, 100);
            Pas = rastgele.Next(50, 100);
            Sut = rastgele.Next(50, 100);
            Yetenek = rastgele.Next(50, 100);
            Kararlilik = rastgele.Next(50, 100);
            DogalForm = rastgele.Next(50, 100);
            Sans = rastgele.Next(50, 100);

        }
       
        
        //Asıl kalıtım veren Futbolcu classına ait pasver metodu oluşturuldu.
        public virtual bool PasVer()
        {
            double PasSkor = Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.2;
            //Futbolcunun durumunun pas vermesi için yeterli olup olmadığı kontrol edilir.
            if (PasSkor >= 60)
                return true;
            else
                return false;
        }
        //Asıl kalıtım veren Futbolcu classına ait golvuruşu metodu oluşturuldu.
        public virtual bool GolVurusu()
        {
            double GolSkor = Yetenek * 0.3 + Sut * 0.2 + Kararlilik * 0.1 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.2;
            //Futbolcunun durumunun gol atması için yeterli olup olmadığı kontrol edilir.
            if (GolSkor >= 70)
                return true;
            else
                return false;

        }



    }
}

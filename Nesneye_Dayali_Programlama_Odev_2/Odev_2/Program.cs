/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2
**				ÖĞRENCİ ADI............: Zeynep ALDİNÇ
**				ÖĞRENCİ NUMARASI.......: B181210390
**              DERSİN ALINDIĞI GRUP...: 1A
****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            //futbolcu isim ve numaralarını barındıracak futbolcu dizisi oluşturuldu.
            Futbolcu[] takim = new Futbolcu[11];
            //futbolcu isimleri ve numaraları diziye atandı.
            takim[0] = new Defans();  takim[0].AdSoyad = "Martin Linnes";      takim[0].FormaNo = 1;    
            takim[1] = new Defans();  takim[1].AdSoyad = "Semih Kaya";         takim[1].FormaNo = 2;     
            takim[2] = new Defans();  takim[2].AdSoyad = "Ryan Donk";          takim[2].FormaNo = 3;    
            takim[3] = new Defans();  takim[3].AdSoyad = "Yuto Nagamoto";      takim[3].FormaNo = 4;     

            takim[4] = new Ortasaha();  takim[4].AdSoyad = "Badou Ndiaye";       takim[4].FormaNo = 5;   
            takim[5] = new Ortasaha();  takim[5].AdSoyad = "Emre Akbaba";        takim[5].FormaNo = 6;   
            takim[6] = new Ortasaha();  takim[6].AdSoyad = "Sofiane Feghouli";   takim[6].FormaNo = 7;   
            takim[7] = new Ortasaha();  takim[7].AdSoyad = "Younes Belhanda";    takim[7].FormaNo = 8;   

            takim[8] = new Forvet();  takim[8].AdSoyad = "Henry Onyekuru";     takim[8].FormaNo = 9;     
            takim[9] = new Forvet();  takim[9].AdSoyad = "Mbaye Diagne";       takim[9].FormaNo = 10;

            //pasın başarılı ve başarısız olma durumuna göre Gol Vuruşu fonksiyonunun çalışmasını kontrol edecek bir bool değer oluşturuldu.
            bool GolOlabilir = true;

            //aynı kişinin kendisine pas vermesini önleyecek koşulda kullanılmak üzere önceki değeri saklaması için önceki değer isimli bir değişken oluşturuldu.
            int OncekiDeger = 0;
 
            // 3 kez pas atılmasını sağlayacak for dögüsü oluşturuldu. 
            for (int i = 0; i < 3; i++)
            {

                //Rastgele bir forma numarası seçilerek pas verecek oyuncu belirlendi.
                int formaNo = rastgele.Next(0, 9);
               
                //kişinin kendisine pas vermesini önlemek için önceki oyuncuyla şimdi seçilen oyuncunun aynı olup olmadığı kontrol edildi.
                //eğer aynıysa yeni bir rastgele değer belirlendi.
                if(formaNo==OncekiDeger)
                {
                   formaNo = rastgele.Next(0, 9);
                }
                
                
                //oyuncunun PasVer metodundaki PasSkor değeri pas vermesine uygunsa pas vermesini sağlayacak koşul oluşturuldu.
                if (takim[formaNo].PasVer())
                {
                    Console.WriteLine(takim[formaNo].FormaNo + " numaralı " + takim[formaNo].AdSoyad + " tarafından başarılı pas");
                    //pas veren oyuncunun forma numarası önceki değere eşitlendi.
                    OncekiDeger = formaNo;
                   
                }
                else
                {
                    //pas verme başarısız olduğu için GolVurusu metodunun çalışmamasını sağlamak amacıyla GolOlabilir bool değeri false yapıldı.
                    GolOlabilir = false;
                    Console.WriteLine(takim[formaNo].FormaNo + " numaralı " + takim[formaNo].AdSoyad + " tarafından gelen pas başarısız");
                    //pas veren oyuncunun forma numarası önceki değere eşitlendi.
                    OncekiDeger = formaNo;
                    break;

                }

                
                
               
            }
           //bool GolOlabilir değerinin for döngüsünden true olarak çıkıp çıkmamasına bağlı olarak çalışacak if koşulu hazırlandı.
            if(GolOlabilir)
            {
                //Rastgele bir forma numarası seçilerek gol atacak oyuncu belirlendi.
                int FormaNo = rastgele.Next(0, 9);
                //en son pas veren oyuncunun gol atacak oyuncuyla aynı olmaması için kontrol yapıldı.
                //eğer aynıysa rastgele değer atama tekrarlandı.
                if (FormaNo==OncekiDeger)
                {
                   FormaNo = rastgele.Next(0, 9);
                }
                

               //eğer seçilen oyuncu gol atmak için gerekli GolSkor değerine sahipse gol atmasını sağlayacak koşul oluşturuldu.
                if (takim[FormaNo].GolVurusu())
                {
                    Console.WriteLine("\n");
                    Console.WriteLine( "GOOOLL!!! " + takim[FormaNo].FormaNo + " numaralı " + takim[FormaNo].AdSoyad + " tarafından gol atıldı!!!");
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(takim[FormaNo].FormaNo + " numaralı " + takim[FormaNo].AdSoyad + " tarafından gelen gol şutu başarısız oldu");
                }
            }

            


            
            

            
            
            


            
            

            




           



            Console.ReadKey();

        }
    }
}

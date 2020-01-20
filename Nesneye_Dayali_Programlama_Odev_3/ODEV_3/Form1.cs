using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODEV_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //kullanıcının textbox2'ye girdiği işlem veri adında bir string değişkene atandı.
            string veri=textBox2.Text;
            //veri değişkeni içerisindeki sayının atanacağı string bir sayı değişkeni oluşturuldu.
            string sayi = "";
            //işlem içerisindeki sayıların ve işaretlerin birbirinden ayrıldıktan sonra atanmaları için listeler oluşturuldu.
            List<double> Sayilar = new List<double>();
            List<char> Isaretler = new List<char>();
            try
            {
                //veri uzunluğu kadar dönecek bir for döngüsü oluşturuldu. 
                for (int i = 0; i < veri.Length; i++)
                {
                    //veri stringi içerisindeki değer sayı ise sayı, sayi string değeri içine atanacak.
                    if (Char.IsDigit(veri[i]))
                        sayi += veri[i];

                    else
                    {
                        //veri içerisinde işlem işareti dışında virgül görülürse sayının virgülü olarak sayi değeri içine atanacak.
                        if (veri[i] == ',')
                            sayi += veri[i];
                        //eğer veri içinde işlem işareti varsa bu işaret Isaretler listesine atanacak.
                        //sayi içerisindeki değer double'a çevrilip Sayilar listesine atanacak.
                        //atama işlemi gerçekleştikten sonra sayi değerinin içi boşaltılacak.
                        else
                        {
                            Isaretler.Add(veri[i]);
                            Sayilar.Add(Convert.ToDouble(sayi));
                            sayi = "";
                        }
                    }
                }
                //veriden gelen en son sayı da yine Sayilar listesine atanacak.
                Sayilar.Add(Convert.ToDouble(sayi));
                //while döngüsünün ne kadar devam edeceğini belirleyebilmek için Isaretler listesinin sonuna "." eklendi.
                Isaretler.Add('.');
                //indeks için kullanılmak üzere bir int j değeri oluşturuldu ve içine 0 atandı.
                int j = 0;
                //Isaretler listesinin sonuna kadar dönen bir while döngüsü hazırlandı.
                while (Isaretler[j] != '.')
                {
                    
                    if (Isaretler[j] == '*')
                    {
                        //eğer Isaretler listesinin j. elemanı "*" ise Sayilar listesinin j. elemanı ve bir sonraki elemanı birbiriyle çarpılacak.
                        //elde edilen sayı Sayilar listesinin yeni j. elemanı olacak.
                        Sayilar[j] = Sayilar[j] * Sayilar[j + 1];
                        //Sayilar listesinin j+1. elemanı işleme dahil edildiği için listeden silinecek.
                        Sayilar.RemoveAt(j + 1);
                        //Isaretler listesinin j. elemanındaki işaretle işlem yapıldığı için artık o işarete de gerek kalmayacak ve listeden silinecek.
                        Isaretler.RemoveAt(j);
                        j = -1;
                    }
                   
                    else if (Isaretler[j] == '/')
                    {
                        //eğer Isaretler listesinin j. elemanı "/" ise Sayilar listesinin j. elemanı ve bir sonraki elemanı birbirine bölünecek.
                        //elde edilen sayı Sayilar listesinin yeni j. elemanı olacak.
                        Sayilar[j] = Sayilar[j] / Sayilar[j + 1];
                        //Sayilar listesinin j+1. elemanı işleme dahil edildiği için listeden silinecek.
                        Sayilar.RemoveAt(j + 1);
                        //Isaretler listesinin j. elemanındaki işaretle işlem yapıldığı için artık o işarete de gerek kalmayacak ve listeden silinecek.
                        Isaretler.RemoveAt(j);
                        j = -1;
                    }
                    //işlem sonunda -1 yapılan j değerleri yeniden sıfırlandı.
                    j++;
                }
                /* "*" ve "/" işlemleri tamamlandıktan sonra Sayilar listesinde kalan eleman 
                sayısı 1 ise işlem tamamlanmıştır ve listedeki bu eleman çıkan sonuçtur.
                bu sonuç textbox1'de kullanıcıya gösterilir.*/
                if (Sayilar.Count == 1)
                {
                    textBox1.Text = Sayilar[0].ToString();
                }
                else
                {


                    j = 0;
                    //tekrar Isaretler listesinin sonuna kadar bir while döngüsü hazırlandı.
                    while (Isaretler[j] != '.')
                    {
                       
                        if (Isaretler[j] == '+')
                        {
                            //eğer Isaretler listesinin j. elemanı "+" ise Sayilar listesinin j. elemanı ve bir sonraki elemanı birbiriyle toplanacak.
                            //elde edilen sayı Sayilar listesinin yeni j. elemanı olacak.
                            Sayilar[j] = Sayilar[j] + Sayilar[j + 1];
                            //Sayilar listesinin j+1. elemanı işleme dahil edildiği için listeden silinecek.
                            Sayilar.RemoveAt(j + 1);
                            //Isaretler listesinin j. elemanındaki işaretle işlem yapıldığı için artık o işarete de gerek kalmayacak ve listeden silinecek.
                            Isaretler.RemoveAt(j);
                            j = -1;
                        }
                        else if (Isaretler[j] == '-')
                        {
                            //eğer Isaretler listesinin j. elemanı "-" ise Sayilar listesinin j. elemanı ve bir sonraki elemanı birbirinden çıkartılacak.
                            //elde edilen sayı Sayilar listesinin yeni j. elemanı olacak.
                            Sayilar[j] = Sayilar[j] - Sayilar[j + 1];
                            //Sayilar listesinin j+1. elemanı işleme dahil edildiği için listeden silinecek.
                            Sayilar.RemoveAt(j + 1);
                            //Isaretler listesinin j. elemanındaki işaretle işlem yapıldığı için artık o işarete de gerek kalmayacak ve listeden silinecek.
                            Isaretler.RemoveAt(j);
                            j = -1;
                        }
                        //işlem sonunda -1 yapılan j değerleri yeniden sıfırlandı.
                        j++;
                    }
                    //dört işlemin hepsi kontrol edildiğine göre başka bir işlem kalmayacaktır. Elde edilen sonuç string değerine çevrilip textbox1'e atanır.
                    textBox1.Text = Sayilar[0].ToString();
                }
            }
            //textbox2'ye belirlenen işaret ve sayı değerleri dışında bir değer girildiğinde ekranda hatalı metin uyarısı verilecektir. 
            catch (Exception)
            {

                MessageBox.Show("Hatalı Metin Girdiniz!");
            }
            
        }
    }
}

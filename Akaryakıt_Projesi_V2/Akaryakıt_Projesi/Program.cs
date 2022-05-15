﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Akaryakıt_Projesi
{
    class Program
    {
        static void Main(string[] args)
        {

            // AYARLANMASI GEREKEN BAKLILMASI GEREKEN İŞLER VAR


            double Dizel = 6.63, Benzin = 7.25, LPG = 3.98, MaddeMiktarı, Sat, ToplamSatıs = 0, DizelDepo = 100000, BenzinDepo = 150000, LPGDepo = 165000;


        MENU:
            Console.WriteLine(" AKARYAKIT SİSTEMİ");
            Console.WriteLine(" -----------------");
            Console.WriteLine("Akaryakıt Sistemine Hoşgeldiniz...\n");
            Console.WriteLine("1. Birim Fiyatı Göster");
            Console.WriteLine("2. Birim Fiyatı Güncelle");
            Console.WriteLine("3. Akaryakıt Satışı Yap");
            Console.WriteLine("4. Depo Durumu Göster");
            Console.WriteLine("5. Toplam Satışları Göster");
            Console.Write("6. Çıkış\n\nSeciminiz : ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("**** Birim Fiyatlar Listesi ****\n");
                    Console.WriteLine(" Dizel : {0} TL/Litre\n Benzin : {1} TL/Litre\n LPG : {2} TL/Litre", Dizel, Benzin, LPG);

                    Console.WriteLine("\n Menüye Dönmek İçin (1) Basınız");
                    int y = Convert.ToInt32(Console.ReadLine());

                    if (y == 1)
                    {
                        clearScreen();
                        goto MENU;
                    }
                    break;

                case 2:
                IkinciOda:
                    Console.Clear();
                    Console.WriteLine("Dizel : {0} TL/Litre\nBenzin : {1} TL/Litre\nLPG : {2} TL/Litre", Dizel, Benzin, LPG);
                    Console.WriteLine("\nBirim Fiyatını Değiştirmek İstediğiniz Maddeyi Seçiniz :\n\n(1) Dizel\n(2) Benzin\n(3) LPG");
                    int YeniBirim = Convert.ToInt32(Console.ReadLine());
                
                switch (YeniBirim)
                {
                        case 1:
                            Console.Write("Dizel Maddesinin Güncel Fiyatını Giriniz : ");
                            Dizel = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 2:
                            Console.Write("Benzin Maddesinin Güncel Fiyatını Giriniz : ");
                            Benzin = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 3:
                            Console.Write("LPG Maddesinin Güncel Fiyatını Giriniz : ");
                            LPG = Convert.ToDouble(Console.ReadLine());
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Hatalı Bir Tuş Tuşladınız. YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                            System.Threading.Thread.Sleep(5000);
                            goto IkinciOda;

                }

                    Console.WriteLine("Menüye Dönmek İçin (1) Basınız");
                    y = Convert.ToInt32(Console.ReadLine());

                    if (y == 1)
                    {
                        clearScreen();
                        goto MENU;
                    }                    
                    break;


                case 3:
                    Console.Clear();
                    Console.WriteLine("**** Akaryakıt Satış Sistemi ****\n");
                    Console.Write("Aracın Plakasını Giriniz : ");
                    string Plaka = Console.ReadLine();
                UcuncuOda:
                    Console.WriteLine("\n Madde Seçiniz : (1) Dizel, (2) Benzin, (3) LPG");
                    int SatınAlınacakMadde = Convert.ToInt32(Console.ReadLine());
                   
                    //------------------------------------------------------------------------------------------------
                    //                       DEPO MEVCUT MADDE MİKTARI AŞIMI AYARLANACAK
                    //------------------------------------------------------------------------------------------------


                    if (SatınAlınacakMadde == 1)
                    {
                        Console.Clear();
                        Console.Write("Alınacak Litre Miktarını Giriniz : ");
                        MaddeMiktarı = Convert.ToInt32(Console.ReadLine());

                        Sat = (double)Dizel * MaddeMiktarı;
                        ToplamSatıs += Sat;
                        DizelDepo -= MaddeMiktarı;
                        Console.Clear();
                        Console.WriteLine("\nÜcretiniz : {0}        Plaka : {1}",Sat, Plaka);
                    }

                    else if (SatınAlınacakMadde == 2)
                    {
                        Console.Clear();
                        Console.Write("Alınacak Litre Miktarını Giriniz : ");
                        MaddeMiktarı = Convert.ToInt32(Console.ReadLine());

                        Sat = (double)Benzin * MaddeMiktarı;
                        ToplamSatıs += Sat;
                        BenzinDepo -= MaddeMiktarı;
                        Console.WriteLine("\nÜcretiniz : {0}        Plaka : {1}", Sat, Plaka);
                    }

                    else if (SatınAlınacakMadde == 3)
                    {
                        Console.Clear();
                        Console.Write("Alınacak Litre Miktarını Giriniz : ");
                        MaddeMiktarı = Convert.ToInt32(Console.ReadLine());

                        Sat = (double)LPG * MaddeMiktarı;
                        ToplamSatıs += Sat;
                        LPGDepo -= MaddeMiktarı;
                        Console.WriteLine("\nÜcretiniz : {0}        Plaka : {1}", Sat, Plaka);
                    }

                    else
                    {
                        Console.WriteLine("Yanlış Karakter Girdiniz");
                        goto UcuncuOda;
                    }

                    Console.WriteLine("\nMenüye Dönmek İçin (1) Basınız");
                    y = Convert.ToInt32(Console.ReadLine());

                    if (y == 1)
                    {
                        clearScreen();
                        goto MENU;
                    }
                    
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("Depo Durumları : Dizel : {0}      Benzin : {1}      LPG : {2}", DizelDepo, BenzinDepo, LPGDepo);

                    Console.WriteLine("\n Menüye Dönmek İçin (1) Basınız");
                    y = Convert.ToInt32(Console.ReadLine());

                    if (y == 1)
                    {
                        clearScreen();
                        goto MENU;
                    }

                    break;


                case 5:
                    Console.Clear();
                    Console.WriteLine("Toplam Satış : {0} TL", ToplamSatıs);

                    Console.WriteLine("Menüye Dönmek İçin (1) Basınız");
                    y = Convert.ToInt32(Console.ReadLine());

                    if (y == 1)
                    {
                        clearScreen();
                        goto MENU;
                    }
                    break;


                case 6:
                    goto Bitis;
            }
        Bitis:
            Console.WriteLine("\n\nProgram Sonlandı Çıkmak İçin Bir Tuşa Basınız...");
            Console.ReadLine();
        }

        static void clearScreen()
        {
            Console.Clear();
        }
        
    }
}

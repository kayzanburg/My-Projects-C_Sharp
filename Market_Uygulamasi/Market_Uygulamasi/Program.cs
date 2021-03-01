using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int Adet;
            double DisFircasi = 7, Corap = 4, Tabak = 10, Sirke = 7, Elma = 12.90, Armut = 11.25, KutuCola = 4.75, MeyveSuyu = 7.50, Sut = 7.25, TulumbaTatlisi = 15, Baklava = 17.5;
            double ucret1 = 0, ucret2 = 0, ucret3 = 0, ucret4 = 0, ucret5 = 0, ucret6 = 0, ucret7 = 0, ucret8 = 0, ucret9 = 0, ucret10 = 0, ucret11 = 0, Toplam = 0;
        menu:
            Console.WriteLine("**** Market Uygulaması ****\n");
            Console.WriteLine("(1) Ürünlerin Birim Fiyatlarını Göster");
            Console.WriteLine("(2) Ürün Satın Al");
            Console.WriteLine("(3) Çıkış");
            int Girdi1 = Convert.ToInt16(Console.ReadLine());

            switch(Girdi1)
            {
                case 1 :
                    Console.Clear();
                    Console.WriteLine(" (1) Diş Fırçası (Adet): {0} TL\n (2) Çorap (Adet): {1} TL\n (3) Tabak (Adet): {2} TL\n (4) Sirke (540 ml): {3} TL\n (5) Elma (1 kg) : {4} TL", DisFircasi, Corap, Tabak, Sirke, Elma);
                    Console.WriteLine(" (6) Armut (1 kg) : {0} TL\n (7) Kutu Cola (350 ml) : {1} TL\n (8) Meyve Suyu (250 ml) : {2} TL", Armut, KutuCola, MeyveSuyu);
                    Console.WriteLine(" (9) Süt (1 L) : {0} TL\n (10) Tulumba Tatlısı (300 gr) : {1} TL\n (11) Baklava (300gr) : {2} TL", Sut, TulumbaTatlisi, Baklava);
                    Console.WriteLine("\n Ana Menüye Dönmek İçin (1) Basınız");
                    int y = Convert.ToInt16(Console.ReadLine());

                    if ( y == 1)
                    {
                        Console.Clear();
                        goto menu;
                        
                    }
                    break;

                case 2 :
                    Console.Clear();
                    Console.WriteLine("\nÜrün Seçiniz Ve Adet Giriniz");

                urunler:

            Console.Write("\nÜrünler :\n\n (1) Diş Fırçası \n (2) Çorap \n (3) Tabak \n (4) Sirke \n (5) Elma (1 kg) \n (6) Armut (1 kg) \n (7) Kutu Cola (350 ml)");
            Console.WriteLine("\n (8) Meyve Suyu (250 ml) \n (9) Süt (1 L) \n (10) Tulumba Tatlısı (300 gr)\n (11) Baklava (300gr)");
            Console.WriteLine("\n Alışverişi Tamamlamak İçin (12) Tuşlayınız");
            int Girdi2 = Convert.ToInt16(Console.ReadLine());
                      
                switch(Girdi2)
                {
                    case 1 :
                        Console.Write("Adet Giriniz : ");
                        Adet = Convert.ToInt16(Console.ReadLine());
                        ucret1 = (double)Adet * DisFircasi;
                        Console.Clear();
                        goto urunler;
                      
                    case 2 :
                        Console.Write("Adet Giriniz : ");
                        Adet = Convert.ToInt16(Console.ReadLine());
                        ucret2 = (double)Adet * Corap;
                        Console.Clear();
                        goto urunler;
                        
                    case 3 :
                        Console.Write("Adet Giriniz : ");
                        Adet = Convert.ToInt16(Console.ReadLine());
                        ucret3 = (double)Adet * Tabak;
                        Console.Clear();
                        goto urunler;
                        
                    case 4 :
                        Console.Write("Adet Giriniz : ");
                        Adet = Convert.ToInt16(Console.ReadLine());
                        ucret4 = (double)Adet * Sirke;
                        Console.Clear();
                        goto urunler;
                        
                    case 5 :
                        Console.Write("Adet Giriniz : ");
                        Adet = Convert.ToInt16(Console.ReadLine());
                        ucret5 = (double)Adet * Elma;
                        Console.Clear();
                        goto urunler;
                        
                    case 6 :
                        Console.Write("Adet Giriniz : ");
                        Adet = Convert.ToInt16(Console.ReadLine());
                        ucret6 = (double)Adet * Armut;
                        Console.Clear();
                        goto urunler;
                        
                    case 7 :
                        Console.Write("Adet Giriniz : ");
                        Adet = Convert.ToInt16(Console.ReadLine());
                        ucret7 = (double)Adet * KutuCola;
                        Console.Clear();
                        goto urunler;
                        
                    case 8 :
                        Console.Write("Adet Giriniz : ");
                        Adet = Convert.ToInt16(Console.ReadLine());
                        ucret8 = (double)Adet * MeyveSuyu;
                        Console.Clear();
                        goto urunler;
                        
                    case 9 :
                        Console.Write("Adet Giriniz : ");
                        Adet = Convert.ToInt16(Console.ReadLine());
                        ucret9 = (double)Adet * Sut;
                        Console.Clear();
                        goto urunler;
                        
                    case 10 :
                        Console.Write("Adet Giriniz : ");
                        Adet = Convert.ToInt16(Console.ReadLine());
                        ucret10 = (double)Adet * TulumbaTatlisi;
                        Console.Clear();
                        goto urunler; 
                       
                    case 11 :
                        Console.Write("Adet Giriniz : ");
                        Adet = Convert.ToInt16(Console.ReadLine());
                        ucret11 = (double)Adet * Baklava;
                        Console.Clear();
                        goto urunler;

                    case 12 :
                        Console.Clear();
                        Toplam = (double) ucret1 + ucret2 + ucret3 + ucret4 + ucret5 + ucret6 + ucret7 + ucret8 + ucret9 + ucret10 + ucret11;
                        Console.WriteLine("\n Ücretiniz : {0} TL", Toplam);                        
                        break;
                        
                    default :
                        Console.WriteLine("Hatalı Tuşlama Yaptınız Ürün Satın Al'a Yönlendiriliyorsunuz");
                        goto urunler;                                            
                }

                    break;

                case 3 :
                    Console.Clear();
                    goto Bitis;    
                
                default :
                    Console.Clear();
                    Console.WriteLine("Hatalı Tuşlama Yaptınız Ana Menüye Yönlendiriliyorsunuz...\n");                    
                    goto menu;
              }

        Bitis:
            Console.Write("\n\n Program Sonlandı Çıkmak İçin Bir Tuşa Basınız...");
            Console.ReadLine();
            
        }
    }
}

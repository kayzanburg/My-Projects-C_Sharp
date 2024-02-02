using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Market_Uygulamasi_V2
{
    class Program
    {

        // Guncelleme_Gelicek ( Tam Olarak Fix lenmedi )

        static void Main(string[] args)
        {
            //*********************************************************************************************************************************************************************************************************************************************
            //*********************************************************************************************************************************************************************************************************************************************
            //[GENEL HATA]]    ŞU AN SATIN ALMA VE YENİ EKLENEN ÜRÜNLERİN GÜNCELLENMESİ KISMINDA (DİZİ KULLANIM KISMINDA İF EKLENMESİ LAZIM UrunEkleme kadar sayı girilebilir ve fazlası girildiğinde hata verdirilmesi lazım

            // DEPO KISMI YAPILDI
            // ÜRÜN SATIN ALMA KISMI YAPILDI
            // ÜRÜN GÜNCELLEME KISMI YAPILDI
            // ADET NEGATİF OLMAMASI SAĞLANACAK var olan ürünlerin ki ayarlandı yeni eklenen ürünlerin ki kontrol edilecek      [[bitirildi]]

            // ürün adet ekleme var olan ürünlerin ki negatif ürün eklenmesi engellendi [ bitirildi ]
            // YENİ EKLENEN ÜRÜNLERİN SATIN ALMA İPTALİ YAPILDIĞINDA  ADET EKSİLMELERİ OLMAMASI LAZIM [[[ BURDAYIM ]]]  [[ ÖNEMLİ ]]             [[bitirildi]]

            // FİYAT GÜNCELLEMELERİ NEREDE OLURSA OLSUN NEGATİF OLMAMASI AYARLANACAK    -----> YENİ EKLENEN ÜRÜNLERİN FİYATLARINI DEĞİŞTİRMEK İÇİN SEÇME VE ÜRÜN FİYATLARI NEGATİF OLMAMASI [[ BİTİRİLDİ ]]


            //*********************************************************************************************************************************************************************************************************************************************
            //*********************************************************************************************************************************************************************************************************************************************

            int Adet, y, UrunEkleme = 10, i = 0, m; //       "UrunEkleme" ifadesi niye 10 ???        <<<-------------------------    [[BURAYA KESİN BAKILMASI LAZIM]]    ---------------------------------

            //girdi 8 buraya alınacak 


            //ÜRÜN EKLEME KISMINDA NEGATİF ÜRÜN ADEDİ GİRDİĞİMİDE VE YENİ ÜRÜN SATIN ALMA KISMINDA NEGATİF ÜRÜN ALINMAYA ÇALIŞTIĞINDA HATA VERDİRİLECEK VE YENİ ÜRÜN FİYAT GÜNCELLEME KISMINDA




            /*           //ibrahim kodları
            List<UrunYelpazemiz> Firmaseysi = new List<UrunYelpazemiz>() {
            };
            UrunYelpazemiz urunlerimiz = new UrunYelpazemiz { };
            urunlerimiz.urunAdi = "Ayakkabı";
            urunlerimiz.fiyati = 5.5;
            urunlerimiz.stokdurumu = 10;
            Firmaseysi.Add(urunlerimiz);
            Console.WriteLine("{0}",Firmaseysi[0].urunAdi);
            */

            double DisFircasi = 7, Corap = 4, Tabak = 10, Sirke = 7, Elma = 10.90, Armut = 11.25, KutuCola = 4.75, MeyveSuyu = 7.50, Sut = 7.25, TulumbaTatlisi = 15, Baklava = 17.5;
            double ucret1 = 0, ucret2 = 0, ucret3 = 0, ucret4 = 0, ucret5 = 0, ucret6 = 0, ucret7 = 0, ucret8 = 0, ucret9 = 0, ucret10 = 0, ucret11 = 0, Toplam = 0, YeniUrunToplam = 0;
            int Girdi1, Girdi2, Girdi3, Girdi4, Girdi5, Girdi7;//Girdi6 -- > ÇIKARILDI

            //Depo Durumları
            int DDis = 45, DCorap = 36, DTabak = 90, DSirke = 16, DElma = 50, DArmut = 53, DCola = 76, DMSuyu = 42, DSut = 74, DTulumba = 20, DBaklava = 40;

            //Yeni Bir Ürünü Ekleme
            string[] ad = new string[UrunEkleme];       // bunda işlem YAPILMAZ
            int[] Fiyat = new int[UrunEkleme];          // fiyat işlemi yapılacak
            int[] YeniAdet = new int[UrunEkleme];       // adet işlemi yapılacak
            int[] YeniUrunDepo = new int[UrunEkleme];   // adet işleminin yedeklendiği yer

        menu:
            Display.Menu();
            Girdi1 = Convert.ToInt16(Console.ReadLine());


            /* Fazla Girdiğinde Hata Vermesi;
            
            1-  [[yok]]
            2-  [[var]]   Yeni eklenen ürünlerde var
            3-  [[var]]   Yeni eklenen ürünlerin fiyat güncellemelerinde var
            4-  [[yok]]   

             
             */

            switch (Girdi1)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(" (1) Diş Fırçası (Adet): {0} TL\n (2) Çorap (Adet): {1} TL\n (3) Tabak (Adet): {2} TL\n (4) Sirke (540 ml): {3} TL\n (5) Elma (1 kg) : {4} TL", DisFircasi, Corap, Tabak, Sirke, Elma);
                    Console.WriteLine(" (6) Armut (1 kg) : {0} TL\n (7) Kutu Cola (350 ml) : {1} TL\n (8) Meyve Suyu (250 ml) : {2} TL", Armut, KutuCola, MeyveSuyu);
                    Console.WriteLine(" (9) Süt (1 L) : {0} TL\n (10) Tulumba Tatlısı (300 gr) : {1} TL\n (11) Baklava (300gr) : {2} TL", Sut, TulumbaTatlisi, Baklava);


                    if (i != 0)
                    {
                        m = 12;
                        for (i = 0; i < UrunEkleme; i++)
                        {

                            Console.WriteLine(" ({0}) {1} : {2} TL", m, ad[i], Fiyat[i]);
                            m++;

                        }
                    }

                    Console.WriteLine("\n Ana Menüye Dönmek İçin (0) Basınız");
                    y = Convert.ToInt16(Console.ReadLine());

                    if (y == 0)
                    {
                        Console.Clear();
                        goto menu;

                    }
                    break;

                case 2:

                    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                    //                                                                      ******************** SATIN ALMA ********************
                    //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                    //hata mesajı öncesi clear atılacak ve bekleme eklenecek...----------------------   ATILMIŞ GALİBA  --------------------------------


                    Console.Clear();

                urunler:

                    Console.WriteLine("\nÜrün Seçiniz Ve Adet Giriniz");

                    Console.Write("\nÜrünler :\n\n (1) Diş Fırçası \n (2) Çorap \n (3) Tabak \n (4) Sirke \n (5) Elma (1 kg) \n (6) Armut (1 kg) \n (7) Kutu Cola (350 ml)");
                    Console.WriteLine("\n (8) Meyve Suyu (250 ml) \n (9) Süt (1 L) \n (10) Tulumba Tatlısı (300 gr)\n (11) Baklava (300gr)");


                    if (i != 0)
                    {
                        Console.WriteLine("\n---- Buranın Altındaki Ürünleri Almak İçin (-1) Tuşlayınız ----\n");

                        m = 12;
                        for (i = 0; i < UrunEkleme; i++)
                        {
                            Console.WriteLine(" ({0}) {1}", m, ad[i]);
                            m++;
                        }

                        Console.WriteLine("\n Alışverişi Tamamlamak İçin (0) Tuşlayınız");
                    }

                    else if (i == 0)
                    {
                        Console.WriteLine("\n Alışverişi Tamamlamak İçin (0) Tuşlayınız");
                    }


                    Girdi2 = Convert.ToInt16(Console.ReadLine());

                    switch (Girdi2)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Adet Giriniz : ");
                            Adet = Convert.ToInt16(Console.ReadLine());
                            if(Adet < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("HATALI ÜRÜN ADEDİ GİRDİNİZ ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                goto menu;
                            }
                            ucret1 += (double)Adet * DisFircasi;
                            DDis -= Adet;
                            if (DDis < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("\nGeçersiz Ürün Adedi Girdiniz, Lütfen Mevcut Ürün Adedi Giriniz...(Stoklarımızda Kalmadı)\n\n'Satın Alma Ekranına' YÖNLENDİRİLİYORSUNUZ... (LÜTFEN BEKLEYİNİZ)");
                                System.Threading.Thread.Sleep(6000);
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.Clear();
                                DDis = 45;
                                goto urunler;
                            }
                            else
                            {
                                Console.Clear();
                                goto urunler;
                            }

                        case 2:
                            Console.Clear();
                            Console.Write("Adet Giriniz : ");
                            Adet = Convert.ToInt16(Console.ReadLine());
                            if (Adet < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("HATALI ÜRÜN ADEDİ GİRDİNİZ ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                goto menu;
                            }
                            ucret2 += (double)Adet * Corap;
                            DCorap -= Adet;
                            if (DCorap < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("\nGeçersiz Ürün Adedi Girdiniz, Lütfen Mevcut Ürün Adedi Giriniz...(Stoklarımızda Kalmadı)\n\n'Satın Alma Ekranına' YÖNLENDİRİLİYORSUNUZ... (LÜTFEN BEKLEYİNİZ)");
                                System.Threading.Thread.Sleep(6000);
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.Clear();
                                DCorap = 36;
                                goto urunler;
                            }
                            else
                            {
                                Console.Clear();
                                goto urunler;
                            }

                        case 3:
                            Console.Clear();
                            Console.Write("Adet Giriniz : ");
                            Adet = Convert.ToInt16(Console.ReadLine());
                            if (Adet < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("HATALI ÜRÜN ADEDİ GİRDİNİZ ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                goto menu;
                            }
                            ucret3 += (double)Adet * Tabak;
                            DTabak -= Adet;
                            if (DTabak < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("\nGeçersiz Ürün Adedi Girdiniz, Lütfen Mevcut Ürün Adedi Giriniz...(Stoklarımızda Kalmadı)\n\n'Satın Alma Ekranına' YÖNLENDİRİLİYORSUNUZ... (LÜTFEN BEKLEYİNİZ)");
                                System.Threading.Thread.Sleep(6000);
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.Clear();
                                DTabak = 90;
                                goto urunler;
                            }
                            else
                            {
                                Console.Clear();
                                goto urunler;
                            }

                        case 4:
                            Console.Clear();
                            Console.Write("Adet Giriniz : ");
                            Adet = Convert.ToInt16(Console.ReadLine());
                            if (Adet < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("HATALI ÜRÜN ADEDİ GİRDİNİZ ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                goto menu;
                            }
                            ucret4 += (double)Adet * Sirke;
                            DSirke -= Adet;
                            if (DSirke < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("\nGeçersiz Ürün Adedi Girdiniz, Lütfen Mevcut Ürün Adedi Giriniz...(Stoklarımızda Kalmadı)\n\n'Satın Alma Ekranına' YÖNLENDİRİLİYORSUNUZ... (LÜTFEN BEKLEYİNİZ)");
                                System.Threading.Thread.Sleep(6000);
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.Clear();
                                DSirke = 16;
                                goto urunler;
                            }
                            else
                            {
                                Console.Clear();
                                goto urunler;
                            }

                        case 5:
                            Console.Clear();
                            Console.Write("Adet Giriniz : ");
                            Adet = Convert.ToInt16(Console.ReadLine());
                            if (Adet < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("HATALI ÜRÜN ADEDİ GİRDİNİZ ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                goto menu;
                            }
                            ucret5 += (double)Adet * Elma;
                            DElma -= Adet;
                            if (DElma < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("\nGeçersiz Ürün Adedi Girdiniz, Lütfen Mevcut Ürün Adedi Giriniz...(Stoklarımızda Kalmadı)\n\n'Satın Alma Ekranına' YÖNLENDİRİLİYORSUNUZ... (LÜTFEN BEKLEYİNİZ)");
                                System.Threading.Thread.Sleep(6000);
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.Clear();
                                DElma = 50;
                                goto urunler;
                            }
                            else
                            {
                                Console.Clear();
                                goto urunler;
                            }

                        case 6:
                            Console.Clear();
                            Console.Write("Adet Giriniz : ");
                            Adet = Convert.ToInt16(Console.ReadLine());
                            if (Adet < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("HATALI ÜRÜN ADEDİ GİRDİNİZ ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                goto menu;
                            }
                            ucret6 += (double)Adet * Armut;
                            DArmut -= Adet;
                            if (DArmut < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("\nGeçersiz Ürün Adedi Girdiniz, Lütfen Mevcut Ürün Adedi Giriniz...(Stoklarımızda Kalmadı)\n\n'Satın Alma Ekranına' YÖNLENDİRİLİYORSUNUZ... (LÜTFEN BEKLEYİNİZ)");
                                System.Threading.Thread.Sleep(6000);
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.Clear();
                                DArmut = 53;
                                goto urunler;
                            }
                            else
                            {
                                Console.Clear();
                                goto urunler;
                            }

                        case 7:
                            Console.Clear();
                            Console.Write("Adet Giriniz : ");
                            Adet = Convert.ToInt16(Console.ReadLine());
                            if (Adet < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("HATALI ÜRÜN ADEDİ GİRDİNİZ ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                goto menu;
                            }
                            ucret7 += (double)Adet * KutuCola;
                            DCola -= Adet;
                            if (DCola < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("\nGeçersiz Ürün Adedi Girdiniz, Lütfen Mevcut Ürün Adedi Giriniz...(Stoklarımızda Kalmadı)\n\n'Satın Alma Ekranına' YÖNLENDİRİLİYORSUNUZ... (LÜTFEN BEKLEYİNİZ)");
                                System.Threading.Thread.Sleep(6000);
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.Clear();
                                DCola = 76;
                                goto urunler;
                            }
                            else
                            {
                                Console.Clear();
                                goto urunler;
                            }

                        case 8:
                            Console.Clear();
                            Console.Write("Adet Giriniz : ");
                            Adet = Convert.ToInt16(Console.ReadLine());
                            if (Adet < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("HATALI ÜRÜN ADEDİ GİRDİNİZ ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                goto menu;
                            }
                            ucret8 += (double)Adet * MeyveSuyu;
                            DMSuyu -= Adet;
                            if (DMSuyu < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("\nGeçersiz Ürün Adedi Girdiniz, Lütfen Mevcut Ürün Adedi Giriniz...(Stoklarımızda Kalmadı)\n\n'Satın Alma Ekranına' YÖNLENDİRİLİYORSUNUZ... (LÜTFEN BEKLEYİNİZ)");
                                System.Threading.Thread.Sleep(6000);
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.Clear();
                                DMSuyu = 45;
                                goto urunler;
                            }
                            else
                            {
                                Console.Clear();
                                goto urunler;
                            }

                        case 9:
                            Console.Clear();
                            Console.Write("Adet Giriniz : ");
                            Adet = Convert.ToInt16(Console.ReadLine());
                            if (Adet < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("HATALI ÜRÜN ADEDİ GİRDİNİZ ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                goto menu;
                            }
                            ucret9 += (double)Adet * Sut;
                            DSut -= Adet;
                            if (DSut < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("\nGeçersiz Ürün Adedi Girdiniz, Lütfen Mevcut Ürün Adedi Giriniz...(Stoklarımızda Kalmadı)\n\n'Satın Alma Ekranına' YÖNLENDİRİLİYORSUNUZ... (LÜTFEN BEKLEYİNİZ)");
                                System.Threading.Thread.Sleep(6000);
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.Clear();
                                DSut = 45;
                                goto urunler;
                            }
                            else
                            {
                                Console.Clear();
                                goto urunler;
                            }

                        case 10:
                            Console.Clear();
                            Console.Write("Adet Giriniz : ");
                            Adet = Convert.ToInt16(Console.ReadLine());
                            if (Adet < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("HATALI ÜRÜN ADEDİ GİRDİNİZ ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                goto menu;
                            }
                            ucret10 += (double)Adet * TulumbaTatlisi;
                            DTulumba -= Adet;
                            if (DTulumba < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("\nGeçersiz Ürün Adedi Girdiniz, Lütfen Mevcut Ürün Adedi Giriniz...(Stoklarımızda Kalmadı)\n\n'Satın Alma Ekranına' YÖNLENDİRİLİYORSUNUZ... (LÜTFEN BEKLEYİNİZ)");
                                System.Threading.Thread.Sleep(6000);
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.Clear();
                                DTulumba = 45;
                                goto urunler;
                            }
                            else
                            {
                                Console.Clear();
                                goto urunler;
                            }

                        case 11:
                            Console.Clear();
                            Console.Write("Adet Giriniz : ");
                            Adet = Convert.ToInt16(Console.ReadLine());
                            if (Adet < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("HATALI ÜRÜN ADEDİ GİRDİNİZ ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                goto menu;
                            }
                            ucret11 += (double)Adet * Baklava;
                            DBaklava -= Adet;
                            if (DBaklava < 0)
                            {
                                Console.Clear();
                                Console.WriteLine("\nGeçersiz Ürün Adedi Girdiniz, Lütfen Mevcut Ürün Adedi Giriniz...(Stoklarımızda Kalmadı)\n\n'Satın Alma Ekranına' YÖNLENDİRİLİYORSUNUZ... (LÜTFEN BEKLEYİNİZ)");
                                System.Threading.Thread.Sleep(6000);
                                Console.WriteLine("-------------------------------------------------------------------");
                                Console.Clear();
                                DBaklava = 45;
                                goto urunler;
                            }
                            else
                            {
                                Console.Clear();
                                goto urunler;
                            }

                        case -1:
                            
                            Console.Clear();
                            Console.WriteLine("Almak İstediğiniz Ürünü Seçiniz Ve Adet Giriniz : \n");

                            //ÜRÜNLER GÖZÜKMÜYOR        ------>     BEN BU SORUNU BİR DAHA BULAMADIM

                            // NEGATİF bi sayı girildiğinde sonuç negatif çikacağı için negatif sayı girildiğinde hata verdir ( adet girerken ) aksi taktirde fiyat negatif hesaplanacak
                            // yeni ürün eklerken negatif ürün adedi girilince ---------> hata verdirilmesi lazım

                            m = 12;
                            for (i = 0; i < UrunEkleme; i++)
                            {

                                Console.WriteLine(" ({0}) {1} : {2} TL", m, ad[i], Fiyat[i]);
                                m++;

                            }

                            int a = m-1;  // BU KISIM YENİ EKLENDİ (Girdi4 için if else kullanımı için gerekli)

                            

                            Console.WriteLine("\n Alışverişi İptal Etmek İçin (-5) Basınız");

                            Girdi4 = Convert.ToInt32(Console.ReadLine());


                            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                            // BURAYA OLUMLU İF EKLENECEK VE EKLENEN İF İN İÇİNE NORMALDE YAPILACAK OLAN İŞLEMLER KONULACAK ( ONUELİ YUKARI YAZISININ ALTINDAKİ ELEMANLAR EKLENECEK YANİ   [[ yapılmış olaması lazım kafam karıştı ]]

                            //-----------------------------------------------------------ÖNEMLİ BURANIN Bİ TIK ALTINDA-------------------------------------------------------------------------------------------------------------------------------------------------------


                            

                            if (Girdi4 > 11 && Girdi4 <= a)     // YENİ EKLENDİ     [[ONAYLANDI]]
                            {

                                Girdi5 = Convert.ToInt32(Console.ReadLine());

                                //-----Girdi5 if else kullanım yeri Girdi5 if else kullanım yeri----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


                                //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                                //BURANIN ALTI YENİ EKLENDİ--------------------------------------------------------------------------------------------------------------------

                                if (Girdi5 == -5)
                                {
                                    //Toplam = 0;     //AKTİF EDİLECEK
                                    //YeniUrunToplam = 0;   //AKTİF EDİLECEK
                                    Console.Clear();
                                    Console.WriteLine("\n ALIŞVERİŞ İPTAL EDİLDİ, ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.Clear();
                                    goto menu;
                                }
                                else if (Girdi5 < 0) //      YENİ EKLENDİ EN SON
                                {
                                    Console.Clear();
                                    Console.WriteLine("HATALI TUŞLAMA YAPTINIZ MENÜ'YE YÖNLENDİRİLİYORSUNUZ...");
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                    goto menu;
                                }

                                if (Girdi5 > YeniUrunDepo[Girdi4 - 12])
                                {
                                    Console.Clear();
                                    Console.WriteLine("\nGeçersiz Ürün Adedi Girdiniz, Lütfen Mevcut Ürün Adedi Giriniz...(Stoklarımızda Kalmadı)\n\n'Satın Alma Ekranına' YÖNLENDİRİLİYORSUNUZ... (LÜTFEN BEKLEYİNİZ)");
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                    goto urunler;

                                }

                                //BURANIN ÜSTÜ YENİ EKLENDİ--------------------------------------------------------------------------------------------------------------------



                                //burada eksilme işlemi yapılacak

                                YeniUrunDepo[Girdi4 - 12] -= Girdi5;//deneme



                                //BURADA ÜCRET HESABI YAPILIYOR

                                YeniUrunToplam += Fiyat[Girdi4 - 12] * Girdi5; //buraya -12 ekledim önemli burası hata veriyordu        [[ ONAYLANDI ]]

                                Console.Clear();
                                Console.WriteLine("Yeni Ürün Almak İçin (0) Basınız");
                                Console.WriteLine("Alışverişi Tamamlamak İçin (-1) Basınız");
                                Girdi7 = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                // 1 ADET ÜRÜN ALABİLİYORUZ  --------((bunu ne için yazdığımı hatırlamıyorum))-------


                                switch (Girdi7)
                                {
                                    
                                    case 0:

                                        goto urunler;

                                    case -1:

                                        goto BAKİYE;



                                    default:

                                        Console.WriteLine("Alışverişiniz İptal Edildi");
                                        Console.WriteLine("Hatalı Tuşlama Yaptınız      ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                                        YeniUrunDepo[Girdi4 - 12] += Girdi5;// EN SON YAPILAN YER           YENİ ÜRÜNLERİN ADETLERİNİN NORMALE DÖNDÜRÜLDÜĞÜ YER                 [[ ONAYLANDI ]]
                                        System.Threading.Thread.Sleep(4500);
                                        Toplam = 0;
                                        YeniUrunToplam = 0;
                                        Console.Clear();
                                        goto menu;

                                }

                           
                            }
                                
                            else if (Girdi4 == -5)
                            {
                                    //Toplam = 0;
                                    YeniUrunToplam = 0;
                                    Console.Clear();
                                    Console.WriteLine("\n ALIŞVERİŞ İPTAL EDİLDİ, ANA MENÜYE YÖNLENDİRİLİYORSUNUZ...");
                                    System.Threading.Thread.Sleep(2000);
                                    Console.Clear();
                                    goto menu;
                            }

                            else
                            {
                                Console.Clear();
                                Console.WriteLine("HATALI İFADE GİRDİNİZ ANA MENÜ'YE YÖNLENDİRİLYORSUNUZ...");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                goto menu;
                            }


                        case 0:
                        BAKİYE:
                            Console.Clear();

                            Toplam = (double)(ucret1 + ucret2 + ucret3 + ucret4 + ucret5 + ucret6 + ucret7 + ucret8 + ucret9 + ucret10 + ucret11 + YeniUrunToplam);

                            Console.WriteLine("\n   Ücretiniz : {0} TL", Toplam);
                            Console.WriteLine("\n Ana Menüye Dönmek İçin (1), Çıkış Yapmak İçin (2) Basınız");
                            y = Convert.ToInt16(Console.ReadLine());

                            if (y == 1)
                            {
                                Console.Clear();
                                goto menu;

                            }
                            else if (y == 2)
                            {
                                goto Bitis;
                            }

                            break;



                        default:
                            Console.Clear();
                            Console.WriteLine(" Satın Alma İşlemi İptal Edildi");
                            Console.WriteLine("\n Hatalı Tuşlama Yaptınız Ürün Satın Al'a Yönlendiriliyorsunuz...");
                            System.Threading.Thread.Sleep(4000);
                            Console.Clear();
                            goto urunler;
                    }

                  

                    break;

                case 3:
                    //                                         ---------------------------------------  GÜNCEL FİYAT  -----------------------------------------

                    Console.Clear();
                    Console.WriteLine("\nBirim Fiyatını Değiştirmek İstediğiniz Ürünü Seçiniz...\n");
                    Console.WriteLine(" (1) Diş Fırçası (Adet)\n (2) Çorap (Adet)\n (3) Tabak (Adet)\n (4) Sirke (540 ml)\n (5) Elma (1 kg)");
                    Console.WriteLine(" (6) Armut (1 kg)\n (7) Kutu Cola (350 ml)\n (8) Meyve Suyu (250 ml)");
                    Console.WriteLine(" (9) Süt (1 L)\n (10) Tulumba Tatlısı (300 gr)\n (11) Baklava (300gr)");
                    
                    
                    

                    //YENİ ÜRÜNLER EKRANA GÖZÜKMESİ
                    
                    if(i!=0)
                    {
                        Console.WriteLine("\n Buranın Altındaki Ürünlerin Birim Fiyat Değişimini Yapmak İçin (-1) Basınız\n");

                        m = 12;
                        for (i = 0; i < UrunEkleme; i++)
                        {

                            Console.WriteLine(" ({0}) {1}", m, ad[i]);
                            m++;

                        }
                    }

                    Console.WriteLine("\n Ana Menüye Dönmek İçin (0) Tuşlayınız");//yeni ekleniyor [[ TEST ET ]]            [[ ONAYLANDI ]]
                    

                    double FDegis = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();

                    switch (FDegis)
                    {
                        case 1:
                            Console.Write("Diş Fırçası Maddesinin Güncel Fiyatını Giriniz : ");
                            DisFircasi = Convert.ToDouble(Console.ReadLine());

                            if(DisFircasi < 0)
                            {
                                DisFircasi = 7;
                                Console.Clear();
                                Console.WriteLine("HATALI TUŞLAMA YAPTINIZ (NEGATİF BİR SAYI GİRDİNİZ) ANA MENÜ'YE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(5000);
                                Console.Clear();
                                goto menu;
                            }

                            break;
                        case 2:
                            Console.Write("Çorap Maddesinin Güncel Fiyatını Giriniz : ");
                            Corap = Convert.ToDouble(Console.ReadLine());
                            if (Corap < 0)
                            {
                                Corap = 4;
                                Console.Clear();
                                Console.WriteLine("HATALI TUŞLAMA YAPTINIZ (NEGATİF BİR SAYI GİRDİNİZ) ANA MENÜ'YE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(5000);
                                Console.Clear();
                                goto menu;
                            }
                            break;
                        case 3:
                            Console.Write("Tabak Maddesinin Güncel Fiyatını Giriniz : ");
                            Tabak = Convert.ToDouble(Console.ReadLine());
                            if (Tabak < 0)
                            {
                                Tabak = 10;
                                Console.Clear();
                                Console.WriteLine("HATALI TUŞLAMA YAPTINIZ (NEGATİF BİR SAYI GİRDİNİZ) ANA MENÜ'YE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(5000);
                                Console.Clear();
                                goto menu;
                            }
                            break;
                        case 4:
                            Console.Write("Sirke Maddesinin Güncel Fiyatını Giriniz : ");
                            Sirke = Convert.ToDouble(Console.ReadLine());
                            if (Sirke < 0)
                            {
                                Sirke = 7;
                                Console.Clear();
                                Console.WriteLine("HATALI TUŞLAMA YAPTINIZ (NEGATİF BİR SAYI GİRDİNİZ) ANA MENÜ'YE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(5000);
                                Console.Clear();
                                goto menu;
                            }
                            break;
                        case 5:
                            Console.Write("Elma Maddesinin Güncel Fiyatını Giriniz : ");
                            Elma = Convert.ToDouble(Console.ReadLine());
                            if (Elma < 0)
                            {
                                Elma = 10.90;
                                Console.Clear();
                                Console.WriteLine("HATALI TUŞLAMA YAPTINIZ (NEGATİF BİR SAYI GİRDİNİZ) ANA MENÜ'YE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(5000);
                                Console.Clear();
                                goto menu;
                            }
                            break;
                        case 6:
                            Console.Write("Armut Maddesinin Güncel Fiyatını Giriniz : ");
                            Armut = Convert.ToDouble(Console.ReadLine());
                            if (Armut < 0)
                            {
                                Armut = 11.25;
                                Console.Clear();
                                Console.WriteLine("HATALI TUŞLAMA YAPTINIZ (NEGATİF BİR SAYI GİRDİNİZ) ANA MENÜ'YE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(5000);
                                Console.Clear();
                                goto menu;
                            }
                            break;
                        case 7:
                            Console.Write("Kutu Cola Maddesinin Güncel Fiyatını Giriniz : ");
                            KutuCola = Convert.ToDouble(Console.ReadLine());
                            if (KutuCola < 0)
                            {
                                KutuCola = 4.75;
                                Console.Clear();
                                Console.WriteLine("HATALI TUŞLAMA YAPTINIZ (NEGATİF BİR SAYI GİRDİNİZ) ANA MENÜ'YE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(5000);
                                Console.Clear();
                                goto menu;
                            }
                            break;
                        case 8:
                            Console.Write("Meyve Suyu Maddesinin Güncel Fiyatını Giriniz : ");
                            MeyveSuyu = Convert.ToDouble(Console.ReadLine());
                            if (MeyveSuyu < 0)
                            {
                                MeyveSuyu = 7.50;
                                Console.Clear();
                                Console.WriteLine("HATALI TUŞLAMA YAPTINIZ (NEGATİF BİR SAYI GİRDİNİZ) ANA MENÜ'YE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(5000);
                                Console.Clear();
                                goto menu;
                            }
                            break;
                        case 9:
                            Console.Write("Süt Maddesinin Güncel Fiyatını Giriniz : ");
                            Sut = Convert.ToDouble(Console.ReadLine());
                            if (Sut < 0)
                            {
                                Sut = 7.25;
                                Console.Clear();
                                Console.WriteLine("HATALI TUŞLAMA YAPTINIZ (NEGATİF BİR SAYI GİRDİNİZ) ANA MENÜ'YE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(5000);
                                Console.Clear();
                                goto menu;
                            }
                            break;
                        case 10:
                            Console.Write("Tulumba Tatlısı Maddesinin Güncel Fiyatını Giriniz : ");
                            TulumbaTatlisi = Convert.ToDouble(Console.ReadLine());
                            if (TulumbaTatlisi < 0)
                            {
                                TulumbaTatlisi = 15;
                                Console.Clear();
                                Console.WriteLine("HATALI TUŞLAMA YAPTINIZ (NEGATİF BİR SAYI GİRDİNİZ) ANA MENÜ'YE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(5000);
                                Console.Clear();
                                goto menu;
                            }
                            break;
                        case 11:
                            Console.Write("Baklava Maddesinin Güncel Fiyatını Giriniz : ");
                            Baklava = Convert.ToDouble(Console.ReadLine());
                            if (Baklava < 0)
                            {
                                Baklava = 17.5;
                                Console.Clear();
                                Console.WriteLine("HATALI TUŞLAMA YAPTINIZ (NEGATİF BİR SAYI GİRDİNİZ) ANA MENÜ'YE YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(5000);
                                Console.Clear();
                                goto menu;
                            }
                            break;
                        case -1:

                     //                                         ---------------------------------------  yeni eklenen ürünlerin fiyat değişimleri ---------------------------------------

                            m = 12;
                            for (i = 0; i < UrunEkleme; i++)
                            {

                                Console.WriteLine(" ({0}) {1} : {2} TL", m, ad[i], Fiyat[i]);//yeni eklenen ürünlerin gösterme işlemleri yapıldı.
                                m++;

                            }

                            int b = m - 1;


                            int Girdi8 = Convert.ToInt32(Console.ReadLine()); //ürünün sayısı seçilir [[örn : 12]]


                        if (Girdi8 > 11 && Girdi8 <= b) //  [ONAYLANDI]
                        {   

                            int YeniUrunGuncelleme = Convert.ToInt32(Console.ReadLine());   //buraya göre birim fiyatı değiştirilecek ürün FİYATLARI girilecek

                                if(YeniUrunGuncelleme < 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("HATALI TUŞLAMA YAPTINIZ (Negatif Ürün Fiyatı Giremezsiniz) ANA MENÜ'YE YÖNLENDİRİLİYORSUNUZ...");
                                    System.Threading.Thread.Sleep(4000);
                                    Console.Clear();
                                    goto menu;
                                }

                            Fiyat[Girdi8 - 12] = YeniUrunGuncelleme;    //  YENİ ÜRÜN FİYAT GÜNCELLEMESİ YAPILIR
                                                        
                        }

                        else
                        {
                             Console.Clear();
                             Console.WriteLine("HATALI TUŞLAMA YAPTINIZ MENÜ'YE YÖNLENDİRİLİYORSUNUZ...");
                             System.Threading.Thread.Sleep(3500);
                             Console.Clear();
                             goto menu;
                        }

                            break;
                        case 0:
                            Console.Clear();
                            goto menu;

                        default:
                            Console.Clear();
                            Console.Write("Hatalı Tuşlama Yaptınız. ANA MENÜ'YE YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                            System.Threading.Thread.Sleep(5000);
                            Console.Clear();
                            goto menu;
                    }
                    Console.WriteLine("\n Menüye Dönmek İçin (1) Basınız");
                    int Menu = Convert.ToInt32(Console.ReadLine());
                    if (Menu == 1)
                    {
                        Console.Clear();
                        goto menu;
                    }


                    break;

                case 4:
                //depo
                DEPO:
                    Console.Clear();
                    Console.WriteLine("--------------\n    DEPO    \n--------------");
                    Console.WriteLine("(1) Diş Fırçası : {0}\n(2) Çorap  : {1}\n(3) Tabak  : {2}\n(4) Sirke  : {3}\n(5) Elma (kg)  : {4}", DDis, DCorap, DTabak, DSirke, DElma);
                    Console.WriteLine("(6) Armut (kg)  : {0}\n(7) Kutu Cola (Adet) : {1}\n(8) Meyve Suyu (Adet)  : {2}", DArmut, DCola, DMSuyu);
                    Console.WriteLine("(9) Süt (Adet)  : {0}\n(10) Tulumba Tatlısı (Kilo) : {1}\n(11) Baklava (Kilo) : {2}", DSut, DTulumba, DBaklava);

                    //YENİ EKLENEN ÜRÜNLERİN YAZDIRMA İŞLEMLERİ YAPILIYOR

                    if (i != 0)
                    {
                        m = 12;
                        for (i = 0; i < UrunEkleme; i++)
                        {
                            Console.WriteLine("({0}) {1} : {2}", m, ad[i], YeniUrunDepo[i]);
                            m++;
                        }
                    }
                    
                    Console.WriteLine("\nVar Olan Ürünlere Ürün Adedi Eklemek İçin (12) Basınız");
                    Console.WriteLine("Yeni Bir Ürün Eklemek İçin (13) Basınız");
                    Console.WriteLine("\n\n Ana Menüye Dönmek İçin (0) Basınız");
                    int Ekleme = Convert.ToInt32(Console.ReadLine());

                    switch (Ekleme)
                    {
                        case 12:

                            // yeni ürün ekledikten sonra menüde hatalı tuşlama yapılısa {{hatalı tuşlama yaptınız ana menüye döndürülüyorsunuz BİLGİLENDİRME : ürününüz eklendi }} YAZDIR [[ EKLENMEYECEK ]] [[ BİTİRİLDİ ]]

                            Console.Clear();
                            Console.WriteLine("Eklemek İstediğiniz Ürünü Seçiniz :");
                            Console.Write("\nÜrünler :\n\n (1) Diş Fırçası \n (2) Çorap \n (3) Tabak \n (4) Sirke \n (5) Elma (kg) \n (6) Armut (kg) \n (7) Kutu Cola (ml)");
                            Console.WriteLine("\n (8) Meyve Suyu (ml) \n (9) Süt (L) \n (10) Tulumba Tatlısı (gr)\n (11) Baklava (gr)");




                            int VarUrunEkleme = Convert.ToInt32(Console.ReadLine());                        //BURAYA İŞARET ATIMIŞIM BAK            [[ İŞARETLİ ]]
                            switch (VarUrunEkleme)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.Write("Eklemek İstediğiniz Miktarı Giriniz : ");
                                    Girdi3 = Convert.ToInt32(Console.ReadLine());

                                    if (Girdi3 < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Negatif Ürün Adedi Girdiniz ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }
                                    

                                    Console.WriteLine("\n Ana Menüye Dönmek İçin (1) Basınız");
                                    y = Convert.ToInt16(Console.ReadLine());

                                    if (y == 1)
                                    {
                                        DDis += Girdi3;
                                        Console.Clear();
                                        goto menu;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" Hatalı Bir Tuş Tuşladınız. ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                case 2:
                                    Console.Clear();
                                    Console.Write("Eklemek İstediğiniz Miktarı Giriniz : ");
                                    Girdi3 = Convert.ToInt32(Console.ReadLine());

                                    if (Girdi3 < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Negatif Ürün Adedi Girdiniz ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }
                                    Console.WriteLine("\n Ana Menüye Dönmek İçin (1) Basınız");
                                    y = Convert.ToInt16(Console.ReadLine());

                                    if (y == 1)
                                    {
                                        DCorap += Girdi3;
                                        Console.Clear();
                                        goto menu;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" Hatalı Bir Tuş Tuşladınız. ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                case 3:
                                    Console.Clear();
                                    Console.Write("Eklemek İstediğiniz Miktarı Giriniz : ");
                                    Girdi3 = Convert.ToInt32(Console.ReadLine());

                                    if (Girdi3 < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Negatif Ürün Adedi Girdiniz ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                    Console.WriteLine("\n Ana Menüye Dönmek İçin (1) Basınız");
                                    y = Convert.ToInt16(Console.ReadLine());

                                    if (y == 1)
                                    {
                                        DTabak += Girdi3;
                                        Console.Clear();
                                        goto menu;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" Hatalı Bir Tuş Tuşladınız. ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                case 4:
                                    Console.Clear();
                                    Console.Write("Eklemek İstediğiniz Miktarı Giriniz : ");
                                    Girdi3 = Convert.ToInt32(Console.ReadLine());

                                    if (Girdi3 < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Negatif Ürün Adedi Girdiniz ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                    Console.WriteLine("\n Ana Menüye Dönmek İçin (1) Basınız");
                                    y = Convert.ToInt16(Console.ReadLine());

                                    if (y == 1)
                                    {
                                        DSirke += Girdi3;
                                        Console.Clear();
                                        goto menu;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" Hatalı Bir Tuş Tuşladınız. ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                case 5:
                                    Console.Clear();
                                    Console.Write("Eklemek İstediğiniz Miktarı Giriniz : ");
                                    Girdi3 = Convert.ToInt32(Console.ReadLine());

                                    if (Girdi3 < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Negatif Ürün Adedi Girdiniz ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                    Console.WriteLine("\n Ana Menüye Dönmek İçin (1) Basınız");
                                    y = Convert.ToInt16(Console.ReadLine());

                                    if (y == 1)
                                    {
                                        DElma += Girdi3;
                                        Console.Clear();
                                        goto menu;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" Hatalı Bir Tuş Tuşladınız. ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                case 6:
                                    Console.Clear();
                                    Console.Write("Eklemek İstediğiniz Miktarı Giriniz : ");
                                    Girdi3 = Convert.ToInt32(Console.ReadLine());

                                    if (Girdi3 < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Negatif Ürün Adedi Girdiniz ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                    Console.WriteLine("\n Ana Menüye Dönmek İçin (1) Basınız");
                                    y = Convert.ToInt16(Console.ReadLine());

                                    if (y == 1)
                                    {
                                        DArmut += Girdi3;
                                        Console.Clear();
                                        goto menu;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" Hatalı Bir Tuş Tuşladınız. ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                case 7:
                                    Console.Clear();
                                    Console.Write("Eklemek İstediğiniz Miktarı Giriniz : ");
                                    Girdi3 = Convert.ToInt32(Console.ReadLine());

                                    if (Girdi3 < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Negatif Ürün Adedi Girdiniz ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                    Console.WriteLine("\n Ana Menüye Dönmek İçin (1) Basınız");
                                    y = Convert.ToInt16(Console.ReadLine());

                                    if (y == 1)
                                    {
                                        DCola += Girdi3;
                                        Console.Clear();
                                        goto menu;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" Hatalı Bir Tuş Tuşladınız. ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                case 8:
                                    Console.Clear();
                                    Console.Write("Eklemek İstediğiniz Miktarı Giriniz : ");
                                    Girdi3 = Convert.ToInt32(Console.ReadLine());

                                    if (Girdi3 < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Negatif Ürün Adedi Girdiniz ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                    Console.WriteLine("\n Ana Menüye Dönmek İçin (1) Basınız");
                                    y = Convert.ToInt16(Console.ReadLine());

                                    if (y == 1)
                                    {
                                        DMSuyu += Girdi3;
                                        Console.Clear();
                                        goto menu;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" Hatalı Bir Tuş Tuşladınız. ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                case 9:
                                    Console.Clear();
                                    Console.Write("Eklemek İstediğiniz Miktarı Giriniz : ");
                                    Girdi3 = Convert.ToInt32(Console.ReadLine());

                                    if (Girdi3 < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Negatif Ürün Adedi Girdiniz ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                    Console.WriteLine("\n Ana Menüye Dönmek İçin (1) Basınız");
                                    y = Convert.ToInt16(Console.ReadLine());

                                    if (y == 1)
                                    {
                                        DSut += Girdi3;
                                        Console.Clear();
                                        goto menu;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" Hatalı Bir Tuş Tuşladınız. ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                case 10:
                                    Console.Clear();
                                    Console.Write("Eklemek İstediğiniz Miktarı Giriniz : ");
                                    Girdi3 = Convert.ToInt32(Console.ReadLine());

                                    if (Girdi3 < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Negatif Ürün Adedi Girdiniz ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                    Console.WriteLine("\n Ana Menüye Dönmek İçin (1) Basınız");
                                    y = Convert.ToInt16(Console.ReadLine());

                                    if (y == 1)
                                    {
                                        DTulumba += Girdi3;
                                        Console.Clear();
                                        goto menu;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" Hatalı Bir Tuş Tuşladınız. ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }


                                case 11:
                                    Console.Clear();
                                    Console.Write("Eklemek İstediğiniz Miktarı Giriniz : ");
                                    Girdi3 = Convert.ToInt32(Console.ReadLine());

                                    if (Girdi3 < 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Negatif Ürün Adedi Girdiniz ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }

                                    Console.WriteLine("\n Ana Menüye Dönmek İçin (1) Basınız");
                                    y = Convert.ToInt16(Console.ReadLine());

                                    if (y == 1)
                                    {
                                        DBaklava += Girdi3;
                                        Console.Clear();
                                        goto menu;
                                    }

                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine(" Hatalı Bir Tuş Tuşladınız. ( İŞLEMİNİZ İPTAL EDİLDİ ) Depo'ya YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                        System.Threading.Thread.Sleep(5000);
                                        Console.Clear();
                                        goto DEPO;
                                    }
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Hatalı Bir Tuş Tuşladınız. Ana Menü'ye YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİNİZ...");
                                    System.Threading.Thread.Sleep(5000);
                                    Console.Clear();
                                    goto menu;

                            }

                        case 13:

                            //  [[HATA]]  YENİ ÜRÜN EKLEDİKTEN SONRA YENİ İŞLEM OLARAK YENİ BİR ÜRÜN EKLEMEYE ÇALIŞTIĞIMDA HATA VERDİ [[ ÖNEMLİ Bİ HATA ]]

                            Console.Clear();
                            Console.Write("Kaç Tane Ürün Ekleyeceksiniz : ");
                            UrunEkleme = Convert.ToInt32(Console.ReadLine());


                            if(UrunEkleme <= 0)
                            {
                                UrunEkleme = 10; // urun ekleme yi ana sayısına döndürdüm
                                Console.Clear();
                                Console.WriteLine("HATALI TUŞLAMA YAPTINIZ DEPO'YA YÖNLENDİRİLİYORSUNUZ...");
                                System.Threading.Thread.Sleep(4000);
                                Console.Clear();
                                goto DEPO;
                            }

                            Console.Clear();
                            Console.WriteLine("Lütfen {0} Tane Ürün Giriniz             YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİN...", UrunEkleme);
                            //System.Threading.Thread.Sleep(4000);          AKTİF EDİLECEK
                            Console.Clear();
                            Console.WriteLine("Sırasıyla Ürün Adı, Fiyat Ve Adet Giriniz : ");

                            for (i = 0; i < UrunEkleme; i++)
                            {
                                Console.Write("{0}. Ürün İçin \n\nAd : ", i + 1);
                                ad[i] = Console.ReadLine();
                                Console.Write("\nFiyat (TL) : ");
                                Fiyat[i] = Convert.ToInt32(Console.ReadLine());
                                Console.Write("\nAdet : ");
                                YeniAdet[i] = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();
                                YeniUrunDepo[i] = YeniAdet[i];

                            }

                            break;

                        case 0:
                            Console.Clear();
                            goto menu;

                        default:
                            Console.Clear();
                            Console.WriteLine("\nHatalı Tuşlama Yaptınız Ana Menüye Yönlendiriliyorsunuz.(LÜTFEN BEKLEYİN !!!)\n");
                            System.Threading.Thread.Sleep(6000);
                            Console.Clear();
                            goto menu;

                    }

                    Console.WriteLine("\n Ana Menüye Dönmek İçin (1) Basınız");
                    y = Convert.ToInt16(Console.ReadLine());

                    if (y == 1)
                    {
                        Console.Clear();
                        goto menu;

                    }
                    break;
                    
                case 5:
                    Console.Clear();
                    goto Bitis;

                default:
                    Console.Clear();
                    Console.WriteLine("\nHatalı Tuşlama Yaptınız Ana Menüye Yönlendiriliyorsunuz...\n");
                    System.Threading.Thread.Sleep(6000);
                    Console.Clear();
                    goto menu;
            }


        Bitis:
            Console.Write("\n\n Program Sonlandı Çıkmak İçin Bir Tuşa Basınız...");
            Console.ReadLine();


            // (FİX)    yeni ürün eklemek istediğimizde POZİTİF OLMAYAN değer girdiğinde hata verdirilecek [[ BİTİRİLDİ ]]






            //[[try CATCH] KULLANILACAK----------------------------------------------------------------------------------------------------------------------------------------------
            // (HATA) BEKLEME SIRASINDA [ENTER] BASARSAN HATA VERİYO
            // (HATA(!!!)) int istenen girdiye string bir şey girdiğinde hata veriyo bunu çöz







            //  (LAST)  yeni ürün eklendiğinde bir daha yeni ürün eklenirse ne olur??   _/**** (EĞER PROGRAMI HAFIZAYA ALMAYA KARAR VERİRSEM BU SIKINTI ÇIKARACAK) ****\_


            //  (LAST)   YENİ ÜRÜN EKLENDİĞİNDE SATIŞI YAPILIRKEN HATA TESPİTİ YAPMAYA ÇALIŞILACAK

            // (LAST)  console clearlar kontrol edilecek bir yerde eksikti galiba
            // (LAST)(DENENECEK)  Ürün Satın Alda 100.000 adet girince hata aldım baklavadaydı galiba ----> BAKLAVAYA 100.000 ADET EKLE DEPOYA SONRA 100.000 ADET SATIN ALMAYA ÇALIŞ

            
            
            
            
            
            //  GÜNLÜK KAZANÇ EKLENSİNMİ?? [[ YES ]]










            /*ÖNEMLİ BİR ŞEY FARKETTİM  " yeni "  ÜRÜN SATIN ALMA İŞLEMİ İPTAL EDİLDİĞİNDE SADECE FİYAT HESAPLAMA İŞLEMİ DURDURULUYOR AMA [[[ADET İŞLEMLERİ ESKİ HALİNE GERİ DÖNMÜYOR EKSİLİYOR YANİ]]]------*****------*****------*****------*****------*****------*****------*****------*/

            //                          ŞU AN BUNUNLA UĞRAŞIYORUM [[ AZ SONRA BAKICAM ]]  [[ BİTİRİLDİ ]]



        }

    }
}

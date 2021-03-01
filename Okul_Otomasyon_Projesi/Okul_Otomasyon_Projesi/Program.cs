using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul_Otomasyon_Projesi
{
    class Program
    {
        static void Main(string[] args)
        {
            
                        int Girdi1, Yas;
                        long Tc = '0', Sifre;
                        string Ad, Soyad, BabaAdi, AdSoyad = "a", Giris;            

                        Menu:

                        Console.WriteLine("OKUL OTOMASYON PROJESİ");
                        Console.WriteLine("----------------------");
                        Console.WriteLine("(1) Kayıt Ol\n(2) Giriş\n(3) Çıkış");
                        Girdi1 = Convert.ToInt32(Console.ReadLine());

                        switch(Girdi1)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Sırasıyla Ad, Soyad, Yaş, TC No, Baba Adı Giriniz");
                                Ad = Console.ReadLine();
                                Soyad = Console.ReadLine();
                                Yas = Convert.ToInt32(Console.ReadLine());
                                Tc = Convert.ToInt64(Console.ReadLine());
                                BabaAdi = Console.ReadLine();
                                AdSoyad = Ad + Soyad;

                                Random rastgele = new Random();
                                int OkulNo = rastgele.Next(1000);

                                Console.WriteLine("\n\n Kayıt İşlemi Başarılı Bir Şekilde Tamamlanmıştır LÜTFEN BEKLEYİN...!");
                                System.Threading.Thread.Sleep(3000);
                                Console.Clear();

                                Console.WriteLine("ÖĞRENCİ PROFİLİ");
                                Console.WriteLine("---------------");
                                Console.WriteLine("Ad : {0}    Soyad : {1}    Yaş : {2}    Tc No : {3}    Baba Adı : {4}    Okul No : {5}", Ad, Soyad, Yas, Tc, BabaAdi, OkulNo);
                                Console.WriteLine("\n--------------------------------------------------------------------------------------");
                                Console.WriteLine("Kullanıcı Adınız : {0}       Şifreniz : {1}", AdSoyad, Tc);
                                Console.WriteLine("--------------------------------------------------------------------------------------");
                                Console.Write("\n\nGİRİŞ EKRANINA YÖNLENDİRİLİYORSUNUZ LÜTFEN BEKLEYİN...");
                                System.Threading.Thread.Sleep(8000);
                                Console.Clear();
                                goto Menu;

                            case 2:
                                Console.Clear();
                                GirisMenu:
                                Console.Write("Kullanıcı Adı Giriniz : ");
                                Giris = Console.ReadLine();
                                Console.Write("Şifre Giriniz : ");
                                Sifre = Convert.ToInt64(Console.ReadLine());

                                if(Giris == AdSoyad && Sifre == Tc)
                                {
                                    Console.WriteLine("\nGiriş İşlemi Başarılı HOŞGELDİNİZ...");
                                }

                                else
                                {
                                    Console.WriteLine("\nKullanıcı Adı Veya Şifre Yanlış");
                                    Console.WriteLine("\nYÖNLENDİRİLİYORSUNUZ...");
                                    System.Threading.Thread.Sleep(2500);
                                    Console.Clear();
                                    goto GirisMenu;
                                }                    
                                break;
                            case 3:
                                  goto Bitis;

                            default:
                                Console.WriteLine("\nHatalı Tuşlama Yaptınız.");
                                goto Bitis;


                        }

                           Bitis:
            
                                 Console.Write("\n\nProgram Sonlandırıldı Çıkmak İçin Bir Tuşa Basınız...");
                                 Console.ReadLine();

        }
    }
}

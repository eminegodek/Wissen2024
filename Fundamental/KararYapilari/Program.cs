namespace KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region konu anlatimi
            //klavyeden girilen su sicakligina göre madde kati,sivi,gaz söyleyiniz.

            //short SuSicakligi; //short tamsayi degiskenler icin

            //Console.Write("Suyun Sicakligini giriniz:");
            //SuSicakligi = short.Parse(Console.ReadLine()); //parse= bir sayının dize gösterimini 32 bit imzalı tamsayı esdegerine dönüstürür. convert de parse yerine kullanılıyor.


            //if (SuSicakligi == 0)
            //{
            //    Console.WriteLine();
            //}
            //else
            //{
            //    Console.WriteLine();
            //}


            //if (SuSicakligi > 100)
            //{
            //    Console.WriteLine("Gaz Halindedir");
            //}
            //else if (SuSicakligi > 0)
            //{
            //    Console.WriteLine("Sivi Haldedir");
            //}
            //else
            //{
            //    Console.WriteLine("Kati haldedir");
            //} 
            #endregion
            #region ekranda haftanin lacinci gununde oldugunu isteyin ve gunu yazdırın.1. gün pazartesidir.
            //1. metod
            //string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            //Console.Write("Haftanın kaçıncı günündesiniz? (1-7): ");

            //int gunSayisi;


            //if (int.TryParse(Console.ReadLine(), out gunSayisi))
            //{

            //    if (gunSayisi >= 1 && gunSayisi <= 7)
            //    {

            //        Console.WriteLine($"Bugün: {gunler[gunSayisi - 1]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Geçersiz gün numarası. Lütfen 1 ile 7 arasında bir sayı girin.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
            //}

            //2.metod
            //byte gun;
            //string temp;
            //Console.WriteLine("Bulundugunuz gunu giriniz.");
            //temp = Console.ReadLine();
            //if (temp != null) ;
            //{
            //    gun = byte.Parse(temp);
            //    if (gun >= 1 && gun <= 7)
            //    {
            //        if (gun == 1)
            //        {
            //            Console.WriteLine("Pazartesi");
            //        }
            //        else if (gun == 2)
            //        {
            //            Console.WriteLine("Sali");
            //        }
            //        else if (gun == 3)
            //        {
            //            Console.WriteLine("Carsamba");
            //        }
            //        else if (gun == 4)
            //        {
            //            Console.WriteLine("Persembe");
            //        }
            //        else if (gun == 5)
            //        {
            //            Console.WriteLine("Cuma");
            //        }
            //        else if (gun == 6)
            //        {
            //            Console.WriteLine("Cumartesi");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Pazar");
            //        }

            //    }
            //    else

            //        Console.WriteLine("Lütfen girdiginiz rakami kontrol ediniz.");
            //}
            #endregion
            #region Urun Tanimlama odev1

            //string urun;
            //Console.WriteLine("Urun giriniz!");
            //urun = Console.ReadLine();

            //if (urun == "Domates" || urun == "Biber" || urun == "Patlican")
            //{
            //    Console.WriteLine("Sebze reyonuna gidiniz");
            //}
            //else if (urun == "Dis macunu" || urun == "Parfum" || urun == "Krem")
            //{
            //    Console.WriteLine("Kozmetik reyonuna gidiniz");
            //}
            //else if (urun == "Telefon" || urun == "Bilgisayar" || urun == "Ses sistemleri")
            //{
            //    Console.WriteLine("Teknoloji reyonuna gidiniz");
            //}
            //else
            //    Console.WriteLine("Bu urun bizde yoktur.");

            #endregion
            #region Soru odev 2,3

            //Urun fiyati:5 Tl olsun
            //Disaridan girilecek siparis sayisina gore
            //20 de az ise toplam ucretten % 5 indirim yapilacak
            //20 - 50 arasinda ise % 10 indirim
            //50 - 100 arasinda ise % 15 indirim
            //100 ve uzeri icin % 20 indirim yapilsin
            //Ekrana Toplam tutar ,indirim miktari ve Odenecek tutar bilgilerini yazdirin

            //decimal urunFiyat = 5m;
            //decimal toplamTutar;
            //decimal odenecekTutar;
            //decimal indirimMiktari;
            //decimal indirimYuzdesi;


            //Console.WriteLine("Siparis sayisi giriniz");
            //decimal siparisSayisi = decimal.Parse(Console.ReadLine());

            //if (siparisSayisi < 20)
            //{
            //    indirimYuzdesi = 0.05m;

            //}
            //else if (20 <= siparisSayisi || siparisSayisi < 50)
            //{
            //    indirimYuzdesi = 0.10m;
            //}
            //else if (50 <= siparisSayisi || siparisSayisi < 100)
            //{
            //    indirimYuzdesi = 0.15m;
            //}
            //else
            //{
            //    indirimYuzdesi = 0.20m;
            //}
            //toplamTutar = (5 * siparisSayisi);
            //odenecekTutar = toplamTutar - (indirimYuzdesi * toplamTutar);
            //indirimMiktari = toplamTutar - odenecekTutar;
            //{
            //    Console.WriteLine($"Toplam tutar: {toplamTutar} , Odenecek tutar: {odenecekTutar} , Indirim miktarı: {indirimMiktari} ");
            //}



            //***********************************************
            /* 2 vize 1 final okutun . vizenin %30 finalin %70'ni alin 
         * 
         * Ckan sonuc  0-30 arasinda ise FF
         * 30-50 araligi DD
         * 50-70 arasi BB
         * 70-100 arasi AA
         * Olacak sekilde kullaniciyi bilgilendirin.
        */

            //decimal vize;
            //decimal final;
            //decimal vizeOrtalama;


            //Console.WriteLine("1.Vize notunu giriniz:");
            //double vize1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("2.Vize notunu giriniz:");
            //double vize2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Final notunu giriniz:");
            //double final = double.Parse(Console.ReadLine());

            ////vizeOrtalama = (vize1 + vize2) / 2;
            ////vize = vizeOrtalama * 0.3m;
            ////final = final1 * 0.7m;
            ////ortalama = (vize + final) / 2;


            //double ortalama = (vize1 + vize2) / 2 * 0.3 + (final * 0.7);
            //string harfNotu = "AA,BB,DD,FF";


            //if (ortalama > 0 && ortalama < 30)

            //{ harfNotu = "FF"; }

            //else if (ortalama >= 30 && ortalama < 50)

            //{ harfNotu = "DD"; }

            //else if (ortalama >= 50 && ortalama < 70)

            //{ harfNotu = "BB"; }

            //else if (ortalama >= 70 && ortalama <= 100)

            //{ harfNotu = "AA"; }

            //else
            //{
            //    Console.WriteLine("Lutfen 0-100 arası degerler giriniz.");
            //}

            //Console.WriteLine($"Notunuz: {ortalama}");

            //Console.WriteLine($"Notunuz: {harfNotu}");

            #region Ternary IF
            //string plakakodu;
            //Console.WriteLine("Plaka kodunu giriniz");
            //plakakodu = Console.ReadLine();

            //if (plakakodu == "01")
            //{
            //    Console.WriteLine("Adana");
            //}
            //else if (plakakodu == "02")
            //{
            //    Console.WriteLine("Adiyaman");
            //}
            //else if (plakakodu == "03")
            //{
            //    Console.WriteLine("Afyon");
            //}
            //else if (plakakodu == "04")
            //{
            //    Console.WriteLine("Agri");
            //}
            //else if (plakakodu == "05")
            //{
            //    Console.WriteLine("Amasya");
            //}
            //else if (plakakodu == "06")
            //{
            //    Console.WriteLine("Ankara");
            //}
            //else if (plakakodu == "07")
            //{
            //    Console.WriteLine("Antalya");
            //}
            //else if (plakakodu == "08")
            //{
            //    Console.WriteLine("Artvin");
            //}
            //else if (plakakodu == "09")
            //{
            //    Console.WriteLine("Aydin");
            //}
            //else if (plakakodu == "10")
            //{
            //    Console.WriteLine("Balikesir");
            //}

            //switch (plakakodu)
            //{

            //    case "01":
            //        Console.WriteLine("Adana");
            //        break;
            //    case "02":
            //        Console.WriteLine("Adiyaman");
            //        break;
            //    case "03":
            //        Console.WriteLine("Afyon");
            //        break;
            //    case "04":
            //        Console.WriteLine("Agri");
            //        break;
            //    case "05":
            //        Console.WriteLine("Amasya");
            //        break;
            //    case "06":
            //        Console.WriteLine("Ankara");
            //        break;
            //    case "07":
            //        Console.WriteLine("Antalya");
            //        break;
            //    case "08":
            //        Console.WriteLine("Artvin");
            //        break;
            //    case "09":
            //        Console.WriteLine("Aydin");
            //        break;
            //    case "10":
            //        Console.WriteLine("Balikesir");
            //        break;
            //    default:
            //        // Yukaridakilerin hicbiri olmaz ise default kismi calisir
            //        Console.WriteLine("Tanimsiz ");
            //        break;
            //}

            //ornek : swich-case ile girilen rakama göre ay bilgisini bulma.

            string ay;
            Console.WriteLine("Ay numarasını giriniz:");
            ay = Console.ReadLine();

            switch (ay)
            {
                case "1":
                    Console.WriteLine("Ocak");
                    break;
                case "2":
                    Console.WriteLine("Şubat");
                    break;
                case "3":
                    Console.WriteLine("Mart");
                    break;
                case "4":
                    Console.WriteLine("Nisan");
                    break;
                case "5":
                    Console.WriteLine("Mayıs");
                    break;
                case "6":
                    Console.WriteLine("Haziran");
                    break;
                case "7":
                    Console.WriteLine("Temmuz");
                    break;
                case "8":
                    Console.WriteLine("Ağustos");
                    break;
                case "9":
                    Console.WriteLine("Eylül");
                    break;
                case "10":
                    Console.WriteLine("Ekim");
                    break;
                case "11":
                    Console.WriteLine("Kasım");
                    break;
                case "12":
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Yanlış sayı girdiniz.");
                    break;
            }



            #endregion




            #endregion
        }
    }
}
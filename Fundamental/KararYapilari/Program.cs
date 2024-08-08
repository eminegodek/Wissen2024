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
        }
    }
}
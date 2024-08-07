namespace DegiskenTanimlama
{
    internal class Program
    {
        static void Main(string[] args) //bu bir metod
        {
            #region Kisa Yollar
            // ctrl+k+s => region icine alir
            // ctrl+k+c => yorum satiri olur
            // ctrl+k+u => yorum satirindan cikarir
            #endregion

            #region Degisken Yazim Tavsiyeleri
            // pascal case => WriteLine
            // camel case => writeLine
            // snake case => write.line
            // kebap case => write-line
            #endregion

            #region Degisken Tanimlama Kurallari
            //string adi, soyadi = "Yilmaz";
            //DateTime dogumTarihi = DateTime.Now;
            //byte ayakNumarasi = 44;
            //byte? AyakNo = 33;
            //bool calisiyormu = true;
            //adi = "Ali";
            //string tcno = "12345678901";

            //Console.WriteLine(adi);
            //Console.WriteLine(soyadi);
            //Console.WriteLine("Hello,World!"); 
            #endregion
            #region DEgisken Uzunluklari
            Console.WriteLine("byte bveri tipi");
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            Console.WriteLine("short bveri tipi");
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            Console.WriteLine("ushort bveri tipi");
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);



            #endregion
        }
    }
}
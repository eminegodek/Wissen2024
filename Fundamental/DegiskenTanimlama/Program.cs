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
            Console.WriteLine("byte bveri tipi ");
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            Console.WriteLine("short veri tipi ");
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);

            Console.WriteLine("ushort veri tipi ");
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);

            Console.WriteLine("ushort veri tipi ");
            Console.WriteLine(UInt16.MinValue);
            Console.WriteLine(UInt16.MaxValue);
            Console.WriteLine("int veri tipi ");
            Console.WriteLine(Int32.MinValue);
            Console.WriteLine(Int32.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);


            Console.WriteLine("uint veri tipi ");
            Console.WriteLine(UInt32.MinValue);
            Console.WriteLine(uint.MaxValue);

            Console.WriteLine("long veri tipi ");
            Console.WriteLine(Int64.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine("ulong veri tipi ");
            Console.WriteLine(UInt64.MinValue);
            Console.WriteLine(ulong.MaxValue);

            #region Kusuratli sayilar
            Console.WriteLine("küsüratli sayilar ");
            Console.WriteLine("float veri tipi ");
            Console.WriteLine(float.MinValue);
            Console.WriteLine(Single.MaxValue);
            Console.WriteLine("double veri tipi ");
            Console.WriteLine(double.MinValue);
            Console.WriteLine(Double.MaxValue);

            Console.WriteLine("decimal  veri tipi ");
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(Decimal.MaxValue);

            #endregion
        }
    }
}
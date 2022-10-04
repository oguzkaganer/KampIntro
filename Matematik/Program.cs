using System.Security.Cryptography.X509Certificates;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();


            dortIslem.Topla(5, 6);

            dortIslem.Cikart(15, 5);
            dortIslem.Cikart(12, 5);

            bool x = true;

            int sonuc = x==true ? 1 : 0;

            int sayi = 20;

            string deger = sayi < 25 ? "A" : sayi == 25 ? "B" : "C";

            Console.WriteLine(deger);

            Console.ReadKey();
        }
    }
}
namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { " Oğuz", "  Furkan", "   Yunus", "    Aydın" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            Console.WriteLine("----------------");

            List<string> isimler2 = new List<string> { "    Oğuz", "   Furkan", "  Yunus", " Aydın" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Harun");
            Console.WriteLine(isimler2[4]);










            Console.ReadLine();
        }
    }
}
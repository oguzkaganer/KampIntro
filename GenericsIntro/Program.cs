namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Oğuz");
            isimler.Add("Harun");

            Console.WriteLine(isimler.Count);


            Console.ReadLine();
        }
    }
}
namespace DictionarySınıfı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainClass mainClass = new MainClass();
            mainClass.MainStart();

            Dictionary<int, string> books = new Dictionary<int, string>();

            books.Add(101, "Tutunamayanlar");
            books.Add(105, "Suç ve Ceza");

            Dictionary<int, string>.KeyCollection KeyList = books.Keys;
            Dictionary<int, string>.ValueCollection ValueList = books.Values;

            foreach (KeyValuePair<int, string> item in books)
            {
                Console.WriteLine("Numara:{0} - Kitap:{1}", item.Key, item.Value);
            }

            foreach (int Key in KeyList)
            {
                Console.WriteLine(Key);
            }

            foreach (string Value in ValueList)
            {
                Console.WriteLine(Value);
            }



            Console.WriteLine("Kitap numarası giriniz : ");
            int bookNum = int.Parse(Console.ReadLine());

            string isim = "";
            if (books.TryGetValue(bookNum, out isim))
                Console.WriteLine(isim);
            else
                Console.WriteLine("Kitap bulunamadı !");


            try
            {
                Console.WriteLine(bookNum + " Numaralı Kitap : " + books[bookNum]);
            }
            catch (Exception)
            {
                Console.WriteLine("Kitap Bulunamadı ! ! !");
            }


            Console.ReadLine();
        }
    }

    public class MainClass
    {
        Dictionary<int, string> DicList = new Dictionary<int, string>();

        public void MainStart()
        {
            DicList.Add(1, "Oğuz");
            DicList.Add(2, "Harun");
            DicList.Add(3, "Senem");
            DicList.Add(4, "Kübra");
            DicList.Add(5, "Hilal");

            if(DicList.ContainsKey(6))
                Console.WriteLine("Var");
            else
                Console.WriteLine("Yok");

            Console.WriteLine(DicList[1]);
            Console.WriteLine(ListedeAra(5));
        }

        public string ListedeAra(int aranacak)
        {
            if (DicList.TryGetValue(aranacak, out string result))
                return result;
            else
                return "Bu key numarası mevcut değil.";
        }

    }
}
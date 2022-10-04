namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Oğuz";
            musteri1.Soyad = "ER";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Kadir";
            musteri2.Soyad = "Özdemir";

            List<Musteri> musteriler = new List<Musteri>();

            MusteriManager.Ekle(musteriler, musteri1);
            MusteriManager.Ekle(musteriler, musteri2);
            MusteriManager.Listele(musteriler);
            Console.WriteLine();
            MusteriManager.Sil(musteriler, musteri2);
            MusteriManager.Listele(musteriler);


            Console.ReadLine();
        }
    }
}
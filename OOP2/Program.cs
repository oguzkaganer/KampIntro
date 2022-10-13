namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "0001";
            musteri1.Adi = "Oğuz Kağan";
            musteri1.Soyadi = "ER";
            musteri1.TcNo = "21541212523";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "0002";
            musteri2.SirketAdi = "SmartPro";
            musteri2.VergiNo = "25412020021";

            //GercekMusteri musteri3 = new Musteri();  -  !!! bu şekilde olamaz.
            Musteri musteri4 = new GercekMusteri();
            Musteri musteri5 = new TuzelMusteri();


        }
    }
}
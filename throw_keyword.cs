namespace ThrowKeyword
{
    public partial class ThrowKeywordClass
    {
        public void ThrowKeywordDers()
        {
            System.Console.Write("Bölünecek sayi: ");
            int bolunecek = int.Parse(Console.ReadLine()!);

            System.Console.Write("Bölen sayi: ");
            int bolen = int.Parse(Console.ReadLine()!);

            try
            {
                if (bolen == 0)
                {
                    throw new Exception("Bölen 0 olmaz. Tekrar çalıştırın!");
                }
                decimal sonuc = bolunecek / bolen;
                System.Console.WriteLine(sonuc);
            }
            catch (Exception hata)
            {
                System.Console.WriteLine("Hata Oluştu");
                System.Console.WriteLine(hata.Message);
            }
        }
    }
}

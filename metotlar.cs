namespace Metotlar
{
    public partial class MetotlarClass
    {
        public void MetotlarDers()
        {
            string[] meyveler = new string[] { "elma", "armut", "üzüm", };

            DiziYazdir(meyveler);

            TersCevir(meyveler);

            System.Console.WriteLine("---");
            DiziYazdir(meyveler);

            int sonucOne = Topla(3, 4);
            int sonucTwo = Topla(3, 4, 5);
            System.Console.WriteLine(sonucOne + " --- " + sonucTwo);

            // params keyword yöntem bir
            int[] sayilar = new int[] { 4, 5, 6 };
            int sonucThree = ToplaSinirsiz(sayilar);
            System.Console.WriteLine(sonucThree);

            // params keyword yöntem iki
            int sonucFour = ToplaSinirsizParams(7, 8, 9);
            System.Console.WriteLine(sonucFour);
        }

        // void metot geri değer döndürmez
        static void DiziYazdir(string[] dizi)
        {
            foreach (var item in dizi)
            {
                System.Console.WriteLine(item);
            }
        }

        // string dizi metot. geri değer döndürür.
        static string[] TersCevir(string[] dizi)
        {
            Array.Reverse(dizi);
            return dizi;
        }

        // varsayılan değerli, opsiyonel parametreli metot
        // opsiyonel parametreler en sona yazılmalı!
        static int Topla(int sayiOne, int SayiTwo, int sayiThree = 0)
        {
            int toplam = sayiOne + SayiTwo + sayiThree;
            return toplam;
        }

        static int ToplaSinirsiz(int[] sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam = toplam + item;
            }
            return toplam;
        }

        static int ToplaSinirsizParams(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam = toplam + item;
            }
            return toplam;
        }
    }
}

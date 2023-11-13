namespace AlanHesaplama
{
    public partial class AlanHesaplamaClass
    {
        public void AlanHesaplamaDers()
        {
            int secim;
            bool result;
            do
            {
                MenuYaz();

                do
                {
                    System.Console.Write("Seçiminiz : ");
                    string secimStr = Console.ReadLine()!;
                    result = int.TryParse(secimStr, out secim);
                } while (result == false);

                switch (secim)
                {
                    case 1:
                        KareAlanhesaplama();
                        break;
                    case 2:
                        DikdortgenAlanhesaplama();
                        break;
                    case 3:
                        UcgenAlanhesaplama();
                        break;
                    case 4:
                        YamukAlanhesaplama();
                        break;
                    default:
                        break;
                }
            } while (secim != 0);
        }

        static void MenuYaz()
        {
            System.Console.Clear();

            EkranaBaslikYaz("Alan Hesaplama Prg.");
            EkranaBaslikYaz("Menü");

            System.Console.WriteLine("1 - Kare Alanı Hesapla");
            System.Console.WriteLine("2 - Dikdörtgen Alanı Hesapla");
            System.Console.WriteLine("3 - Üçgen Alanı Hesapla");
            System.Console.WriteLine("4 - Yamuk Alanı Hesapla");
            System.Console.WriteLine("0 - Çıkış");
            System.Console.WriteLine();
        }

        static void EkranaBaslikYaz(string baslik)
        {
            System.Console.WriteLine(baslik);
            for (int i = 0; i < baslik.Length; i++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
        }

        static void DevamUyarisi()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Devam etmek için bir tuşa basın.");
            Console.ReadKey();
        }

        static void KareAlanhesaplama()
        {
            Console.Clear();
            EkranaBaslikYaz("Kare Alan Hesaplama");
            System.Console.Write("Lütfen a kenar uzunlğunu giriniz : ");
            int a = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine();
            System.Console.WriteLine("Kare alanı : " + (a * a));
            DevamUyarisi();
        }

        static void DikdortgenAlanhesaplama()
        {
            Console.Clear();
            EkranaBaslikYaz("Dikdortgen Alan Hesaplama");
            System.Console.Write("Lütfen a kenar uzunlğunu giriniz : ");
            int a = int.Parse(Console.ReadLine()!);
            System.Console.Write("Lütfen b kenar uzunlğunu giriniz : ");
            int b = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine();
            System.Console.WriteLine("Dikdortgen alanı : " + (a * b));
            DevamUyarisi();
        }

        static void UcgenAlanhesaplama()
        {
            Console.Clear();
            EkranaBaslikYaz("Ucgen Alan Hesaplama");
            System.Console.Write("Lütfen a kenar uzunlğunu giriniz : ");
            double a = int.Parse(Console.ReadLine()!);
            System.Console.Write("Lütfen h yükseklik uzunlğunu giriniz : ");
            double h = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine();
            System.Console.WriteLine("Ucgen alanı : " + (a * h) / 2d);
            DevamUyarisi();
        }

        static void YamukAlanhesaplama()
        {
            Console.Clear();
            EkranaBaslikYaz("Yamuk Alan Hesaplama");
            System.Console.Write("Lütfen a kenar uzunlğunu giriniz : ");
            double a = int.Parse(Console.ReadLine()!);
            System.Console.Write("Lütfen b kenar uzunlğunu giriniz : ");
            double b = int.Parse(Console.ReadLine()!);
            System.Console.Write("Lütfen h yükseklik uzunlğunu giriniz : ");
            int h = int.Parse(Console.ReadLine()!);
            System.Console.WriteLine();

            double sub = (a + b) / 2d;
            double result = sub * Convert.ToDouble(h);
            System.Console.WriteLine("Yamuk alanı : " + result);
            DevamUyarisi();
        }
    }
}

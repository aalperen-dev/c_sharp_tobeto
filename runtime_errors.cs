using System.Net.WebSockets;

namespace RuntimeErrors
{
    public partial class RuntimeErrorsClass
    {
        public void RuntimeErrorsDers()
        {
            // proje çalışırken oluşabilecek hatalar

            System.Console.WriteLine("Bölünecek sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine()!);

            System.Console.WriteLine("Bölen sayı giriniz:");
            int bolen = int.Parse(Console.ReadLine()!);

            if (bolen == 0)
            {
                System.Console.WriteLine("Bölen sayı 0 olamaz! Yeni sayı giriniz:");
                bolen = int.Parse(Console.ReadLine()!);
            }
            try
            {
                decimal sonuc = sayi / bolen;
                System.Console.WriteLine("Sonuc: " + sonuc);
            }
            catch
            {
                System.Console.WriteLine("Hata!");
            }
        }
    }
}

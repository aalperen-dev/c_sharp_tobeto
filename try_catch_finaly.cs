namespace TryCatchFinaly
{
    public partial class TryCatchFinalyClass
    {
        public void TryCatchFinalyDers()
        {
            System.Console.Write("Bir sayı giriniz:");
            string sayiStr = Console.ReadLine()!;
            int sayiInt = int.Parse(sayiStr);

            System.Console.Write("Bir bölen sayı giriniz:");
            string sayiBolenStr = Console.ReadLine()!;
            int sayiBolenInt = int.Parse(sayiBolenStr);

            try
            {
                decimal sonuc = sayiInt / sayiBolenInt;
                System.Console.WriteLine("Bolum: " + sonuc);
            }
            catch
            {
                System.Console.WriteLine("Hatalı işlem!");
            }
            finally
            {
                System.Console.WriteLine("İşlem sonlandı!");
            }
        }
    }
}

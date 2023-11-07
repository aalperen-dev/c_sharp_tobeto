namespace TernaryOperator
{
    public partial class TernaryOperatorClass
    {
        public void TernaryOperatorDers()
        {
            // ternary operator (kısa if)

            int sayi = 26;

            string sonuc = (sayi == 26) ? sonuc = "Esk" : "Esk değil";

            System.Console.WriteLine(sonuc);

            string sonucTwo =
                sayi == 26
                    ? sonucTwo = "Esk"
                    : sayi == 16
                        ? "Bursa"
                        : "Basarısız";
        }
    }
}

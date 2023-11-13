namespace ResursiveMetot
{
    public partial class ResursiveMetotClass
    {
        public void ResursiveMetotDers()
        {
            int sayi = 5;

            int faktSonuc = FaktoriyelHesap(sayi);

            System.Console.WriteLine(faktSonuc);
        }

        static int FaktoriyelHesap(int sayi)
        {
            if (sayi == 1)
            {
                return 1;
            }
            else
            {
                return sayi * (FaktoriyelHesap(sayi - 1));
            }
        }
    }
}

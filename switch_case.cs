namespace SwitchCase
{
    public partial class SwitchCaseClass
    {
        public void SwitchCaseDers()
        {
            // swtich case
            // bir aralık kontrol edilemez. mutlak eşitlik ontrol edilir.
            int sayi = 10;

            switch (sayi)
            {
                case 5:
                    System.Console.WriteLine("sayi 5");
                    break;
                case 3:
                    System.Console.WriteLine("sayi 3");
                    break;
                case 6:
                case 2:
                    System.Console.WriteLine("sayi 2 veya 6");
                    break;

                default:
                    System.Console.WriteLine("Test");
                    break;
            }
        }
    }
}

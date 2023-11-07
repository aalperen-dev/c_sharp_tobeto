namespace MantiksalOperatorler
{
    public partial class MantiksalOperatorlerClass
    {
        public void MantiksalOperatorlerDers()
        {
            int sayiOne = 5;
            int sayiTwo = 10;

            if (sayiOne < sayiTwo && sayiOne > 1)
            {
                System.Console.WriteLine("başarılı");
            }

            if (!(sayiOne == 6))
            {
                System.Console.WriteLine("değil alındı");
            }

            // operatorler
            // && ve
            // || veya
            // < küçük
            // > büyük
            // >= büyük eşit
            // <= küçük eşit
            // == eşitlik operatörü
            // ! değil alma
        }

        public void MantiksalOperatorlerOrnek()
        {
            bool sinavaGirdimi = true;
            int not = 86;
            string krediNotu = "";

            if (sinavaGirdimi == true)
            {
                if (not <= 100 && not >= 90)
                {
                    krediNotu = "AA";
                }
                else if (not <= 89 && not >= 80)
                {
                    krediNotu = "BA";
                }
                else if (not <= 79 && not >= 70)
                {
                    krediNotu = "CB";
                }
                else if (not <= 69 && not >= 50)
                {
                    krediNotu = "DD";
                }
                else
                {
                    krediNotu = "FF";
                }
                System.Console.WriteLine("Sınava girdiniz");
                System.Console.WriteLine("Notunuz: " + krediNotu);
            }
            else
            {
                System.Console.WriteLine("Sınava girmediniz!");
            }
        }
    }
}

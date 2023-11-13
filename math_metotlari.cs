namespace MathMetotlari
{
    public partial class MathMetotlariClass
    {
        public void MathMetotlariDers()
        {
            double val = 3.46;

            // pi
            System.Console.WriteLine(Math.PI);

            // floor
            System.Console.WriteLine(Math.Floor(val));

            // ceiling
            System.Console.WriteLine(Math.Ceiling(val));

            // round
            System.Console.WriteLine(Math.Round(val));
            System.Console.WriteLine(Math.Round(val, 1)); //overloadlar var

            // max
            System.Console.WriteLine(Math.Max(val, 3.64)); //max olani döndürür

            // min
            System.Console.WriteLine(Math.Min(val, 3.64)); //max olani döndürür

            // pow, üs alma
            System.Console.WriteLine(Math.Pow(4, 2)); //4 üzeri 2

            // sqrt, kare kök alma
            System.Console.WriteLine(Math.Sqrt(16));
        }
    }
}

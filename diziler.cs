namespace Diziler
{
    public partial class DizilerClass
    {
        public void DizilerDers()
        {
            // string dizi tanımlama
            string[] stringDizi = new string[3];
            stringDizi[0] = "alp";
            stringDizi[1] = "eren";
            stringDizi[2] = "alper";

            System.Console.WriteLine(stringDizi[1]);

            for (int i = 0; i < stringDizi.Length; i++)
            {
                System.Console.WriteLine(stringDizi[i]);
            }

            // tanımlama ve içine eleman atama
            int[] intDizi = new int[] { 1, 2, 3, 4, 5 };
        }
    }
}

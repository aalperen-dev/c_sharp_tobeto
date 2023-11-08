using System.Globalization;

namespace ForEachDongusu
{
    public partial class ForEachDongusuClass
    {
        public void ForEachDongusuDers()
        {
            string[] meyveler = new string[] { "elma", "armut", "üzüm", };

            foreach (var item in meyveler)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}

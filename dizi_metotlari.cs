namespace DiziMetotlari
{
    public partial class DiziMetotlariClass
    {
        public void DiziMetotlariDers()
        {
            string[] meyveler = new string[] { "elma", "armut", "üzüm", "mandalin" };

            // clone alma obje döndüreceği için casting yapıtık.
            string[] meyvelerClone = (string[])meyveler.Clone();

            // kopya alma
            string[] meyvelerCopy = new string[meyveler.Length];
            meyveler.CopyTo(meyvelerCopy, 0); // kopyanın atılcağı dizi ve başlangıç index'i

            // sort, siralama
            Array.Sort(meyveler);

            // reverse, tersten sıralama
            Array.Reverse(meyveler);

            // resize
            Array.Resize(ref meyveler, meyveler.Length + 2);
            meyveler[meyveler.Length - 2] = "erik";
            meyveler[meyveler.Length - 1] = "portakal";

            // index of
            Array.IndexOf(meyveler, "üzüm"); // sonuç bulamazsa "-1" döner
        }
    }
}

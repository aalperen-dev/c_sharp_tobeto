namespace StringMetotlari
{
    public partial class StringMetotlariClass
    {
        public void StringMetotlariDers()
        {
            string txt = "   Ne mutlu Türküm diyene!   ";

            // trim
            txt.Trim();
            txt.TrimStart();
            txt.TrimEnd();

            // tolover
            txt.ToLower();

            // toupper
            txt.ToUpper();

            // substring
            txt.Substring(3);
            txt.Substring(3, 5);

            // reverse
            txt.Reverse();

            // indexof
            txt.IndexOf("m"); //geriye int döndürür

            // remove
            txt.Remove(3, 5);

            // contains
            txt.Contains("t"); //geriye bool döndürür

            // replace
            txt.Replace("mutlu", "mutluyum");
            txt.Replace(" ", ""); //boşluk yoketme

            // split
            txt.Split(" "); //geriye dizi döndürür

            // join
            string.Join(",", txt);
        }
    }
}

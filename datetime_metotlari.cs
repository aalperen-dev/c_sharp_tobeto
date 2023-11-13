namespace DateTimeMetotlari
{
    public partial class DateTimeMetotlariClass
    {
        public void DateTimeMetotlariDers()
        {
            System.Console.WriteLine(DateTime.Now);
            System.Console.WriteLine(DateTime.Now.Day);
            System.Console.WriteLine(DateTime.Now.Month);
            System.Console.WriteLine(DateTime.Now.Year);
            System.Console.WriteLine(DateTime.Now.Millisecond);
            System.Console.WriteLine(DateTime.Now.Second);
            System.Console.WriteLine(DateTime.Now.Minute);
            System.Console.WriteLine(DateTime.Now.Hour);

            // gün ekleme
            DateTime.Now.AddDays(10);
            // saat ekleme
            DateTime.Now.AddHours(12);
            // ay ekleme
            DateTime.Now.AddMonths(1);
            // yıl ekleme
            DateTime.Now.AddYears(1);

            //
            DateTime.Now.ToShortDateString(); //gün ay yıl
            //
            DateTime.Now.ToLongDateString(); //gün ay yıl + gün adı
            //
            DateTime.Now.ToShortTimeString(); // saat dakika
            //
            DateTime.Now.ToLongTimeString(); // saat dakika saniye

            DateTime tarih = new DateTime(1988, 10, 29);
        }
    }
}

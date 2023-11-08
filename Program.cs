using System;
using BreakContinueKeywords;
using Diziler;
using DiziMetotlari;
using ForDongusu;
using ForEachDongusu;
using MantiksalOperatorler;
using Metotlar;
using RuntimeErrors;
using SwitchCase;
using TernaryOperator;
using TryCatchFinaly;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Implicit ve Explicit Dönüşümler
            // double sayi = 5.5;

            // // ekrana yazdırmada aslında implicit (üstü kapalı) bir dönüşüm yaptık
            // Console.WriteLine(sayi + 5);

            // string metin = "10";

            // System.Console.WriteLine(metin); // çıktı: 10
            // System.Console.WriteLine(metin + 5); // çıktı 105
            // System.Console.WriteLine(metin + 5.ToString()); // çıktı 105

            // // explicit (bilinçli) dönüşüm
            // // double olarak tanımlı sayıyı int'e dönüştürdük.
            // System.Console.WriteLine(Convert.ToInt32(sayi));

            // // boxing
            // // büyük bir veri tipi içine, küçük veri tipini atama işlemi

            // byte kucukVeri = 32;
            // int buyukVeri = kucukVeri;

            // object obj; // değer almazsa null'dır. bütün veri tiplerini kapsar.

            // obj = 5; // obje int oldu
            // obj = "beş"; // obje string oldu
            // obj = true; // obje bool oldu

            // // System.Console.WriteLine(obj + 26); //obje ile diğer tipler birleştirilemez, aritmetik işlem yapılamamaz
            // System.Console.WriteLine(Convert.ToInt32(obj) + 5);

            // // unboxing & casting kavramları
            // object obje1 = 5; // boxing işlemi
            // object obje2 = true; // boxing işlemi

            // int sayiBir = Convert.ToInt32(obje1); // unboxing işlemi

            // int castingOrnek = (int)obje1; // unboxing casting örneği

            // // karar yapıları

            // if (sayi == 5.5)
            // {
            //     System.Console.WriteLine("sayi 5.5");
            // }
            // else
            // {
            //     System.Console.WriteLine("sayi 5 değil");
            // }

            // // nested if
            // if (true)
            // {
            //     if (sayi == 5.5)
            //     {
            //         System.Console.WriteLine("nested if");
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("test");
            //     }
            // }

            MantiksalOperatorlerClass mantiksalOperatorlerClass = new MantiksalOperatorlerClass();
            // mantiksalOperatorlerClass.MantiksalOperatorlerDers();
            // mantiksalOperatorlerClass.MantiksalOperatorlerOrnek();

            TernaryOperatorClass ternaryOperatorClass = new TernaryOperatorClass();
            // ternaryOperatorClass.TernaryOperatorDers();

            SwitchCaseClass switchCase = new SwitchCaseClass();
            // switchCase.SwitchCaseDers();

            TryCatchFinalyClass tryCatchFinalyClass = new TryCatchFinalyClass();
            // tryCatchFinalyClass.TryCatchFinalyDers();

            RuntimeErrorsClass runtimeErrorsClass = new RuntimeErrorsClass();
            // runtimeErrorsClass.RuntimeErrorsDers();

            ForDongusuClass forDongusuClass = new ForDongusuClass();
            // forDongusuClass.ForDongusuDers();

            BreakContinueKeywordsClass breakContinueKeywordsClass =
                new BreakContinueKeywordsClass();
            // breakContinueKeywordsClass.BreakContinueKeywordsDers();

            ForEachDongusuClass forEachDongusuClass = new ForEachDongusuClass();
            // forEachDongusuClass.ForEachDongusuDers();

            DiziMetotlariClass diziMetotlari = new DiziMetotlariClass();
            // diziMetotlari.DiziMetotlariDers();

            MetotlarClass metotlarClass = new MetotlarClass();
            metotlarClass.MetotlarDers();
        }
    }
}

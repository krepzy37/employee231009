using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace employee
{
    class Program
    {
        static double AtlagKor(List<Dolgozo> a)
        {
            int OsszeAd = 0;
            for (int i = 0; i < a.Count; i++)
            {
                OsszeAd += a[i].Age;
            }
            return OsszeAd / a.Count;
        }

        static int CityBudapest(List<Dolgozo> a)
        {
            int szamolo = 0;
            foreach (var b in a)
            {
                if (b.City == "Budapest") szamolo += 1;
            }
            return szamolo;
        }
        static int MaxKor(List<Dolgozo> a)
        {
            int max = a[0].Age;
            int index = 0;
            for (int i = 1; i < a.Count; i++)
            {
                if (a[i].Age > max)
                {
                    max = a[i].Age;
                    index = i;
                }
            }
            return index;
        }
        static string Over30(List<Dolgozo> a)
        {
            bool is30 = false;
            string name30 = String.Empty;
            foreach (var h in a)
            {
                if (h.Age>30)
                {
                    is30 = true;
                    name30 = h.Name;
                }
            }
            return $"{is30};{name30}";
        }
        static void Main(string[] args)
        {
            var dolgozok = new List<Dolgozo>();
            using var sr = new StreamReader(@"..\..\..\src\dolgozok.txt", Encoding.UTF8);
            while (!sr.EndOfStream) dolgozok.Add(new Dolgozo(sr.ReadLine()));
            foreach (var e in dolgozok)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine($"\nÁtlag életkor: {AtlagKor(dolgozok)}");
            Console.WriteLine($"\nBudapestiek száma: {CityBudapest(dolgozok)}");
            Console.WriteLine($"\nLegidősebb személy: {dolgozok[MaxKor(dolgozok)].ToString()}");

            Console.ReadKey(true);

        }
    }
}

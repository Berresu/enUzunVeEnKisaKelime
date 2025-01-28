using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace büüüüüü
{
    internal class Program
    {
        public static string enUzunVeenKisaKelime(string cumle)
        {
            string[] kelimeler = cumle.Split(' ');
            string enKisa = kelimeler[0];
            string enUzun = kelimeler[0];

            foreach (string kelime in kelimeler) {
                if (kelime.Length < enKisa.Length)
                {
                    enKisa = kelime;
                }
                if (kelime.Length > enUzun.Length) {
                    enUzun = kelime;
                }
            }

            return enUzun + " " + enKisa;
        }
        static void Main(string[] args)
        {
            string cumle = "Neden Beni Sadece Sarhoş Olduğunda Arıyorsun...";
            string sonuc = enUzunVeenKisaKelime(cumle);
            Console.WriteLine("En Uzun Ve En Kısa Kelime: " + sonuc);
        }
    }
}

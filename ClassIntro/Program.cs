using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.ızlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.ızlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Pyhton";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.ızlenmeOrani = 80;

            // Console.WriteLine(kurs.1KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmen);
            }


           // Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int ızlenmeOrani { get; set; }
    }
}

using System;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar kelas = new BangunDatar();

            kelas.luas_persegi();

            Console.WriteLine("---------------");

            kelas.luas_segitiga();

            Console.WriteLine("---------------");

            kelas.luas_lingkaran();

            Console.WriteLine("---------------");

            BangunRuang kelas2 = new BangunRuang();

            kelas2.volume_balok();

            Console.WriteLine("---------------");

            kelas2.volume_kubus();

            Console.WriteLine("---------------");
        }
    }
}

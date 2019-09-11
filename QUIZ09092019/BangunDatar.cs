using System;

namespace QUIZ09092019
{
    class BangunDatar
    {
        public void luas_persegi()
        {
            int sisi, luas;

            Console.WriteLine("Menghitung Luas Persegi");

            Console.Write("Masukkan Nilai sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

            luas = sisi * sisi;

            Console.WriteLine("Luas Persegi Adalah "+luas);
        }

        public void luas_segitiga()
        {
            int alas, tinggi, luas;

            Console.WriteLine("Menghitung Luas Segitiga");

            Console.Write("Masukkan Nilai alas : ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan Nilai tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas = alas * tinggi /2;

            Console.WriteLine("Luas Segitiga adalah : "+luas);
        }

        public void luas_lingkaran()
        {
            int r, luas;

            Console.WriteLine("Menghitung Luas Lingkaran");

            Console.Write("Masukkan Nilai Jari-Jari : ");
            r = Convert.ToInt32(Console.ReadLine());

            luas = r * r * 22 /7;

            Console.WriteLine("Luas Lingkaran Adalah : "+luas);
        }
    }

    class BangunRuang
    {
        public void volume_balok()
        {
            int panjang, tinggi, lebar, volume;

            Console.WriteLine("Menghitung Volume Balok");

            Console.Write("masukkan nilai panjang = ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan nilai lebar = ");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("masukkan nilai tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            volume = panjang * lebar * tinggi;

            Console.WriteLine("Volume Balok Adalah : "+volume);
        }

        public void volume_kubus()
        {
            int rusuk, volume;

            Console.WriteLine("Menghitung Volume Kubus");

            Console.Write("Masukkan nilai rusuk : ");
            rusuk = Convert.ToInt32(Console.ReadLine());

            volume = rusuk * rusuk * rusuk;

            Console.WriteLine("Volume Kubus Adalah : "+volume);
        }
    }
}
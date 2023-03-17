using System;

namespace CalculatorConsoleApp
{
    // membuat kelas
    internal class Program
    {
        // membuat fungsi untuk rumus perhitungan sederhana
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }
        static void Main(string[] args)                     // Fungsi main program
        {
            Console.Title = "Aplikasi Calculator";          // Judul Console
            
            // Daftar Menu
            Console.Write("  Pilih Operator Aritmetika");
            Console.WriteLine();
            Console.Write("=============================");
            Console.WriteLine();
            Console.Write(" [1] Penambahan\n [2] Pengurangan\n [3] Perkalian\n [4] Pembagian");
            Console.WriteLine();
            Console.Write("=============================");
            Console.WriteLine();

            Console.Write("Pilih Menu       = ");           // Input Menu
            int menu = int.Parse(Console.ReadLine());
            
            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());          // proces casting

            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());    // proces casting
            Console.Write("=============================");

            switch (menu)       // Memanggil Fungsi sesuai dengan menu yang di input
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Hasil Penambahan  " + a + " + " + b + " = " + Penambahan(a, b));
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Hasil Perkalian   {0} * {1} = {2}", a, b, perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Hasil Pembagian   {0} / {1} = {2}", a, b, pembagian(a, b));
                    break;

                // Jika input menu yang dimasukkan tidak sesuai, maka akan menampilkan tulisan tersebut
                default: 
                    Console.WriteLine();
                    Console.WriteLine("Input Menu Tidak Tersedia");
                    break;
            }
            Console.WriteLine(); // tambahkan baris kosong
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
    }
}
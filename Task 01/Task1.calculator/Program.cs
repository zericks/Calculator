using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";

            Console.WriteLine("Pilih menu calculator:");
            Console.WriteLine("");                   // baris kosong
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("");                   // baris kosong
            Console.Write("Input nomor menu [1..4]: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1 && num <= 4)
            {
                Console.Write("Masukkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Masukkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");                   // baris kosong

                switch (num)
                {
                    case 1:
                        Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + (a + b));
                        break;
                    case 2:
                        Console.WriteLine("Hasil Pengurangan " + a + " - " + b + " = " + (a - b));
                        break;
                    case 3:
                        Console.WriteLine("Hasil Perkalian " + a + " * " + b + " = " + (a * b));
                        break;
                    case 4:
                        if (b != 0)
                        {
                            Console.WriteLine("Hasil Pembagian " + a + " / " + b + " = " + (a / b));
                        }
                        else
                        {
                            Console.WriteLine("Tidak dapat dibagi dengan 0");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Maaf, menu yang Anda pilih tidak tersedia");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Tekan sembarang key untuk keluar");
            Console.ReadKey();
        }
    }
}
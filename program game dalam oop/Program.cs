
using System;

namespace KarakterGame
{
    class Karakter
    {
        public string nama { get; private set; }
        public int kesehatan { get; private set; }
        public int senjata { get; private set; }
        public int posisi { get; private set; } = 0;

        public Karakter(string nama, int kesehatan, int senjata)
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
        }

        public void Serang(Karakter target)
        {
            Console.WriteLine("=====> Mulai menyerang");
            target.TerimaSerang(senjata);
        }

        public void TerimaSerang(int jumlahSerangan)
        {
            kesehatan -= jumlahSerangan;

            Console.WriteLine(
                $"{nama} diserang dengan {jumlahSerangan}. " +
                $"Sisa kesehatan: {kesehatan}"
            );
        }

        public void Heal(int jumlahHealing)
        {
            kesehatan += jumlahHealing;

            Console.WriteLine(
                $"{nama} diheal dengan {jumlahHealing}. " +
                $"Sisa kesehatan: {kesehatan}"
            );
        }

        // Membaca tombol keyboard
        public void Aksi()
        {
            Console.WriteLine("\n=== KONTROL KARAKTER ===");
            Console.WriteLine("Panah Kanan : Maju 2 posisi");
            Console.WriteLine("Panah Kiri  : Mundur 1 posisi");
            Console.WriteLine("Esc         : Keluar dari permainan");

            while (true)
            {
                ConsoleKeyInfo tombol = Console.ReadKey(true);

                if (tombol.Key == ConsoleKey.RightArrow)
                {
                    posisi += 2;
                }
                else if (tombol.Key == ConsoleKey.LeftArrow)
                {
                    posisi -= 1;
                }
                else if (tombol.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("\nPermainan dihentikan.");
                    break;
                }
                else
                {
                    continue;
                }

                Console.WriteLine(
                    $"{nama} sekarang berada di posisi {posisi}"
                );
            }
        }

        public void getData()
        {
            Console.WriteLine(
                $"Karakter: {nama}, Kesehatan: {kesehatan}, Senjata: {senjata}"
            );
        }
    }

    class MainProgram
    {
        static void Main(string[] args)
        {
            Karakter karakter1 = new Karakter("rusdi", 100, 27);
            Karakter musuh = new Karakter("sumanto", 1, 200);

            karakter1.Serang(musuh);
            karakter1.Heal(20);
            karakter1.getData();

            // Menjalankan kontrol keyboard
            karakter1.Aksi();

            Console.WriteLine("Program selesai.");
        }
    }
}

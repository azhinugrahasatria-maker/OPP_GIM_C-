// Gameget
// Genre : PvP
// Karakter : Nama, Kesehatan, 

using System;
namespace KarakterGame
{
    class Karakter
    {
       
        public int jumlahSenjata, power;


        public string nama { get; private set; }
        public int kesehatan { get; private set; }
        public string senjata { get; private set; }


        public Karakter(string nama, int kesehatan, string senjata) //membuat konstruktor
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;

        }

        //public void setData(string namaBaru, string Kesehatanku, string Senjataku, int jumlahSenjata, int Power)
        //{
        //    this.nama = namaBaru;
        //    this.kesehatan = Kesehatanku;
        //    this.senjata = Senjataku;
        //    this.jumlahSenjata = jumlahSenjata;
        //    this.power = Power;
        //}

        //public void getData()
        //{
        //    Console.Write(nama);
        //    Console.Write("/");
        //    Console.Write(kesehatan);
        //    Console.Write("/");
        //    Console.Write(senjata);
        //    Console.Write("/");
        //    Console.Write(jumlahSenjata);
        //    Console.Write("/");
        //    Console.WriteLine(power);
        //}

        public void getData()
        {
            Console.WriteLine($"Karakter: {nama}, Kesehatan: {kesehatan}, Senjata: {senjata}");
        }

        //public void setKesehatan(string kesehatan)
        //{
        //    this.kesehatan = kesehatan;
        //}

        //public void getKesehatan()
        //{
        //    Console.WriteLine(kesehatan);
        //}
    }

    class MainProgram
    {
        static void Main(string[] args)
        {

            Karakter karakter1 = new Karakter("rusdi", 100, "Pistol");
            karakter1.getData();


            //List<Karakter> daftarHero = new List<Karakter>();

            //Karakter player1 = new Karakter();
            //player1.setData("Kipli", "Sehat", "Pistol", 2, 25);
            ////player1.getData();

            //Karakter player2 = new Karakter();
            //player2.setData("Putri", "Sehat", "Tongkat", 1, 10);
            ////player2.getData();

            ////player.setKesehatan("Sehat");
            ////player.getKesehatan(); //metode membuat method baru

            ////Objek Musuh
            //Karakter enemy = new Karakter();
            //enemy.setData("Zobie", "sehat", "Tangan Kosong", 1, 15);
            //enemy.getData();

            //daftarHero.Add(player1);
            //daftarHero.Add(player2);

            ////menampilkan data diri array, foreach
            //foreach (Karakter player in daftarHero)
            //{
            //    player.getData();
            //}
        }
        }
}
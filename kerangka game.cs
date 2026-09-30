using KerangkaGame;
using System;
namespace KerangkaGame

class Karakter

public string namaKarakter, namaSenjata;
int kesehatanKarakter;

public Karakter(string nama, string senjata, int kesehatan)

namaKarakter = nama;
namaSenjata = senjata;
kesehatanKarakter = kesehatan;

public void tampilKarakter()

Console.Write(namaKarakter);

}
class MyGame

static void Main(string[] args)

Karakter karakter = new Karakter("Ahmad Istakim", "Pedang", 100);
karakter.tampilKarakter();

}
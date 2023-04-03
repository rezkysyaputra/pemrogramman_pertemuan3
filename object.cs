using System;
internal class Program
{
    static void Main(string[] args)
    {
        // membuat object yang bernama mobil1 dari class Mobil
        Mobil mobil1 = new Mobil();

        // memberi nilai pada properti mobil1
        mobil1.Warna = "Merah";
        mobil1.JumlahPintu = 2;
        mobil1.Merek = "Lamborghini";
        mobil1.Model = "Sport";
        mobil1.TahunKeluaran = 1960;

        // menggunakan method pada object mobil1
        mobil1.Klakson("Brrrmmm...Brrrmmm...Brrrmmm...");
        mobil1.Gas(230);
        mobil1.TampilkanInfo();
    }
}
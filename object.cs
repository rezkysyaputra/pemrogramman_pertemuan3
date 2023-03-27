using System;

namespace Tugas3
{
    internal class  program
    {
        static void Main(string[]args){
            Mobil mobil1 = new Mobil();
            mobil1.warna = "Merah";
            mobil1.jumlahPintu = 2;
            mobil1.merek = "Lamborghini";
            mobil1.model = "Sport";
            mobil1.tahunKeluaran = 1960;

            mobil1.klakson("Brrrmmm...Brrrmmm...Brrrmmm...");
            mobil1.gas(230);
            mobil1.tampilkanInfo();
        }
    }
}


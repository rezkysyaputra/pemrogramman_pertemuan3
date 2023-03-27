public class Mobil {
    public string warna{get;set;}
    public int jumlahPintu{get;set;}
    public string merek{get;set;}
    public string model{get;set;}
    public int tahunKeluaran{get;set;}

    public void gas(int kecepatan){
        Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1} km/jam", model, kecepatan);
    }

    public void klakson(string suara){
        Console.WriteLine("{0}", suara);
    }

    public void tampilkanInfo(){
        Console.WriteLine("Mobil saya berwarna {0}, merek {1} model {2} keluaran tahun {3} dengan jumlah pintu sebanyak {4}", warna,merek,model,tahunKeluaran,jumlahPintu);
    }
}
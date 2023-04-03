using System;

// membuat class yang bernama Mobil
public class Mobil
{
    // field private
    private string _warna;
    private int _jumlahPintu;
    private string _merek;
    private string _model;
    private int _tahunKeluaran;

    // properties
    public string Warna
    {
        get { return _warna; }
        set { _warna = value; }
    }

    public int JumlahPintu
    {
        get { return _jumlahPintu; }
        set { _jumlahPintu = value; }
    }

    public string Merek
    {
        get { return _merek; }
        set { _merek = value; }
    }

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }

    public int TahunKeluaran
    {
        get { return _tahunKeluaran; }
        set { _tahunKeluaran = value; }
    }

    // methods
    public void Gas(int kecepatan)
    {
        Console.WriteLine("Mobil {0} berjalan dengan kecepatan {1} km/jam", Model, kecepatan);
    }

    public void Klakson(string suara)
    {
        Console.WriteLine("{0}", suara);
    }

    public void TampilkanInfo()
    {
        Console.WriteLine("Mobil saya berwarna {0}, merek {1} model {2} keluaran tahun {3} dengan jumlah pintu sebanyak {4}", Warna, Merek, Model, TahunKeluaran, JumlahPintu);
    }
}
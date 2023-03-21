using System.Transactions;

public class Penjumlahan
{
    public void jumlahTigaAngka<T>(T satu, T dua, T tiga)
    {
        dynamic wan, tu, tri;
        wan = satu;
        tu = dua;
        tri = tiga;
        dynamic jumlah = wan + tu + tri;
        Console.WriteLine(jumlah.ToString());
    }
}

class Program
{
    static void Main(string[] args)
    {
        Penjumlahan jumlah = new Penjumlahan();
        jumlah.jumlahTigaAngka<float>(13, 02, 21);
    }
}
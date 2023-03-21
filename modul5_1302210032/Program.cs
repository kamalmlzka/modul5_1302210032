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
    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void addNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void printAllData()
        {
            int j = 1;
            for (int i = 0; i < this.inputDates.Count; i++)
            {
                Console.WriteLine("Data " + j++ + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Penjumlahan jumlah = new Penjumlahan();
            jumlah.jumlahTigaAngka<float>(13, 02, 21);
            SimpleDataBase<int> data = new SimpleDataBase<int>();
            data.addNewData(13);
            data.addNewData(02);
            data.addNewData(21);
            data.printAllData();
        }
    }

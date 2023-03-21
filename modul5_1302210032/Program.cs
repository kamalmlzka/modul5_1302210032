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
    static void Main(string[] args)
    {
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.addNewData(13);
        data.addNewData(02);
        data.addNewData(21);
        data.printAllData();
    }
}
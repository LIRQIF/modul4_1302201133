public class DataGeneric<T>
{
    T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        T y = data;
        Console.WriteLine($"Data yang tersimpian adalah: {y}");
    }
}
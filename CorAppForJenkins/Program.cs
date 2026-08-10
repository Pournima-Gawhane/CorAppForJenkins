public class Program
{
    public void Add()
    {
        Console.WriteLine("calling Add");

    }
    static void Main(string[] args)
    {
        Program p = new Program();
        p.Add();
    }
}
internal class Program
{
    public void Test1()
    {
        Console.WriteLine("Test 1");
    }
    public void Test2()
    {
        Console.WriteLine("Test 2");
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Program p = new Program();
        p.Test1();
        p.Test2();
        
    }
}
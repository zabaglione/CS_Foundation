namespace Example;

static class Program
{
    static void Main(string[] args)
    {
        Console.Write("値1を入力してください->");
        var a = Console.ReadLine();
        Console.Write("値2を入力してください->");
        var b = Console.ReadLine();

        if (a == b) 
        {
            Console.WriteLine("値1と値2は等しい");
            Console.WriteLine("ですって！！！");
        }
        Console.WriteLine("終了");
    }
}

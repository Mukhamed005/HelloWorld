namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите свое имя");
        string name = Console.ReadLine();
        DateTime currentDate = DateTime.Now;
        Console.WriteLine($"\n Привет {name}, сейчас {currentDate:d} a");
        Console.Write($"\n Нажмите любую клавишу для завершения...");
        Console.ReadKey(true);
    }
}
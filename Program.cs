using ConsoleApp1.Adapter;
using ConsoleApp1.Observer;
using System.Text;

internal class Program
{



    static void Main()
    {
        var exec = new Executar();
        exec.Main();


        Console.ReadKey();
    }


}
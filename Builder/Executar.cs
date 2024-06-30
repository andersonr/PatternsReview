using System;
using System.Text;

namespace ConsoleApp1.Builder
{
    public class Executar
    {
        public void Run()
        {
            BurguerBuilder builder = new BurguerBuilder(100);
            Burguer xburguer = builder
                .AddCheese()
                .AddBacon()
                .AddPickles()
                .AddMaionese()
                .AddKetchup()
                .Build();

            builder.reset();
            Burguer xSalad = builder
                .AddCheese()
                .AddLettuce()
                .AddTomato()
                .AddOnion()
                .AddPickles()
                .AddMaionese()
                .AddKetchup()
                .Build();

            builder.reset();
            Burguer gorgon = builder
                .AddGorgonSauce()
                .AddBacon()
                .AddOnion()
                .Build();

            builder.reset();
            Burguer brieAndPepper = builder
                            .AddMaionese()
                            .AddBrieCheese()
                            .AddSpiceButter()
                            .AddPickles()
                            .AddOnion()
                            .Build();

            Console.WriteLine("Menu:");
            Console.WriteLine(xburguer.ToString());
            Console.WriteLine(gorgon.ToString());
            Console.WriteLine(brieAndPepper.ToString());
            Console.WriteLine(xSalad.ToString());
        }
    }
}
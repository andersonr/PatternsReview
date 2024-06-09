using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Adapter
{
    internal class AfricanLion : ILion
    {
        public string Name => "Black African Lion";

        public void Roar()
        {
            Console.WriteLine("Black African Lion is roaring");
        }
    }
}

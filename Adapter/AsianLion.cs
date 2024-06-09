using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Adapter
{
    internal class AsianLion : ILion
    {
        public string Name => "Ching ling lion";

        public void Roar()
        {
            Console.WriteLine("Asian Lion with tiny eyes is roaring");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Adapter
{
    internal class Hunter
    {
        public void Hunt(ILion lion)
        {
            Console.WriteLine("Hunter is Hunting");
            lion.Roar();
            Console.WriteLine("Hunter listened a {0}", lion.Name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Adapter
{
    internal class WildDogAdapter : ILion
    {
        private WildDog wildDog;
        public string Name { get; set; }
        public WildDogAdapter(WildDog wildDog)
        {
            this.wildDog = wildDog;
            Name = "Cão selvagem boladão";
        }
        
        public void Roar()
        {            
            this.wildDog.Bark();
        }
    }
}

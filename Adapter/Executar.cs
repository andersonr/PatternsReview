using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Adapter
{
    internal class Executar
    {
        public void Main()
        {
            ILion lionTinyEyes = new AsianLion();
            ILion lionBlack = new AfricanLion();
            WildDog wildDog = new WildDog();
            WildDogAdapter wildDogAdapter = new WildDogAdapter(wildDog);
                                    
            var hunter = new Hunter();
            hunter.Hunt(lionTinyEyes);
            hunter.Hunt(lionBlack);            
            hunter.Hunt(wildDogAdapter);
        }
    }
}

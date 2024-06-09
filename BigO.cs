using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BigO
    {
        //static void Main()
        //{
        //    Testes();
        //}

        private static void PesquisaUsandoHashNaSomaDadosArray()
        {
            long[] entrada = new long[5] { 1, 2, 3, 4, 5 };
            long total = 7;

            Dictionary<long, bool> conjunto = new Dictionary<long, bool>();

            foreach (var item in entrada)
            {
                var valorFaltante = total - item;

                if (conjunto.ContainsKey(valorFaltante))
                {
                    conjunto[valorFaltante] = true;
                }
                else
                {
                    conjunto.Add(item, false);
                }
            }

            Console.WriteLine(conjunto.Where(tk => tk.Value == true).Count());
        }
    }
}

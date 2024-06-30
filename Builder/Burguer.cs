using System;
using System.Text;

namespace ConsoleApp1.Builder
{

    public class Burguer
    {
        public long size;
        public bool meat { get; }
        public bool cheese { get; set; }
        public bool bacon { get; set; }
        public bool lettuce { get; set; }
        public bool tomato { get; set; }
        public bool onion { get; set; }
        public bool pickles { get; set; }
        public bool gorgonSauce { get; set; }
        public bool maionese { get; set; }
        public bool ketchup { get; set; }
        public bool spiceButter { get; set; }
        public bool brieCheese { get; set; }

        public Burguer(BurguerBuilder builder)
        {
            this.meat = true;
            this.size = builder.size;
            this.cheese = builder.cheese;
            this.bacon = builder.bacon;
            this.lettuce = builder.lettuce;
            this.tomato = builder.tomato;
            this.onion = builder.onion;
            this.pickles = builder.pickles;
            this.gorgonSauce = builder.gorgonSauce;
            this.maionese = builder.maionese;
            this.ketchup = builder.ketchup;
            this.spiceButter = builder.spiceButter;
            this.brieCheese = builder.brieCheese;
        }


        public override string ToString()
        {
            return ObterPropriedadesVerdadeirasComoString();
        }

        public string ObterPropriedadesVerdadeirasComoString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Size: {this.size}\n");
            sb.Append($"Meat: {this.meat}\n");
            if (cheese)
                sb.Append($"Cheese: {this.cheese}\n");
            if (bacon)
                sb.Append($"Bacon: {this.bacon}\n");
            if (lettuce)
                sb.Append($"Lettuce: {this.lettuce}\n");
            if (tomato)
                sb.Append($"Tomato: {this.tomato}\n");
            if (onion)
                sb.Append($"Onion: {this.onion}\n");
            if (pickles)
                sb.Append($"Pickles: {this.pickles}\n");
            if (gorgonSauce)
                sb.Append($"Gorgon Sauce: {this.gorgonSauce}\n");
            if (maionese)
                sb.Append($"Maionese: {this.maionese}\n");
            if (ketchup)
                sb.Append($"Ketchup: {this.ketchup}\n");
            if (spiceButter)
                sb.Append($"Spice Butter: {this.spiceButter}\n");
            if (brieCheese)
                sb.Append($"Brie Cheese: {this.brieCheese}\n");

            return sb.ToString();
        }


    }
}

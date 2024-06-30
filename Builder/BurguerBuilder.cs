using System;

namespace ConsoleApp1.Builder
{
    public class BurguerBuilder
    {
        public long size;
        public bool cheese = false;
        public bool bacon = false;
        public bool lettuce = false;
        public bool tomato = false;
        public bool onion = false;
        public bool pickles = false;
        public bool gorgonSauce = false;
        public bool maionese = false;
        public bool ketchup = false;
        public bool spiceButter = false;
        public bool brieCheese = false;

        public BurguerBuilder(long size)
        {
            this.size = size;
        }

        public BurguerBuilder AddCheese()
        {
            cheese = true;
            return this;
        }

        public BurguerBuilder AddBacon()
        {
            bacon = true;
            return this;
        }

        public BurguerBuilder AddLettuce()
        {
            lettuce = true;
            return this;
        }

        public BurguerBuilder AddTomato()
        {
            tomato = true;
            return this;
        }

        public BurguerBuilder AddOnion()
        {
            onion = true;
            return this;
        }

        public BurguerBuilder AddPickles()
        {
            pickles = true;
            return this;
        }

        public BurguerBuilder AddGorgonSauce()
        {
            gorgonSauce = true;
            return this;
        }

        public BurguerBuilder AddMaionese()
        {
            maionese = true;
            return this;
        }

        public BurguerBuilder AddKetchup()
        {
            ketchup = true;
            return this;
        }

        public BurguerBuilder AddSpiceButter()
        {
            spiceButter = true;
            return this;
        }

        public BurguerBuilder AddBrieCheese()
        {
            brieCheese = true;
            return this;
        }

        public BurguerBuilder reset()
        {
            cheese = false;
            bacon = false;
            lettuce = false;
            tomato = false;
            onion = false;
            pickles = false;
            gorgonSauce = false;
            maionese = false;
            ketchup = false;
            spiceButter = false;
            brieCheese = false;
            return this;
        }

        public Burguer Build()
        {
            return new Burguer(this);
        }
    }
}
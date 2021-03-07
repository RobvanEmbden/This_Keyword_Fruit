using System;

namespace retailThisFruit
{// accesing Obejects with the This keyword
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit("Apple", 0.5);
            string newFruit = fruit.GetKind();
            double total = fruit.GetCost();
            Console.WriteLine(newFruit);
            Console.WriteLine("${0}", total);
        }
        class Fruit
        {
            private string kind;
            private double cost;
            public Fruit(string k, double c)
            {
                this.kind = k;
                this.cost = c;
            }
            public string GetKind()
            {// this methode will return 'Apple' see above
                return this.kind;
            }
            public double GetCost()
            {// this methode will return ' the price 0.5' mentioned above
                return this.cost * 12;
            }
        }
    }
}

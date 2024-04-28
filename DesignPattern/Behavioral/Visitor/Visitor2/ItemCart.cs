using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Visitor.Visitor2
{
    public interface ItemElement
    {
        int Accept(IShoppingCartVisitor visitor);
    }

    public class Book : ItemElement
    {
        private int price;
        private string isbnNumber;

        public Book(int cost, string isbn)
        {
            this.price = cost;
            this.isbnNumber = isbn;
        }

        public int Price => price;
        public string IsbnNumber => isbnNumber;

        public int Accept(IShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    public class Fruit : ItemElement
    {
        private int pricePerKg;
        private int weight;
        private string name;

        public Fruit(int priceKg, int wt, string nm)
        {
            this.pricePerKg = priceKg;
            this.weight = wt;
            this.name = nm;
        }

        public int PricePerKg => pricePerKg;
        public int Weight => weight;
        public string Name => name;

        public int Accept(IShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}

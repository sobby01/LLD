using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Visitor.Visitor2
{
    public class ShoppingCartVisitorImpl : IShoppingCartVisitor
    {
        public int Visit(Book book)
        {
            int cost = 0;
            // Apply a $5 discount if the book price is greater than $50
            if (book.Price > 50)
            {
                cost = book.Price - 5;
            }
            else
            {
                cost = book.Price;
            }

            Console.WriteLine($"Book ISBN::{book.IsbnNumber} cost = {cost}");
            return cost;
        }

        public int Visit(Fruit fruit)
        {
            int cost = fruit.PricePerKg * fruit.Weight;
            Console.WriteLine($"{fruit.Name} cost = {cost}");
            return cost;
        }
    }
}

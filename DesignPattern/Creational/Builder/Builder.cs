using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Builder
{
    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }

    public class ConcreteBuilder1 : Builder
    {
        private Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("part1");
        }

        public override void BuildPartB()
        {
            product.Add("part2");
        }

        public override Product GetResult()
        {
            return product;
        }
    }

    public class ConcreteBuilder2 : Builder
    {
        private Product product = new Product();
        public override void BuildPartA()
        {
            product.Add("part3");
        }

        public override void BuildPartB()
        {
            product.Add("part4");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}

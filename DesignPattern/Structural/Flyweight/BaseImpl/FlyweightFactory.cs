using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Flyweight.BaseImpl
{
    public class FlyweightFactory
    {
        private Dictionary<string, FlyWeight> map = new Dictionary<string, FlyWeight>();

        public FlyWeight GetFlyWeightObject(string type)
        {
            FlyWeight flyObject = null;

            if (map.ContainsKey(type))
            {
                map.TryGetValue(type, out flyObject);
            }
            else
            {
                switch (type)
                {
                    case "concrete1":
                        Console.WriteLine("Concrete1 created");
                        flyObject = new ConcreteFlyweight1();
                        break;
                    case "concrete2":
                        Console.WriteLine("Concrete2 created");
                        flyObject = new ConcreteFlyweight2();
                        break;
                    default:
                        Console.WriteLine("Nothing is found");
                        break;
                }
                map.Add(type, flyObject);

            }

            return flyObject;


        }

    }
}

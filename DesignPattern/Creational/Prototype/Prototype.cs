using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Prototype
{
    //Prototype pattern helps you in cloning.
    //Lets say we want to create duplicate copy of anything then prototype pattern suits there.
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    public class Concrete1 : Prototype
    {
        int red;
        int green;
        int blue;

        public Concrete1(int red, int blue, int green)     
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
        }

        public override Prototype Clone()
        {
            Console.WriteLine("Cloning color RGB: {0},{1},{2}", red, green, blue);
            return this.MemberwiseClone() as Concrete1;
        }
    }

    public class Implementer
    {
        Prototype obj1 = new Concrete1(255, 0, 0);
        
        public void CreateProtoType()
        {
            //We cna create as many objects using this
            Prototype obj2 = obj1.Clone() as Prototype;
        }
    }
}


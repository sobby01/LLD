using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Flyweight.RealWorld
{
    public interface Player
    {
        void AssignWeapon(string weapon);
        void Action();
    }

    public class Terrorist : Player
    {
        private string task;

        private string weapon;

        public Terrorist()
        {
            task = "Plat a Bomb";
        }

        public void Action()
        {
            Console.WriteLine("Terrorist with weapon :" + weapon + " and the task is :" + task);
        }

        public void AssignWeapon(string weapon)
        {
            this.weapon = weapon;
        }
    }

    public class CounterTerrorist : Player
    {
        private string task;

        private string weapon;

        public CounterTerrorist()
        {
            task = "Diffuse a Bomb";
        }

        public void Action()
        {
            Console.WriteLine("Counter Terrorist with weapon :" + weapon + " and the task is :" + task);
        }

        public void AssignWeapon(string weapon)
        {
            this.weapon = weapon;
        }
    }
}

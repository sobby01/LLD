using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Flyweight.RealWorld
{
    public class PlayerFactory
    {
        private Dictionary<string, Player> map = new Dictionary<string, Player>();

        public Player GetPlayerInfo(string type)
        {
            Player pl = null;

            if (map.ContainsKey(type))
            {
                map.TryGetValue(type, out pl);
                return pl;
            }
            else
            {
                switch (type)
                {
                    case "Terrorist":
                        pl = new Terrorist();
                        break;
                    case "CounterTerrorist":
                        pl = new CounterTerrorist();
                        break;
                    default:
                        throw new MissingMemberException();
                        
                }

                if (pl != null)
                    map.Add(type, pl);
            }

            return pl;
        }
    }
}

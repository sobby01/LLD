using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();

        static Singleton() { }

        private Singleton() { }

        private static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }

    public class LazySingleton
    {
        private static readonly Lazy<LazySingleton> lazyInstance = new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton()
        {

        }

        public static LazySingleton Instance
        {
            get
            {
                return lazyInstance.Value;
            }

        }
    }
}

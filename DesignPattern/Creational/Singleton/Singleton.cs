using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Test
    {
        private Test() { }

        public static Test Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            //This makes sense that this will be created only once
            static Nested() { }
            internal static readonly Test instance = new Test();
        }
    }

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

    /*
     * In C#, the static constructor (also known as a type initializer) is automatically called
     * before any static members are accessed or any static methods are called for the first time in the class.
     * This behavior guarantees that the static constructor is invoked exactly once, regardless of the number of threads accessing the class.
     * 
     * Without the static constructor, the Singleton instance might be created eagerly 
     * at the time of class loading, defeating the purpose of lazy initialization.
     * By having the static constructor in the nested class, you achieve the desired 
     * lazy initialization behavior and ensure that the Singleton instance is created only when needed.

    Overall, the static constructor in the nested class of the Singleton pattern is essential
    for achieving lazy initialization and thread safety, ensuring that the Singleton instance 
    is created only once, even in a multi-threaded environment.
     */
    public class SingletonNested
    {
        private SingletonNested() { }

        public static SingletonNested Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            internal static readonly SingletonNested instance = new SingletonNested();

            static Nested() { }
        }
    }
}

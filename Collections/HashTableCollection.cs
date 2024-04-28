using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collection
{
    public class HashTableCollection
    {
        //If you are looking for threadafe then go for Hashtable other wise go for dictionary
        public HashTableCollection()
        {

        }

        public void Create()
        {
            //Not Typesafe but it is threadSafe
            
            // Creating a HashTable
            Hashtable hashtable = new Hashtable();

            // Adding key-value pairs to the HashTable
            hashtable.Add("key1", "value1");
            hashtable.Add("key2", "value2");
            hashtable.Add("key3", "value3");

            // Accessing elements by key
            Console.WriteLine("Value for key 'key2': " + hashtable["key2"]);

            // Checking if a key is present
            Console.WriteLine("Is 'key4' present in the HashTable? " + hashtable.ContainsKey("key4"));

            // Removing a key-value pair
            hashtable.Remove("key1");

            // Iterating through the keys and values
            Console.WriteLine("HashTable elements:");
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }
    }
}

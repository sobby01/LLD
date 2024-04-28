using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class stringbuilder
    {
        public void Solve()
        {
            StringBuilder sb = new StringBuilder();

            // Append strings to StringBuilder
            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("World");
            sb.Append("!");

            Console.WriteLine("After append operations: " + sb.ToString());

            // Append more with AppendFormat
            sb.AppendFormat(" This is {0} {1}.", "day", 3);
            Console.WriteLine("After AppendFormat: " + sb.ToString());

            // Delete the last character '!'
            sb.Remove(sb.Length - 1, 1);
            Console.WriteLine("After deleting the last character: " + sb.ToString());

            // Replace a part of the string
            sb.Replace("day", "number");
            Console.WriteLine("After replacing 'day' with 'number': " + sb.ToString());

            // Delete a substring (remove 'number')
            int startIndex = sb.ToString().IndexOf("number");
            if (startIndex != -1)
            {
                sb.Remove(startIndex, "number".Length);
                Console.WriteLine("After removing 'number': " + sb.ToString());
            }

            // Insert string at a specific position
            sb.Insert(startIndex, "evening");
            Console.WriteLine("After inserting 'evening': " + sb.ToString());
        }
    }
}

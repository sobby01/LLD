using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public class ExceptionFilters
    {
        public void Filters(){
            try
            {
                Console.WriteLine("Do Something");

                int[] a = new int[5];

                a[10] = 12;
            }
            catch(Exception ex) when(ex.GetType().ToString() == "System.IndexOutOfRangeException")
            {
                SomeOtherTask();
            }
        }

        public async void AFilters()
        {
            try
            {
                Console.WriteLine("Do Something");

                int[] a = new int[5];

                a[10] = 12;
            }
            catch (Exception ex) when (ex.GetType().ToString() == "System.IndexOutOfRangeException")
            {
                await ExceptionOccurred();
            }
        }

        async static Task ExceptionOccurred()
        {
            Console.WriteLine("Array Exception occurred.");
        }

        static void SomeOtherTask()
        {
            Console.WriteLine("A new task is executing...");

            try
            {
                // try some stuff
            }
            catch (FormatException ex)
            {
                HandleIt(ex);
            }
            catch (OverflowException ex)
            {
                HandleIt(ex);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void HandleIt(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

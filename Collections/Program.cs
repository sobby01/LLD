// See https://aka.ms/new-console-template for more information
using DSA.Collection;
using DSA.Collections;
using DSA.Collections.IComparerSolutions;

Console.WriteLine("Hello, World!");
//SortedSetCollection ssc = new SortedSetCollection();
//ssc.Func();

PriorityQueueCollection pqCollection = new PriorityQueueCollection();
//pqCollection.Func();

pqCollection.PriorityQueueMaxHeap();


# region Comparer

double[] numbers = { 3.5, 1.2, 2.8, 0.5 };
Array.Sort(numbers, new DoubleComparer());

string[] words = { "Apple", "banana", "cherry", "apple", "Banana" };
Array.Sort(words, new CaseInsensitiveStringComparer());

Person[] people = { new Person { Name = "Alice", Age = 30 }, new Person { Name = "Bob", Age = 25 } };
Array.Sort(people, new PersonComparer());

int[][] intervals = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 3, 4 },
    new int[] { 5 ,6 },
};

Console.WriteLine($"2d array {intervals.GetLength(0)}");
Console.WriteLine($"2d array {intervals.GetLength(1)}");
Console.WriteLine($"2d array {intervals.Length}");

int[,] intver2 = new int[,]
{
    { 1, 2 },
    { 3, 4 },
    { 5 ,6 }
};

Console.WriteLine(intver2.GetLength(0));
Console.WriteLine(intver2.GetLength(1));
Console.WriteLine(intver2.Length);

// Sort by the first column
Array.Sort(intervals, new MultiColumnComparer(0));

// Sort by the second column
Array.Sort(intervals, new MultiColumnComparer(1));

#endregion
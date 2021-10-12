using System;

namespace Generic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Programming programm1 = new Programming("C#", 2002);
            Programming programm2 = new Programming("HTML", 1990);
            Programming programm3 = new Programming("Javascipt", 1995);

            Collections<Programming> collection = new Collections<Programming>();

            collection.Add(programm1);
            collection.Add(programm2);
            collection.Add(programm3);

            Console.WriteLine(collection.Count);
            Console.WriteLine("Programming: ");

            foreach (var item in collection.GetArray())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Year);
            }
        }
    }
}

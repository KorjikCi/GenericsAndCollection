using System;

namespace GenericsAndCollections
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);

            CustomList<string> listString = new CustomList<string>();
            listString.Add("1234");
            listString.Add("3214");
            listString.Add("4321");
            listString.Add("2431");
            listString.Add("3124");

            Print(list);
            Print(listString);
        }

        public static void Print<T>(CustomList<T> list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list.Get(i));
            }
        }
    }
}
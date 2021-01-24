using System;
using System.Collections.Generic;


namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args) 
        {
            Dictionary<string,int> numbers = new Dictionary<string,int>();

            numbers.Add("Aleyna", 123);
            numbers.Add("Emir", 678);
            numbers.Add("Büşra", 489);
            numbers.Add("Emirhan", 124);
            numbers.Add("Nisa", 564);

            foreach (KeyValuePair<string, int> entry in numbers)

              Console.WriteLine(entry.Key + ":" + entry.Value);

        }
    }
}

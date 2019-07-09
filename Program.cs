using System;
using System.Collections.Generic;

namespace familyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>() {
                {"name", "Krista"},
                {"age", "42"}
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> familyMember in myFamily)
            {

                Console.WriteLine($"{familyMember.Value["name"]} is my sister, and she is {familyMember.Value["age"]} years old");
            }
        }
    }
}

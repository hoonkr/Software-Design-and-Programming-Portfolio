using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Question10
{
    class Program
    {

        static List<string> StartsWith(List<string> names, string modi_string)
        {
            Func<string, bool> startsWith = delegate(string name) { return name.StartsWith(modi_string); };
            var startswithstring = names.Where(startsWith);
            return startswithstring.ToList();
        }
        
        static List<string> EndsWith(List<string> names, string modi_string)
        {
            Func<string, bool> endsWith = delegate(string name) { return name.EndsWith(modi_string); };
            var endswithstring = names.Where(endsWith);
            return endswithstring.ToList();
        }
        
        static List<string> LengthWith(List<string> names, string modi_string)
        {
            Func<string, bool> strLength = delegate(string name) { return name.Length == int.Parse(modi_string); };
            IEnumerable<string> lengthwithstring = names.Where(strLength);
            return lengthwithstring.ToList();
        }
        
        
        static List<string> Double(List<string> names, string condition, string modi_string)
        {
            List<string> condnames = new List<string>();
            switch (condition)
            {
                case "StartsWith":
                {
                    condnames = StartsWith(names, modi_string);
                    break;
                }
                case "EndsWith":
                {
                    condnames = EndsWith(names, modi_string);
                    break;
                }
                case "Length":
                {
                    condnames = LengthWith(names, modi_string);
                    break;
                }
            }
            
            List<string> updatednames = new List<string>();
            foreach (var name in names)
            {
                if (condnames.Contains(name))
                {
                    updatednames.Add(name);
                    updatednames.Add(name);
                }
                else
                {
                    updatednames.Add(name);
                }
            }
            // updatednames.ForEach(Console.WriteLine);
            return updatednames;
        }
        
        static List<string> Remove(List<string> names, string condition, string modi_string)
        {
            List<string> condnames = new List<string>();
            switch (condition)
            {
                case "StartsWith":
                {
                    condnames = StartsWith(names, modi_string);
                    break;
                }
                case "EndsWith":
                {
                    condnames = EndsWith(names, modi_string);
                    break;
                }
                case "Length":
                {
                    condnames = LengthWith(names, modi_string);
                    break;
                }
            }

            foreach (var name in condnames)
            {
                names.Remove(name);
            }
            // names.ForEach(Console.WriteLine);
            return names;
        }

        static void Main(string[] args)
        {
            
            var name = Console.ReadLine();
            string[] tokens = name.Split();
            var names = tokens.OfType<string>().ToList();
            // names.ForEach(Console.WriteLine);
            // Func<string, string> Double = s => s + s;
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Party!")
                {
                    Console.WriteLine(names.Aggregate((a, x) => a + ", " + x) + " are going to the party!");
                    break;
                }
                else
                {
                    string[] command = line.Split();
                    var commandparts = command.OfType<string>().ToList();
                    // commandparts.ToList().ForEach(Console.WriteLine);
                    switch (commandparts[0])
                    {
                        case "Remove":
                        {
                            // Console.WriteLine("Remove");
                            names = Remove(names, commandparts[1], commandparts[2]);
                            break;
                        }
                        case "Double":
                        {
                            // Console.WriteLine("Double");
                            names = Double(names, commandparts[1], commandparts[2]);
                            break;
                        }
                    }
                }
            }
        }
    }
}
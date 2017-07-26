using System;
using System.Collections.Generic;
using _09.Collection_Hierarchy.Models.Classes;

namespace _09.Collection_Hierarchy
{
    public class Engine
    {
        public Engine()
        {
            this.Dictionary = new Dictionary<string, List<int>>();
            this.Dictionary.Add("addCollection", new List<int>());
            this.Dictionary.Add("addRemoveCollection", new List<int>());
            this.Dictionary.Add("myList", new List<int>());
            this.AddRemoveList = new List<string>();
            this.MyList = new List<string>();
        }

        public Dictionary<string, List<int>> Dictionary { get; private set; }
        public List<string> AddRemoveList { get; private set; }
        public List<string> MyList { get; private set; }

        public void Run()
        {
            var strings = Console.ReadLine().Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var amountOfRemoves = int.Parse(Console.ReadLine());
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            foreach (var stringItem in strings)
            {
                try
                {
                    this.Dictionary["addCollection"].Add(addCollection.Add(stringItem));
                    this.Dictionary["addRemoveCollection"].Add(addRemoveCollection.AddAtBeginning(stringItem));
                    this.Dictionary["myList"].Add(myList.AddAtBeginning(stringItem));
                }
                catch (Exception e)
                {
                }
            }

            for (int i = 0; i < amountOfRemoves; i++)
            {
                this.AddRemoveList.Add(addRemoveCollection.RemoveLastItem());
                this.MyList.Add(myList.RemoveFirstElement());
            }
        }

        public void Print()
        {
            foreach (var kvp in this.Dictionary)
            {
                Console.WriteLine($"{String.Join(" ", kvp.Value)}");
            }

            Console.WriteLine($"{String.Join(" ", this.AddRemoveList)}");
            Console.WriteLine($"{String.Join(" ", this.MyList)}");
        }
    }
}
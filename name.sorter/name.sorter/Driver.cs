using System;
using System.Collections.Generic;

namespace namesorter
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            NameSortingService nameSortingService = new NameSortingService();

            foreach (string arg in args)
            {
                var names = nameSortingService.GetTextFromFile(arg);

                List<Name> fullNameList = new List<Name>();

                foreach (string name in names)
                {
                    fullNameList.Add(nameSortingService.GenerateFirstAndLastNames(name));
                }

                var sortedNames = nameSortingService.NameSorter(fullNameList);

                nameSortingService.WriteSortedNamesToFile(sortedNames, "sorted-names-list.txt");

                foreach (var name in sortedNames)
                {
                    Console.WriteLine(name.FirstName + " " + name.LastName);
                }
            }

        }
    }
}

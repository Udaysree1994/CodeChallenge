using System;
using System.Collections.Generic;


/// <summary>
/// Driver class to run the project plus read from file and write to file.
/// </summary>



namespace namesorter
{
    public class Driver
    {
        public static void Main(string[] args)
        { 
            NameSortingService nameSortingService = new NameSortingService();

            //get file name from arguments  
            foreach (string arg in args)
            {
                //read text file
                var names = nameSortingService.GetTextFromFile(arg);

                List<Name> fullNameList = new List<Name>();

                //generate first and last name properties and add to list
                foreach (string name in names)
                {
                    fullNameList.Add(nameSortingService.GenerateFirstAndLastNames(name));
                }

                //sorting the names
                var sortedNames = nameSortingService.NameSorter(fullNameList);

                //write sorted names to file
                nameSortingService.WriteSortedNamesToFile(sortedNames, "sorted-names-list.txt");

                foreach (var name in sortedNames)
                {
                    Console.WriteLine(name.FirstName + " " + name.LastName);
                }
            }

        }
    }
}

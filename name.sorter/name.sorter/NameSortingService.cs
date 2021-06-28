using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using name.sorter;

/// <summary>
/// Service class to perform all the functionalities required for the name sorter program
/// </summary>


namespace namesorter
{
    public class NameSortingService : INameSortingService
    {

        //reading from file
        public string[] GetTextFromFile(string fileName)
        {
            var nameText = System.IO.File.ReadAllLines(fileName);

            return nameText;
        }

        //writing to file for given list of sorted names and filename
        public void WriteSortedNamesToFile(IEnumerable<Name> names, string fileName)
        {

            using (var sw = new StreamWriter(fileName))
            {
                foreach (var name in names)
                {
                    sw.WriteLine(name.FirstName + name.LastName);
                }
            }
        }

        //sorting by last name then by first name using LINQ for a given unsorted list of name objects
        public IEnumerable<Name> NameSorter(List<Name> unsortedNames)
        {
            var sortedNames =
                from e in unsortedNames
                orderby e.LastName, e.FirstName descending
                select e;

            return sortedNames;
        }

        //getting last name from string and assigning to lastName field and assigning remaining string to firstName field
        public Name GenerateFirstAndLastNames(string name)
        {
            var nameParts = name.Split(' ');
            string firstName = "";
            for (int i = 0; i < nameParts.Length - 1; i++)
            {
                firstName += nameParts[i] + " ";
            }

            Name newName = new Name(firstName, nameParts[nameParts.Length - 1]);

            return newName;
        }
    }
}

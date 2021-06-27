using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using name.sorter;

namespace namesorter
{
    public class NameSortingService : INameSortingService
    {

        public string[] GetTextFromFile(string fileName)
        {
            var nameText = System.IO.File.ReadAllLines(fileName);

            return nameText;
        }

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

        public IEnumerable<Name> NameSorter(List<Name> unsortedNames)
        {
            var sortedNames =
                from e in unsortedNames
                orderby e.LastName, e.FirstName descending
                select e;

            return sortedNames;
        }

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

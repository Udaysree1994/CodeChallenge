using System;
using Xunit;
using namesorter;
using System.Collections.Generic;
using System.Linq;

namespace name.sorter.tests
{
    public class UnitTest1
    {
        NameSortingService nameSortingService = new NameSortingService();
        public List<Name> sortedNames = new List<Name>();
        List<Name> unsortedNames = new List<Name>();
        string names = "";


        public UnitTest1()
        {
            sortedNames.Add(new Name("Marin", "Alvarez"));
            sortedNames.Add(new Name("Adonis Julius", "Archer"));
            sortedNames.Add(new Name("Beau Tristan", "Bentley"));
            sortedNames.Add(new Name("Hunter Uriah Mathew", "Clarke"));

            unsortedNames.Add(new Name("Hunter Uriah Mathew", "Clarke"));
            unsortedNames.Add(new Name("Beau Tristan", "Bentley"));
            unsortedNames.Add(new Name("Adonis Julius", "Archer"));
            unsortedNames.Add(new Name("Marin", "Alvarez"));

            foreach (var name in sortedNames)
            {
                names += name.FirstName + name.LastName;
            }

        }

        [Fact]
        public void Test1()
        {
            var sortedNamesFromService = nameSortingService.NameSorter(unsortedNames);
            
            string sortedNames = "";
            foreach(var name in sortedNamesFromService)
            {
                sortedNames += name.FirstName + name.LastName;
            }

           Assert.Equal(names, sortedNames);

        }
    }
}

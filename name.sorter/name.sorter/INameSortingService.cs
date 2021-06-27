using System;
using System.Collections.Generic;
using namesorter;

namespace name.sorter
{
    public interface INameSortingService
    {
        public IEnumerable<Name> NameSorter(List<Name> unsortedNames);
        public Name GenerateFirstAndLastNames(string name);
        public string[] GetTextFromFile(string fileName);
        public void WriteSortedNamesToFile(IEnumerable<Name> names, string fileName);
    }
}

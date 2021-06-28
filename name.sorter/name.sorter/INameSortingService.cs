using System;
using System.Collections.Generic;
using namesorter;

/// <summary>
/// Interface to hold the necessary functionalities
/// </summary>
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


// Use Insert() to add Earth, and Venus in the correct order.
// Use Add() again to add Pluto to the end of the list.
// Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets.
// Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.

using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            // Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            // Create another List that contains that last two planet of our solar system.
            List<string> farPlanetList = new List<string>() { "Neptune", "Pluto" };
            // Combine the two lists by using AddRange().
            //   public void AddRange(IEnumerable<T> collection);
            planetList.AddRange(farPlanetList);

            // Use Insert() to add Earth, and Venus in the correct order.
            // public void Insert(int index, T item);
            planetList.Insert(2, "Earth");
            planetList.Insert(3, "Venus");

            //
            // Summary:
            //     Inserts the elements of a collection into the System.Collections.Generic.List`1
            //     at the specified index.
            //
            // Parameters:
            //   index:
            //     The zero-based index at which the new elements should be inserted.
            //
            //   collection:
            //     The collection whose elements should be inserted into the System.Collections.Generic.List`1.
            //     The collection itself cannot be null, but it can contain elements that are null,
            //     if type T is a reference type.
            //
            // Exceptions:
            //   T:System.ArgumentNullException:
            //     collection is null.
            //
            //   T:System.ArgumentOutOfRangeException:
            //     index is less than 0. -or- index is greater than System.Collections.Generic.List`1.Count.


        }
    }
}

using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        //PART ONE: Main excercise         
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            // Add() Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            // Create another List that contains that last two planet of our solar system.
            List<string> farPlanetList = new List<string>() { "Uranus", "Neptune" };
            // Combine the two lists by using AddRange().
            //   public void AddRange(IEnumerable<T> collection);
            planetList.AddRange(farPlanetList);

            // Use Insert() to add Earth, and Venus in the correct order.
            // public void Insert(int index, T item);
            planetList.Insert(2, "Earth");
            planetList.Insert(3, "Venus");

            // Use Add() again to add Pluto to the end of the list.
            planetList.Add("Pluto");

            // Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets.
            List<string> rockyPlanets = new List<string>() { "Mercury", "Mars", "Earth", "Venus" };

            // Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.
            planetList.Remove("Pluto");

            // foreach (string item in planetList)
            // {
            //     Console.WriteLine(item);
            // }
            // foreach (string item in rockyPlanets)
            // {
            //     Console.WriteLine(item);
            // }
            //         }
            //     }
            // }

            //PART TWO: Iterating over planets
            // Create another list containing dictionaries. Each dictionary will hold the name of a spacecraft that we have launched, and the name of the planet that it has visited. If it visited more than one planet, just pick one.
            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();

            Dictionary<string, string> viking = new Dictionary<string, string>();
            viking["Mars"] = "Viking";

            Dictionary<string, string> opportunity = new Dictionary<string, string>() {
                {"Mars", "Opportunity"}
            };

            Dictionary<string, string> mariner10 = new Dictionary<string, string>() {
                {"Mercury", "Mariner10"}
            };
            //all probes to list
            probes.Add(viking);
            probes.Add(opportunity);
            probes.Add(mariner10);


            // Iterate over your list of planets from above, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.

            foreach (string planet in planetList)
            {
                //build an initial list of sting to hold the matching probe names
                List<string> visitedProbes = new List<string>();
                //iterate over all probes
                foreach (Dictionary<string, string> probe in probes)
                {
                    //Does the current planet name in th dictionary match the name of the planet in planet list
                    if (probe.ContainsKey(planet))
                    {
                        visitedProbes.Add(probe[planet]);
                    }
                }
                //output the name of the planet and comma serparted list of mathcing probes
                Console.WriteLine($"{planet}: {String.Join(",", visitedProbes)}");
            }
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Target
    {   //attributes
        public string Name;

        //construtor
        public Target(string name)
        {
            Name = name;
        }
    }

    class Program
    {
        static List<Target> targetList = new List<Target>();


        //add method
        static void AddTarget(Target target)
        {
            targetList.Add(target);
            Console.WriteLine("Target added successfully!");
        }

        //fetch method
        static Target FetchTarget(string searchName)
        {
            for (int i = 0; i < targetList.Count; i++)
            {
                if (targetList[i].Name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    return targetList[i]; // i took fetch as should i return the target not displayed it 
                }
            }
            Console.WriteLine("no matching answer found");
            return null;
        }

        static void UpdateTarget(string oldname, string newName)
        {
            for (int i = 0; i < targetList.Count; i++)
            {
                if (targetList[i].Name == oldname)
                {
                    targetList[i].Name = newName;
                }
            }
        }

        //remove method
        static void RemoveTarget(string name)
        {
            for (int i = 0; i < targetList.Count; i++)
            {
                if (targetList[i].Name == name)
                {
                    targetList.Remove(targetList[i]);

                }
            }
        }
        static void Main(string[] args)
        {
            AddTarget(new Target("hussein"));
            AddTarget(new Target("ali"));
            AddTarget(new Target("leo"));

            FetchTarget("mhmd");
            UpdateTarget("ali", "mhmd");
            FetchTarget("mhmd");

            RemoveTarget("hussein");
            FetchTarget("ali");

            foreach (Target target in targetList)
            {
                Console.WriteLine(target.Name);

            }


        }
    }
}
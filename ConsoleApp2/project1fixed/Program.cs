using System;
using System.Collections.Generic;
using System.Linq;

class Target
{
    public string Name;

    public Target(string name)
    {
        Name = name;
    }
}

class Program
{
    static List<Target> targetList = new List<Target>();

    // Add method
    static void AddTarget(Target target)
    {
        targetList.Add(target);
        Console.WriteLine("Target added successfully!");
    }

    // Fetch method
    static Target FetchTarget(string searchName)
    {
        Target target = targetList.FirstOrDefault(t => t.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));

        if (target != null)
        {
            return target;
        }

        Console.WriteLine("No matching target found.");
        return null;
    }

    // Update method
    static void UpdateTarget(string oldName, string newName)
    {
        Target target = targetList.FirstOrDefault(t => t.Name.Equals(oldName, StringComparison.OrdinalIgnoreCase));

        if (target != null)
        {
            target.Name = newName;
            Console.WriteLine("Target updated successfully!");
        }
        else
        {
            Console.WriteLine("No matching target found.");
        }
    }

    // Remove method
    static void RemoveTarget(string name)
    {
        Target target = targetList.FirstOrDefault(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        if (target != null)
        {
            targetList.Remove(target);
            Console.WriteLine("Target removed successfully!");
        }
        else
        {
            Console.WriteLine("No matching target found.");
        }
    }

    // Print all targets method
    static void PrintAllTargets()
    {
        Console.WriteLine("\nList of targets:");
        foreach (Target target in targetList)
        {
            Console.WriteLine(target.Name);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Target Manager!");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add a target");
            Console.WriteLine("2. Fetch a target");
            Console.WriteLine("3. Update a target");
            Console.WriteLine("4. Remove a target");
            Console.WriteLine("5. Print all targets");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter target name: ");
                    string targetName = Console.ReadLine();
                    AddTarget(new Target(targetName));
                    break;
                case "2":
                    Console.Write("Enter target name to fetch: ");
                    string fetchName = Console.ReadLine();
                    Target fetchedTarget = FetchTarget(fetchName);
                    if (fetchedTarget != null)
                    {
                        Console.WriteLine("Fetched target: " + fetchedTarget.Name);
                    }
                    break;
                case "3":
                    Console.Write("Enter target name to update: ");
                    string oldName = Console.ReadLine();
                    Console.Write("Enter new target name: ");
                    string newName = Console.ReadLine();
                    UpdateTarget(oldName, newName);
                    break;
                case "4":
                    Console.Write("Enter target name to remove: ");
                    string removeName = Console.ReadLine();
                    RemoveTarget(removeName);
                    break;
                case "5":
                    PrintAllTargets();
                    break;
                case "6":
                    Console.WriteLine("Exiting the program...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

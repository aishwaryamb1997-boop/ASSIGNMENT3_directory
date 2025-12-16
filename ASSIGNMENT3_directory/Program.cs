using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT3_directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int choice;

            do
            {
                Console.WriteLine("\n ======== student Record Management System=======");
                Console.WriteLine("1. Add new student");
                Console.WriteLine("2. Remove student by ID");
                Console.WriteLine("3. Display all students ");
                Console.WriteLine("4. EXIT");
                Console.WriteLine(" enter yor choice(1-4)");

                bool validInput = int.TryParse(Console.ReadLine(), out choice);

                if (!validInput)
                {
                    Console.WriteLine("invalid input. Please enter a no. from 1-4");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n Enter Student ID");
                        int id;
                        if (!int.TryParse(Console.ReadLine(), out id))
                        {
                            Console.WriteLine("Invalid ID. Please enter a valid ID");
                            break;
                        }
                        if (students.ContainsKey(id))
                        {
                            Console.WriteLine("This ID already exits. Try a different one");
                        }
                        else
                        {
                            Console.WriteLine("Enter student Name: ");
                            string name = Console.ReadLine();
                            students.Add(id, name);
                            Console.WriteLine("student added successfully!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n Enter Student ID to remove: ");
                        int removeID;
                        if (!int.TryParse(Console.ReadLine(), out removeID))
                        {
                            Console.WriteLine("invalid ID. Please enter a no.");
                            break;
                        }
                        if (students.Remove(removeID))
                        {
                            Console.WriteLine("sudent removed successfully");
                        }
                        else
                        {
                            Console.WriteLine("No student fonf with this ID.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n========LIST OF STUDENTS======");
                        if (students.Count == 0)
                        {
                            Console.WriteLine("no records found.");
                        }
                        else
                        {
                            foreach (var student in students)
                            {
                                Console.WriteLine($" ID: {student.Key}, Name: {student.Value}");

                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n Exiting the program....Goodbyee!");
                        break;

                    default:
                        Console.WriteLine(" Invalid choice! Please select between 1 to 4.");
                        break;
                }
            } while (choice != 4);
        }
    }
}

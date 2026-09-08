using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
{
        ArrayList list = new ArrayList();
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n Welcome to my ARRAYLIST PROGRAM");
            Console.WriteLine("Choose what you want to do?");
            Console.WriteLine("1 - ADD NEW DATA");
            Console.WriteLine("2 - INSERT DATA");
            Console.WriteLine("3 - UPDATE DATA");
            Console.WriteLine("4 - DELETE DATA");
            Console.WriteLine("5 - RESET");
            Console.WriteLine("6 - SHOW DATA");
            Console.WriteLine("7 - EXIT");
            Console.Write("Enter code: ");
            string todo = Console.ReadLine();

            switch (todo) 
        {
                case "1":
                    Console.Write("\nEnter new data to be added: ");
                    string newData = Console.ReadLine();
                    list.Add(newData);
                    Console.WriteLine("New Data has added!");
                    break;

                case "2":
                    if (list.Count == 0)
                    {
                        Console.WriteLine("List is empty. Adding at index 0.");
                        Console.Write("Enter data to insert: ");
                        string insertVal = Console.ReadLine();
                        list.Insert(0, insertVal);
                        Console.WriteLine("Data has been inserted successfully.");
                        break;
                    }

                    Console.Write($"Enter index location (0 to {list.Count}): ");
                    if (int.TryParse(Console.ReadLine(), out int insertIndex) && insertIndex >= 0 && insertIndex <= list.Count)
                    {
                        Console.Write("Enter data to insert: ");
                        string insertData = Console.ReadLine();
                        list.Insert(insertIndex, insertData);
                        Console.WriteLine("Data has been inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index location.");
                    }
                    break;

                case "3":
                    if (list.Count == 0)
                    {
                        Console.WriteLine("List is empty.");
                        break;
                    }

                    Console.Write($"Enter index location (0 to {list.Count - 1}): ");
                    if (int.TryParse(Console.ReadLine(), out int updateIndex) && updateIndex >= 0 && updateIndex < list.Count)
                    {
                        Console.Write("Enter new data: ");
                        string updateData = Console.ReadLine();
                        list[updateIndex] = updateData;
                        Console.WriteLine("Data updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid index location.");
                    }
                    break;

                case "4":
                    if (list.Count == 0)
                    {
                        Console.WriteLine("List is empty.");
                        break;
                    }

                    Console.Write("Enter data to delete: ");
                    string deleteData = Console.ReadLine();
                    if (list.Contains(deleteData))
                    {
                        list.Remove(deleteData);
                        Console.WriteLine("Data has been removed!");
                    }
                    else
                    {
                        Console.WriteLine("Data not found in the list.");
                    }
                    break;

                case "5":
                    list.Clear();
                    Console.WriteLine("List reset successfully.");
                    break;

                case "6":
                    if (list.Count == 0)
                    {
                        Console.WriteLine("List is empty.");
                    }
                    else
                    {
                        Console.Write("Current items: ");
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.Write(list[i] + (i < list.Count - 1 ? " " : ""));
                        }
                        Console.WriteLine();
                    }
                    break;

                case "7":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 7.");
                    break;
            }
        }
    }
}
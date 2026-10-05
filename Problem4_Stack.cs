using System;
using System.Collections.Generic;

struct Operation
{
    public string Action;
    public string StudentNumber;
    public string StudentName;
}

class Problem4Program
{
    static Stack<Operation> history =
        new Stack<Operation>();

    
    static void adding()
    {
        Operation operation = new Operation();

        operation.Action = "Added";
        operation.StudentNumber = "2025-001";
        operation.StudentName = "Kyle";
        history.Push(operation);

        operation = new Operation();
        operation.Action = "Added";
        operation.StudentNumber = "2025-002";
        operation.StudentName = "Marjun";
        history.Push(operation);

        operation = new Operation();
        operation.Action = "Updated";
        operation.StudentNumber = "2025-001";
        operation.StudentName = "Zyril";
        history.Push(operation);

        operation = new Operation();
        operation.Action = "Delete";
        operation.StudentNumber = "2025-001";
        operation.StudentName = "Zyril";
        history.Push(operation);

    }
    static void ViewHistory()
    {
        if (history.Count == 0)
        {
            Console.WriteLine("No operation history.");
            return;
        }

        Console.WriteLine("\n===== OPERATION HISTORY =====");

        int number = 1;

        foreach (Operation operation in history)
        {
            Console.WriteLine(
                number + ". " +
                operation.Action + " " +
                operation.StudentName
            );

            number++;
        }
    }

    static void ViewLastOperation()
    {
        if (history.Count == 0)
        {
            Console.WriteLine("No operation history.");
            return;
        }

        Operation operation = history.Peek();

        Console.WriteLine("\n===== LAST OPERATION =====");
        Console.WriteLine("Action: " + operation.Action);
        Console.WriteLine("Student Number: " + operation.StudentNumber);
        Console.WriteLine("Student Name: " + operation.StudentName);
    }

    static void RemoveLastOperation()
    {
        if (history.Count == 0)
        {
            Console.WriteLine("No operation to remove.");
            return;
        }

        Operation operation = history.Pop();

        Console.WriteLine(
            "Removed: " +
            operation.Action + " " +
            operation.StudentName
        );
    }

    static void Main()
    {
        adding();

        int choice;

        do
        {
            Console.WriteLine("\n===== OPERATION HISTORY =====");
            Console.WriteLine("1. View Operation History");
            Console.WriteLine("2. View Last Operation");
            Console.WriteLine("3. Remove Last Operation");
            Console.WriteLine("4. Exit");

            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                ViewHistory();
            else if (choice == 2)
                ViewLastOperation();
            else if (choice == 3)
                RemoveLastOperation();
            else if (choice == 4)
                Console.WriteLine("Program exited.");
            else
                Console.WriteLine("Invalid choice.");

        } while (choice != 4);
    }
}

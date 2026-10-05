using System;
using System.Collections.Generic;

struct StudentRequest
{
    public string StudentNumber;
    public string StudentName;
    public string RequestType;
}

class Problem3Program
{
    static Queue<StudentRequest> requests =
        new Queue<StudentRequest>();

    static void AddRequest()
    {
        StudentRequest request;

        Console.Write("Enter Student Number: ");
        request.StudentNumber = Console.ReadLine();

        Console.Write("Enter Student Name: ");
        request.StudentName = Console.ReadLine();

        Console.Write("Enter Request Type: ");
        request.RequestType = Console.ReadLine();

        requests.Enqueue(request);

        Console.WriteLine("Request added successfully!");
    }

    static void ViewRequests()
    {
        if (requests.Count == 0)
        {
            Console.WriteLine("No pending requests.");
            return;
        }

        Console.WriteLine("\n===== PENDING REQUESTS =====");

        foreach (StudentRequest request in requests)
        {
            Console.WriteLine("Student Number: " + request.StudentNumber);
            Console.WriteLine("Student Name: " + request.StudentName);
            Console.WriteLine("Request Type: " + request.RequestType);
            Console.WriteLine("----------------------------");
        }
    }

    static void ProcessRequest()
    {
        if (requests.Count == 0)
        {
            Console.WriteLine("No requests to process.");
            return;
        }

        StudentRequest request = requests.Dequeue();

        Console.WriteLine("\nProcessing Request...");
        Console.WriteLine("Student Number: " + request.StudentNumber);
        Console.WriteLine("Student Name: " + request.StudentName);
        Console.WriteLine("Request Type: " + request.RequestType);

        Console.WriteLine("Request processed successfully!");
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== STUDENT REQUEST QUEUE =====");
            Console.WriteLine("1. Add Request");
            Console.WriteLine("2. View Pending Requests");
            Console.WriteLine("3. Process Request");
            Console.WriteLine("4. Exit");

            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                AddRequest();
            else if (choice == 2)
                ViewRequests();
            else if (choice == 3)
                ProcessRequest();
            else if (choice == 4)
                Console.WriteLine("Program exited.");
            else
                Console.WriteLine("Invalid choice.");

        } while (choice != 4);
    }
}

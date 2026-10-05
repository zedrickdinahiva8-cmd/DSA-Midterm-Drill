using System;
using System.Collections.Generic;

struct DictionaryStudent
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Problem2Program
{
    static Dictionary<string, DictionaryStudent> students =
        new Dictionary<string, DictionaryStudent>();

    static void AddStudent()
    {
        DictionaryStudent student;

        Console.Write("Enter Student Number: ");
        student.StudentNumber = Console.ReadLine();

        Console.Write("Enter Name: ");
        student.Name = Console.ReadLine();

        Console.Write("Enter Program: ");
        student.Program = Console.ReadLine();

        Console.Write("Enter Year Level: ");
        student.YearLevel = Convert.ToInt32(Console.ReadLine());

        students[student.StudentNumber] = student;

        Console.WriteLine("Student added successfully!");
    }

    static void SearchStudent()
    {
        Console.Write("Enter Student Number to search: ");
        string number = Console.ReadLine();

        if (students.ContainsKey(number))
        {
            DictionaryStudent student = students[number];

            Console.WriteLine("\nStudent Found!");
            Console.WriteLine("Student Number: " + student.StudentNumber);
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Program: " + student.Program);
            Console.WriteLine("Year Level: " + student.YearLevel);
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    static void DisplayStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        Console.WriteLine("\n===== ALL STUDENTS =====");

        foreach (DictionaryStudent student in students.Values)
        {
            Console.WriteLine("Student Number: " + student.StudentNumber);
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Program: " + student.Program);
            Console.WriteLine("Year Level: " + student.YearLevel);
            Console.WriteLine("------------------------");
        }
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== STUDENT LOOKUP =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Display Students");
            Console.WriteLine("4. Exit");

            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                AddStudent();
            else if (choice == 2)
                SearchStudent();
            else if (choice == 3)
                DisplayStudents();
            else if (choice == 4)
                Console.WriteLine("Program exited.");
            else
                Console.WriteLine("Invalid choice.");

        } while (choice != 4);
    }
}

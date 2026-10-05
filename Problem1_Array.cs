using System;

struct Student
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Problem1Program
{
    static Student[] students = new Student[10];
    static int studentCount = 0;

    static void AddStudent()
    {
        if (studentCount == 10)
        {
            Console.WriteLine("Maximum of 10 students only.");
            return;
        }

        Student student;

        Console.Write("Enter Student Number: ");
        student.StudentNumber = Console.ReadLine();

        Console.Write("Enter Name: ");
        student.Name = Console.ReadLine();

        Console.Write("Enter Program: ");
        student.Program = Console.ReadLine();

        Console.Write("Enter Year Level: ");
        student.YearLevel = Convert.ToInt32(Console.ReadLine());

        students[studentCount] = student;
        studentCount++;

        Console.WriteLine("Student added successfully!");
    }

    static void DisplayStudents()
    {
        if (studentCount == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        Console.WriteLine("\n===== ALL STUDENTS =====");

        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine("Student Number: " + students[i].StudentNumber);
            Console.WriteLine("Name: " + students[i].Name);
            Console.WriteLine("Program: " + students[i].Program);
            Console.WriteLine("Year Level: " + students[i].YearLevel);
            Console.WriteLine("------------------------");
        }
    }

    static void SearchStudent()
    {
        Console.Write("Enter Student Number to search: ");
        string number = Console.ReadLine();

        for (int i = 0; i < studentCount; i++)
        {
            if (students[i].StudentNumber == number)
            {
                Console.WriteLine("\nStudent Found!");
                Console.WriteLine("Name: " + students[i].Name);
                Console.WriteLine("Program: " + students[i].Program);
                Console.WriteLine("Year Level: " + students[i].YearLevel);
                return;
            }
        }

        Console.WriteLine("Student not found.");
    }

    static void UpdateStudent()
    {
        Console.Write("Enter Student Number to update: ");
        string number = Console.ReadLine();

        for (int i = 0; i < studentCount; i++)
        {
            if (students[i].StudentNumber == number)
            {
                Console.Write("Enter New Name: ");
                students[i].Name = Console.ReadLine();

                Console.Write("Enter New Program: ");
                students[i].Program = Console.ReadLine();

                Console.Write("Enter New Year Level: ");
                students[i].YearLevel = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Student updated successfully!");
                return;
            }
        }

        Console.WriteLine("Student not found.");
    }

    static void DeleteStudent()
    {
        Console.Write("Enter Student Number to delete: ");
        string number = Console.ReadLine();

        for (int i = 0; i < studentCount; i++)
        {
            if (students[i].StudentNumber == number)
            {
                for (int j = i; j < studentCount - 1; j++)
                {
                    students[j] = students[j + 1];
                }

                studentCount--;

                Console.WriteLine("Student deleted successfully!");
                return;
            }
        }

        Console.WriteLine("Student not found.");
    }

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== STUDENT RECORD MANAGEMENT =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");

            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                AddStudent();
            else if (choice == 2)
                DisplayStudents();
            else if (choice == 3)
                SearchStudent();
            else if (choice == 4)
                UpdateStudent();
            else if (choice == 5)
                DeleteStudent();
            else if (choice == 6)
                Console.WriteLine("Program exited.");
            else
                Console.WriteLine("Invalid choice.");

        } while (choice != 6);
    }

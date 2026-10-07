using System;
using System.Collections.Generic;

struct Student
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Program
{
    static void Main()
    {
        Dictionary<string, Student> studentDictionary =
            new Dictionary<string, Student>();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("    STUDENT LOOKUP USING DICTIONARY");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Display All Students");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            // ADD
            if (choice == "1")
            {
                Console.Write("Enter Student Number: ");
                string number = Console.ReadLine();

                if (studentDictionary.ContainsKey(number))
                {
                    Console.WriteLine("Student Number already exists!");
                    continue;
                }

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Program: ");
                string program = Console.ReadLine();

                Console.Write("Enter Year Level: ");
                int year = Convert.ToInt32(Console.ReadLine());

                Student student = new Student();

                student.StudentNumber = number;
                student.Name = name;
                student.Program = program;
                student.YearLevel = year;

                studentDictionary.Add(number, student);

                Console.WriteLine("Student added successfully!");
            }

            // SEARCH
            else if (choice == "2")
            {
                Console.Write("Enter Student Number to search: ");
                string number = Console.ReadLine();

                if (studentDictionary.ContainsKey(number))
                {
                    Student student = studentDictionary[number];

                    Console.WriteLine();
                    Console.WriteLine("Student Found!");
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

            // DISPLAY
            else if (choice == "3")
            {
                if (studentDictionary.Count == 0)
                {
                    Console.WriteLine("No student records found.");
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("=========== ALL STUDENTS ===========");

                foreach (KeyValuePair<string, Student> item
                    in studentDictionary)
                {
                    Student student = item.Value;

                    Console.WriteLine("Student Number: "
                        + student.StudentNumber);
                    Console.WriteLine("Name: " + student.Name);
                    Console.WriteLine("Program: " + student.Program);
                    Console.WriteLine("Year Level: " + student.YearLevel);
                    Console.WriteLine("------------------------------------");
                }
            }

            // EXIT
            else if (choice == "4")
            {
                Console.WriteLine("Program exited.");
                break;
            }

            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}

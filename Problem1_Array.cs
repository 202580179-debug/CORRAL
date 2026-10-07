using System;

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
        Student[] students = new Student[10];
        int studentCount = 0;

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("     STUDENT RECORD MANAGEMENT");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            // ADD STUDENT
            if (choice == "1")
            {
                if (studentCount >= 10)
                {
                    Console.WriteLine("Student limit reached!");
                    continue;
                }

                Console.Write("Enter Student Number: ");
                string number = Console.ReadLine();

                // Check duplicate student number
                bool duplicate = false;

                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == number)
                    {
                        duplicate = true;
                        break;
                    }
                }

                if (duplicate)
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

                students[studentCount].StudentNumber = number;
                students[studentCount].Name = name;
                students[studentCount].Program = program;
                students[studentCount].YearLevel = year;

                studentCount++;

                Console.WriteLine("Student added successfully!");
            }

            // DISPLAY STUDENTS
            else if (choice == "2")
            {
                if (studentCount == 0)
                {
                    Console.WriteLine("No student records found.");
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("=========== STUDENT RECORDS ===========");

                for (int i = 0; i < studentCount; i++)
                {
                    Console.WriteLine("Student Number: " + students[i].StudentNumber);
                    Console.WriteLine("Name: " + students[i].Name);
                    Console.WriteLine("Program: " + students[i].Program);
                    Console.WriteLine("Year Level: " + students[i].YearLevel);
                    Console.WriteLine("---------------------------------------");
                }
            }

            // SEARCH STUDENT
            else if (choice == "3")
            {
                Console.Write("Enter Student Number to search: ");
                string number = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == number)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Student Found!");
                        Console.WriteLine("Student Number: " + students[i].StudentNumber);
                        Console.WriteLine("Name: " + students[i].Name);
                        Console.WriteLine("Program: " + students[i].Program);
                        Console.WriteLine("Year Level: " + students[i].YearLevel);

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Student not found.");
                }
            }

            // UPDATE STUDENT
            else if (choice == "4")
            {
                Console.Write("Enter Student Number to update: ");
                string number = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == number)
                    {
                        Console.Write("Enter new Name: ");
                        students[i].Name = Console.ReadLine();

                        Console.Write("Enter new Program: ");
                        students[i].Program = Console.ReadLine();

                        Console.Write("Enter new Year Level: ");
                        students[i].YearLevel =
                            Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Student updated successfully!");

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Student not found.");
                }
            }

            // DELETE STUDENT
            else if (choice == "5")
            {
                Console.Write("Enter Student Number to delete: ");
                string number = Console.ReadLine();

                int index = -1;

                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == number)
                    {
                        index = i;
                        break;
                    }
                }

                if (index == -1)
                {
                    Console.WriteLine("Student not found.");
                }
                else
                {
                    // Move the students after the deleted student
                    for (int i = index; i < studentCount - 1; i++)
                    {
                        students[i] = students[i + 1];
                    }

                    studentCount--;

                    Console.WriteLine("Student deleted successfully!");
                }
            }

            // EXIT
            else if (choice == "6")
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

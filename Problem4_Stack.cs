using System;
using System.Collections.Generic;

struct Operation
{
    public string Action;
    public string StudentNumber;
    public string StudentName;
}

class Program
{
    static void Main()
    {
        Stack<Operation> operationHistory =
            new Stack<Operation>();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("       OPERATION HISTORY");
            Console.WriteLine("===============================");
            Console.WriteLine("1. View Operation History");
            Console.WriteLine("2. View Last Operation");
            Console.WriteLine("3. Remove Last Operation");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            // VIEW HISTORY
            if (choice == "1")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No operations recorded.");
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("OPERATION HISTORY");

                int number = 1;

                foreach (Operation operation in operationHistory)
                {
                    Console.WriteLine(
                        number + ". "
                        + operation.Action
                        + " "
                        + operation.StudentName);

                    number++;
                }
            }

            // VIEW LAST OPERATION
            else if (choice == "2")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No operations recorded.");
                    continue;
                }

                Operation lastOperation =
                    operationHistory.Peek();

                Console.WriteLine();
                Console.WriteLine("Last Operation: "
                    + lastOperation.Action
                    + " "
                    + lastOperation.StudentName);
            }

            // REMOVE LAST OPERATION
            else if (choice == "3")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("No operations to remove.");
                    continue;
                }

                operationHistory.Pop();

                Console.WriteLine(
                    "Last operation removed successfully!");
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

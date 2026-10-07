using System;
using System.Collections.Generic;

struct StudentRequest
{
    public string StudentNumber;
    public string StudentName;
    public string RequestType;
}

class Program
{
    static void Main()
    {
        Queue<StudentRequest> requestQueue =
            new Queue<StudentRequest>();

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("===============================");
            Console.WriteLine("     STUDENT REQUEST QUEUE");
            Console.WriteLine("===============================");
            Console.WriteLine("1. Add Request");
            Console.WriteLine("2. View Pending Requests");
            Console.WriteLine("3. Process Request");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            // ADD REQUEST
            if (choice == "1")
            {
                StudentRequest request = new StudentRequest();

                Console.Write("Enter Student Number: ");
                request.StudentNumber = Console.ReadLine();

                Console.Write("Enter Student Name: ");
                request.StudentName = Console.ReadLine();

                Console.Write("Enter Request Type: ");
                request.RequestType = Console.ReadLine();

                requestQueue.Enqueue(request);

                Console.WriteLine("Request added successfully!");
            }

            // VIEW REQUESTS
            else if (choice == "2")
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("No pending requests.");
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("======= PENDING REQUESTS =======");

                int number = 1;

                foreach (StudentRequest request in requestQueue)
                {
                    Console.WriteLine(number + ". "
                        + request.StudentName
                        + " - "
                        + request.RequestType);

                    number++;
                }
            }

            // PROCESS REQUEST
            else if (choice == "3")
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("No pending requests.");
                    continue;
                }

                StudentRequest request = requestQueue.Dequeue();

                Console.WriteLine();
                Console.WriteLine("Processing Request: "
                    + request.StudentName
                    + " - "
                    + request.RequestType);

                Console.WriteLine("Request processed successfully!");
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

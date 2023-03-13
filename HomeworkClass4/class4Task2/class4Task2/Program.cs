using System;

namespace class4Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string[] studentsG1 = new string[5] { "Ana", "Marko", "Darko", "Goran", "Sonja" };
            string[] studentsG2 = new string[5] { "Martin", "Katerina", "Tamara", "Bojan", "Damjan" };
            Console.WriteLine("Enter student group: ( there are 1 and 2 )");
            string input = Console.ReadLine();
            bool inputSuccessParse = int.TryParse(input, out int output);
            if (!inputSuccessParse )
            {
                Console.WriteLine("Wrong input");
                return; 
            }
            string studentG1; 

            for (int i = 0; i < studentsG1.Length; i++)
            {
                if (output == 1)
                {
                    studentG1 = studentsG1[i];
                }
            }
            Console.WriteLine($" The students in G1 group are: \n {studentsG1[})");

            
            for (int i = 0; i < studentsG2.Length; i++)
            {
                if (output == 2)
                {
                    Console.WriteLine($" The students in G2 group are: \n {studentsG2[i]}");
                }
            }
            


        }
    }
}
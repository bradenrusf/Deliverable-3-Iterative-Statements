using System;
namespace Deliverable_3
{

    class Program
    {

        static void Main(string[] args)
        {
            int input = 0;
            string series = "";
            //declare input and series variables for later
            Console.WriteLine("Enter a positive integer between 1 and 100: ");
            //prompt user for integer
            Boolean done = false;
            Boolean done2 = false;
            //declare boolean variables for try catch while loops
            while (!done)
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                    Console.WriteLine("The entry is: " + input);
                    done = true;
                }
                catch
                {
                    Console.WriteLine("Enter a positive integer");
                }
            }
            //until user enters an integer, keep prompting them to enter an input.
            Console.WriteLine("Specify the series type: Even or Odd");
            while (!done2)
            {
                try
                {
                    series = Console.ReadLine();
                    Console.WriteLine("The entry is: " + series);
                    done2 = true;
                }
                catch
                {
                    Console.WriteLine("Enter Even or Odd");
                }
            }
            //until user enters "Even" or "Odd" keep prompting them to enter an input
            if (series == "Odd")
            {
                Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are: ");
                int i = 1;
                while (i <= input || i == input - 1)
                {
                    Console.WriteLine(i);
                    i = i + 2;
                }
            }
            //if user entered "Odd" series, print out every odd number between 1 and their chosen number.
            if (series == "Even")
            {
                Console.WriteLine("You have selected the " + series + " series. The numbers between 0 and " + input + " are: ");
                int i = 0;
                while (i <= input || i == input - 1)
                {
                    Console.WriteLine(i);
                    i = i + 2;
                }
            }
            //if user entered "Even" series, print out every even number between 0 and their chosen number
        }
    }
}
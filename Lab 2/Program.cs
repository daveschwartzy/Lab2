using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello! This program will tell you if your input integer is even or odd.");
                Console.WriteLine("Please enter your first name.");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter an integer between 1-100 (whole number).");
                int answer;
                bool valid = false;

                do
                {
                    string input = Console.ReadLine();

                    bool success = int.TryParse(input, out answer);
                    

                    if (answer >= 1 && answer <= 100)
                    {
                        if (answer % 2 == 0)
                        {
                            if (answer > 1 && answer < 26)
                            {
                                Console.WriteLine($"{name}, {answer} is even and less than 25.");
                                Console.WriteLine("Would you like to run this program again? (Y/N)");
                                var repeat = Console.ReadLine();
                                if (repeat == "y" || repeat == "Y")
                                {
                                    valid = true;
                                }
                                else
                                {
                                    
                                    Environment.Exit(0);
                                }
                                    
                            }
                            else if (answer >= 26 && answer <= 60)
                            {
                                Console.WriteLine($"{name}, {answer} is even.");
                                Console.WriteLine("Would you like to run this program again? (Y/N)");
                                var repeat = Console.ReadLine();
                                if (repeat == "y" || repeat == "Y")
                                {
                                    valid = true;
                                }
                                else
                                {

                                    Environment.Exit(0);
                                }
                            }
                            else if (answer <= 100)
                            {
                                Console.WriteLine($"{name}, {answer} is even.");
                                Console.WriteLine("Would you like to run this program again? (Y/N)");
                                var repeat = Console.ReadLine();
                                if (repeat == "y" || repeat == "Y")
                                {
                                    valid = true;
                                }
                                else
                                {

                                    Environment.Exit(0);
                                }
                            }
                        }
                        
                        else if (answer % 2 != 0)
                        {
                            if (answer > 60)
                            {
                                Console.WriteLine($"{name}, {answer} is odd.");
                                Console.WriteLine("Would you like to run this program again? (Y/N)");
                                var repeat = Console.ReadLine();
                                if (repeat == "y" || repeat == "Y")
                                {
                                    valid = true;
                                }
                                else
                                {

                                    Environment.Exit(0);
                                }
                            }
                            else
                            {
                                Console.WriteLine($"{name}, {answer} is odd.");
                                Console.WriteLine("Would you like to run this program again? (Y/N)");
                                var repeat = Console.ReadLine();
                                if (repeat == "y" || repeat == "Y")
                                {
                                    valid = true;
                                }
                                else
                                {

                                    Environment.Exit(0);
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, that was not a valid input.");
                        Console.WriteLine("Please enter an integer between 1-100 (whole number).");
                    }
                } while (!valid);
            }
        }
    }
}

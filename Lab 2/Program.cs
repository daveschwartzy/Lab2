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
            Console.WriteLine("Hello! This program will tell you if your input integer is even or odd.");
            bool rep = true;
            while (rep)
            {

                bool valid = false;
                Console.WriteLine("What is your first name?");
                string name = Console.ReadLine();
                Console.WriteLine($"Okay {name}, please enter an integer between 1-100 (whole number).");
                
                do
                {
                    string input = Console.ReadLine();
                    bool success = int.TryParse(input, out int answer);
                    if (answer >= 1 && answer <= 100)
                    {
                        if (answer % 2 == 0)
                        {
                            if (answer > 1 && answer < 26)
                            {
                                Console.WriteLine($"{name}, {answer} is even and less than 25.");
                            }
                            else if (answer >= 26 && answer <= 60)
                            {
                                Console.WriteLine($"{name}, {answer} is even.");
                            }
                            else if (answer <= 100)
                            {
                                Console.WriteLine($"{name}, {answer} is even.");
                                
                            }
                        }
                        else if (answer % 2 != 0)
                        {
                            if (answer > 60)
                            {
                                Console.WriteLine($"{name}, {answer} is odd.");
                            }
                            else
                            {
                                Console.WriteLine($"{name}, {answer} is odd.");
                                }
                        }
                        //asks if user would like to run program again
                        Console.WriteLine("Would you like to run this program again? (Y/N)");
                        string runagain = Console.ReadLine();

                        while (success)
                        {
                            if (runagain == "y" || runagain == "Y")
                            {
                                Console.WriteLine($"Okay {name}, please enter an integer between 1 - 100(whole number).");
                                rep = true;
                                break;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"I'm sorry {name}, that was not a valid input.");
                        Console.WriteLine("Please enter an integer between 1-100 (whole number).");
                    }
                } while (!valid);
            }
        }
    }
}

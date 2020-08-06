using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Blockbuster. I love you.");
            Blockbuster blockbuster = new Blockbuster();

            bool runAgain = true;

            while (runAgain)
            {
                blockbuster.CheckOut();

                runAgain = RunProgramAgain();
            }


        }
        public static bool RunProgramAgain()
        {
            bool validateAgain = true;
            bool repeatProgram = true;

            while (validateAgain)
            {
                Console.WriteLine("Would you like to run this program again? Enter y to run again or n to quit.");
                string playAgain = Console.ReadLine();

                if (playAgain.Length > 1 || playAgain.Length == 0)
                {
                    validateAgain = true;
                }
                else if (playAgain.ToLower() == "y")
                {
                    validateAgain = false;
                    repeatProgram = true;
                    Console.Clear();

                }
                else if (playAgain.ToLower() == "n")
                {
                    validateAgain = false;
                    repeatProgram = false;
                }
                else
                {
                    validateAgain = true;
                }
            }

            return repeatProgram;

        }
    }
}

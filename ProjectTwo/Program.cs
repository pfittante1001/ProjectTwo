using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwo
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("\t\t\tWelcome to the Lucky Number Game\n\n\n\n\n");

            Console.Write("     To play the game, you must enter two numbers. One will be the loweset\n\n");

            Console.Write("                in your range of numbers and one will be the highest. \n\n");

            Console.Write("            You will then be asked to choose six numbers from that range.\n\n");

            Console.Write("       Your winnings will be based on the amount of numbers out of the six you\n\n");

            Console.Write("           have choosen that match the random lucky numbers in your range.\n\n");

            Console.Write("                       Please press the \" Enter\" to continue.\n\n");

            Console.ReadLine();

            bool exitProgram = false;
            while (exitProgram == false)
            {
                //Global variables
                int minNum;
                int tempMinNum;
                int maxNum;

                Console.Clear();
                Console.Write("\n\nPlease enter the min number you have chosen for your range of numbers\n");
                Console.Write("or quit to exit: ");

                string minNumStrUpper = Console.ReadLine().ToUpper();


               while(int.TryParse(minNumStrUpper, out tempMinNum) == false)
                {
                    Console.Write("Please enter a valid number");
                    minNumStrUpper = Console.ReadLine().ToUpper();
                    if (int.TryParse(minNumStrUpper, out tempMinNum) == true)
                    {
                        minNum = tempMinNum;
                    }
                    
                }
              
                minNum = int.Parse(minNumStrUpper);

               while( minNum < 0)
                {
                    Console.Write("Please enter a number greater than zero: ");
                    minNumStrUpper = Console.ReadLine().ToUpper();
                    while (int.TryParse(minNumStrUpper, out tempMinNum) == false)
                    {
                        Console.Write("Please enter a valid number: ");
                        minNumStrUpper = Console.ReadLine().ToUpper();
                        if (int.TryParse(minNumStrUpper, out tempMinNum) == true && tempMinNum > 0)
                        {
                            Console.WriteLine("test");
                            minNum = tempMinNum;
                        }     
                    }

                    Console.WriteLine("test2");
                    minNum = int.Parse(minNumStrUpper);
                }





                Console.WriteLine(minNum);

                exitProgram = true;

            }//end while loop
        }

    }
}

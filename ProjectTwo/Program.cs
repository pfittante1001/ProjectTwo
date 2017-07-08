﻿using System;
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
//Begin Project Part One
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
                int tempMaxNum;
                int[] luckyNum = new int[6];

                Console.Clear();
                Console.Write("\n\nPlease enter the min number you have chosen for your range of numbers\n");
                Console.Write("or quit to exit: ");

                string minNumStrUpper = Console.ReadLine().ToUpper();

                ExitMethod(minNumStrUpper);
                
                while (int.TryParse(minNumStrUpper, out tempMinNum) == false)
                {
                    Console.Write("Please enter a valid number or quit to exit: ");
                    minNumStrUpper = Console.ReadLine().ToUpper();

                    ExitMethod(minNumStrUpper);
                    
                    if (int.TryParse(minNumStrUpper, out tempMinNum) == true)
                    {
                        minNum = tempMinNum;
                    }
                    
                }
              
                minNum = int.Parse(minNumStrUpper);

               while( minNum < 0)
                {
                    Console.Write("Please enter a number greater than zero or quit to exit: ");
                    minNumStrUpper = Console.ReadLine().ToUpper();

                    ExitMethod(minNumStrUpper);
                    
                    while (int.TryParse(minNumStrUpper, out tempMinNum) == false)
                    {
                        Console.Write("Please enter a valid number or quit to exit: ");
                        minNumStrUpper = Console.ReadLine().ToUpper();

                        ExitMethod(minNumStrUpper);
                        
                        if (int.TryParse(minNumStrUpper, out tempMinNum) == true && tempMinNum > 0)
                        {
                            minNum = tempMinNum;
                        }     
                    }
                    minNum = int.Parse(minNumStrUpper);
                }



                //Input and validate max number
                Console.Clear();
                Console.Write("\n\nPlease enter the max number you have chosen for your range of numbers\n");
                Console.Write("or quit to exit: ");

                string maxNumStrUpper = Console.ReadLine().ToUpper();

                ExitMethod(maxNumStrUpper);
                
                while (int.TryParse(maxNumStrUpper, out tempMaxNum) == false)
                {
                    Console.Write("Please enter a valid number or quit to exit: ");
                    maxNumStrUpper = Console.ReadLine().ToUpper();

                    ExitMethod(maxNumStrUpper);
                    
                    if (int.TryParse(maxNumStrUpper, out tempMaxNum) == true)
                    {
                        maxNum = tempMaxNum;
                    }

                }

                maxNum = int.Parse(maxNumStrUpper);

                while (maxNum < 0)
                {
                    Console.Write("Please enter a number greater than zero or quit to exit: ");
                    maxNumStrUpper = Console.ReadLine().ToUpper();

                    ExitMethod(maxNumStrUpper);
                    
                    while (int.TryParse(maxNumStrUpper, out tempMaxNum) == false)
                    {
                        Console.Write("Please enter a valid number or quit to exit: ");
                        maxNumStrUpper = Console.ReadLine().ToUpper();

                        ExitMethod(maxNumStrUpper);
                        
                        if (int.TryParse(maxNumStrUpper, out tempMaxNum) == true && tempMaxNum > 0)
                        {
                            maxNum = tempMaxNum;
                        }
                    }
                    maxNum = int.Parse(maxNumStrUpper);
                }

                while (maxNum == minNum)
                {
                    Console.Write("Please enter a number greater than {0} or quit to exit: ", minNum);
                    maxNumStrUpper = Console.ReadLine().ToUpper();

                    ExitMethod(maxNumStrUpper);

                    while (int.TryParse(maxNumStrUpper, out tempMaxNum) == false)
                    {
                        Console.Write("Please enter a valid number or quit to exit: ");
                        maxNumStrUpper = Console.ReadLine().ToUpper();

                        ExitMethod(maxNumStrUpper);

                        if (int.TryParse(maxNumStrUpper, out tempMaxNum) == true && tempMaxNum > 0)
                        {
                            maxNum = tempMaxNum;
                        }
                    }
                    maxNum = int.Parse(maxNumStrUpper);
                }

                Console.Clear();
                Console.Write("\n\n    Please enter your six numbers. You cannot enter the same number twice.\n");
                Console.Write("\n\n              The numbers you enter must be between {0} and {1}\n\n\n\n", minNum, maxNum);
               
                for (int i = 0; i < luckyNum.Length; i++)
                {
                    Console.Write("Please enter lucky number {0} or quit to exit: ", i + 1);
                    maxNumStrUpper = Console.ReadLine().ToUpper();

                    ExitMethod(maxNumStrUpper);

                    luckyNum[i] = int.Parse(maxNumStrUpper);
                    
                    while ((luckyNum[i] < minNum) || (luckyNum[i] > maxNum))
                    {
                        Console.Write("Please enter a number between {0} and {1} or quit to exit: ", minNum, maxNum);
                        maxNumStrUpper = Console.ReadLine().ToUpper();

                        ExitMethod(maxNumStrUpper);

                        luckyNum[i] = int.Parse(maxNumStrUpper);
                        
                    }
                }
//End Project Part One
//Begin Project Part Two

                //Input and validate max number
                //Console.WriteLine(minNum);
                //Console.WriteLine(maxNum);
                exitProgram = true;
            }//end while loop
        }

        public static void ExitMethod(string exitPro)
        {
            if (exitPro == "QUIT")
            {
                Console.Clear();
                Console.Write("\n\n\n\n\n\n                         No one likes a quitter\n\n");
                Console.Write("                             Bye Felicia!\n\n\n\n");
                System.Environment.Exit(1);
            }
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Pete Fittante
 * WeCanCodeITBootCamp First Project
 * 7/9/2017
 * A console application that will is a lucky numbers guessing game similar to the lottery. 
 * The user will choose a range of numbers and then try to guess all six of the numbers that 
 * will be randomly generated within the range. The user will win a portion of the jackpot based 
 * on the number of numbers guessed correctly.
 * 
 * 
 * 
 * This program receives input from a user, and developes an output based on the users input,
 * then presents a prediction of the users future.
 * 
 * I used the following to complete this project:
 * If statements
 * Nested If Statements
 * If Else Statements
 * Switch Statements
 * String Arrays and .Contains method to decrease the number of parameters in the If statements
 * While Loop
 * Global Variables
 * int.TryParse() to correct the fatal exception when the wrong input was given by the user
 *  
 */

namespace ProjectTwo
{
    class Program
    {

        static void Main(string[] args)
        {
            //Begin Project Two Part One
            bool exitProgram = false;
            while (exitProgram == false)
            {
                //Global variables
                int minNum;
                int tempMinNum;
                int maxNum;
                int tempMaxNum;
                int[] luckyNum = new int[6];
                int[] randNumArray = new int[6];
                int numMatch1;
                int numMatch2;
                int counter = 0;
                Console.Write("\t\t\tWelcome to the Lucky Number Game\n\n\n\n\n");

            Console.Write("     To play the game, you must enter two numbers. One will be the loweset\n\n");

            Console.Write("                in your range of numbers and one will be the highest. \n\n");

            Console.Write("            You will then be asked to choose six numbers from that range.\n\n");

            Console.Write("       Your winnings will be based on the amount of numbers out of the six you\n\n");

            Console.Write("           have choosen that match the random lucky numbers in your range.\n\n");

            Console.Write("           You win a jackpot of $250,002 if you quess all six numbers.\n\n");

            Console.Write("                       Please press the \" Enter\" to continue.\n\n");


            Console.ReadLine();

           

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

                while (maxNum <= minNum)
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
//End Project Two Part One
//Begin Project Two Part Two
                Console.Clear();
                Random randNum = new Random();

                for (int i = 0; i < 1; i++)
                {
                    randNumArray[i] = randNum.Next(minNum, maxNum);
                    Console.Write(randNumArray[i]);
                    for (int j = 1; j < randNumArray.Length; j++)
                    {
                        int test = randNum.Next(minNum, maxNum);
                        Console.WriteLine(test);
                        while (randNumArray.Contains(test) == true)
                        {
                            test = randNum.Next(minNum, maxNum);
                        }

                        randNumArray[j] = test;
                        Console.Write(randNumArray[j]);
                    }
                    Console.Write("Lucky Number: {0}\n", randNumArray[i]);
                }

                //for(int i = 0; i < randNumArray.Length; i++)
                //{
                //    Console.WriteLine(randNumArray[i]);
                //}



//End Project Two Part Two
//Begin Project Two Part Three

                for (int i = 0; i < randNumArray.Length; i++)
                {
                    
                    for (int j = 0; j < luckyNum.Length; j++)
                    {
                        
                        if ( randNumArray[i] == luckyNum[j])
                        {
                            counter++;
                         }
                    }
                }

                Console.Clear();
                Console.Write("You have guessed {0} numbers correctly. \n\n", counter);
                Console.WriteLine("\nCongradulations you have won ${0}!\n\n", (counter * 41667d));

//End Project Two Part Three
//Begin Project Two Part Four

                Console.Write("Would you like to play again? Type quit to exit or enter to play again: ");
                string exitProgramStr = Console.ReadLine().ToUpper();
                if (exitProgramStr == "QUIT")
                {
                    Console.Clear();
                    Console.Write("\n\n\n\n\n\n                         \"Thanks for playing\"\n\n\n\n\n\n");
                    exitProgram = true;
                }
                else
                {
                    exitProgramStr = " ";
                    Console.Clear();
                }
            }
//End Project Two Part Four
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

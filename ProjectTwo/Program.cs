using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Pete Fittante
 * WeCanCodeITBootCamp First Project
 * 7/9/2017
 * A console application that is a lucky numbers guessing game similar to the lottery. 
 * The user will choose a range of numbers and then try to guess all six of the numbers that 
 * will be randomly generated within the range. The user will win a portion of the jackpot based 
 * on the number of numbers guessed correctly.
 * 
 * This application takes a range inputted by the user as a min number and a max number.  These are the 
 * range of numbers the application will use to generate random lucky numbers.
 * 
 * The user will choose six numbers that will be used to by the application to determine any matches
 * 
 * The user is given the oportunity whenever they are asked to enter a value to quit the application
 * 
 * The apllication has the following parameters:
 * Part One
 * 
 *  The users lucky numbers are placed in the luckNum array
 *  User must enter min and max values greater than or equal to zero
 *  User must also enter a max value not equal to the min value
 *  User cannot enter the same lucky number twice
 *  
 * Part Two
 * 
 *  This section genterates the random lucky numbers
 *  The randcom numbers are place in the randNumArray
 *  The randNumArray is checked for dupilicate numbers
 *  
 * Part Three
 * 
 *  The number of correct quesses is calculated
 *  The amount of winnings is calculated
 *  
 * Part Four
 * 
 *  The user winnings or lack thereof are displayed
 *  The user is given the option to play again or quit
 * 
 * I used the following to complete this project:
 * Variables and Basic Types
 * Operators and Expressions
 * Conditionals
 * Loops
 * Arrays
 * Random number generator 
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

            //While loop allows user to start new game or quit at end of game
            while (exitProgram == false)
            {
                //Global variables

                int minNum;
                int tempMinNum;
                int maxNum;
                int tempMaxNum;
                int[] luckyNum = new int[6];
                int[] randNumArray = new int[6];
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


                //The following section solicits a min value from the user and performs validatation
                Console.Clear();
                Console.Write("\n\nPlease enter the min number you have chosen for your range of numbers\n");
                Console.Write("or quit to exit: ");

                string minNumStrUpper = Console.ReadLine().ToUpper();

                ExitMethod(minNumStrUpper);

                //The following code also handles the exception thrown by the IDE when an the user enters an invalid string.  
                //Example of an invalid string would be "test"
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

               //The following code ensures the user enters a value for min greater than or equal to zero
               while( minNum < 0)
                {
                    Console.Write("Please enter a number greater than zero or quit to exit: ");
                    minNumStrUpper = Console.ReadLine().ToUpper();

                    ExitMethod(minNumStrUpper);

                    //The following code also handles the exception thrown by the IDE when an the user enters an invalid string.  
                    //Example of an invalid string would be "test"
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



                //The following section solicits a max value from the user and performs validatation
                Console.Clear();
                Console.Write("\n\nPlease enter the max number you have chosen for your range of numbers\n");
                Console.Write("or quit to exit: ");

                string maxNumStrUpper = Console.ReadLine().ToUpper();

                ExitMethod(maxNumStrUpper);

                //The following code also handles the exception thrown by the IDE when an the user enters an invalid string.  
                //Example of an invalid string would be "test"
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

                //The following code ensures the user enters a value for max greater than or equal to zero
                while (maxNum < 0)
                {
                    Console.Write("Please enter a number greater than zero or quit to exit: ");
                    maxNumStrUpper = Console.ReadLine().ToUpper();

                    ExitMethod(maxNumStrUpper);

                    //The following code also handles the exception thrown by the IDE when an the user enters an invalid string.  
                    //Example of an invalid string would be "test"
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

                //The following code ensures the user enters a value for max that is greater than or not equal to the min value
                while (maxNum <= minNum)
                {
                    Console.Write("Please enter a number greater than {0} or quit to exit: ", minNum);
                    maxNumStrUpper = Console.ReadLine().ToUpper();

                    ExitMethod(maxNumStrUpper);

                    //The following code also handles the exception thrown by the IDE when an the user enters an invalid string.  
                    //Example of an invalid string would be "test"
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


                //The following section solicits six lucky numbers from the user and performs validatation
                Console.Clear();
                Console.Write("\n\n    Please enter your six numbers. You cannot enter the same number twice.\n");
                Console.Write("\n\n              The numbers you enter must be between {0} and {1}\n\n\n\n", minNum, maxNum);

                Console.Write("Please enter lucky number 1 or quit to exit: ");
                maxNumStrUpper = Console.ReadLine().ToUpper();

                ExitMethod(maxNumStrUpper);

                luckyNum[0] = int.Parse(maxNumStrUpper);

                //The following code validates the user input is not less than min or greater than max
                while ((luckyNum[0] < minNum) || (luckyNum[0] > maxNum))
                {
                    Console.Write("Please enter a number between {0} and {1} or quit to exit: ", minNum, maxNum);
                    maxNumStrUpper = Console.ReadLine().ToUpper();

                    ExitMethod(maxNumStrUpper);

                    luckyNum[0] = int.Parse(maxNumStrUpper);

                }

                for (int i = 1; i < luckyNum.Length; i++)
                {
                    Console.Write("Please enter lucky number {0} or quit to exit: ", i);
                    maxNumStrUpper = Console.ReadLine().ToUpper();

                    ExitMethod(maxNumStrUpper);

                    int testNum = int.Parse(maxNumStrUpper);
                    
                    //The following code validates the user input is not less than min or greater than max
                    while ((testNum < minNum) || (testNum > maxNum))
                    {
                        Console.Write("Please enter a number between {0} and {1} or quit to exit: ", minNum, maxNum);
                        maxNumStrUpper = Console.ReadLine().ToUpper();

                        ExitMethod(maxNumStrUpper);

                        testNum = int.Parse(maxNumStrUpper);

                    }

                    //The following code ensures the user does not enter the same value twice
                    while (luckyNum.Contains(testNum) == true)
                    {
                        Console.Write("You cannot enter the same number twice\n\n");
                        Console.Write("Please enter a number other than {0} or quit to exit: ", testNum);
                        maxNumStrUpper = Console.ReadLine().ToUpper();
                        ExitMethod(maxNumStrUpper);
                        testNum = int.Parse(maxNumStrUpper);

                    }

                    luckyNum[i] = testNum;
                }

                //This for loop validates the repeating user entry you must comment Console.Clear at lines 249 and 294
                //for (int k = 0; k < luckyNum.Length; k++)
                //{
                //    Console.WriteLine(luckyNum[k]);
                //}

//End Project Two Part One
//Begin Project Two Part Two

                Console.Clear();
                Random randNum = new Random();

                //The following code generates an array of non duplicating random numbers
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

                
                //The following code validates the random number are not being duplicated. Console.Clear() on line 349 must be commented
                //for(int i = 0; i < randNumArray.Length; i++)
                //{
                //    Console.WriteLine(randNumArray[i]);
                //}



//End Project Two Part Two
//Begin Project Two Part Three

                //The following code checks for equality between the user lucky numbers and the randoms generated numbers
                //A counter is used to calculate the number of matches
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

        //The following method is used to streamline the code use to exit
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

/* 
 * Author - Ben Daley
 * Date - 18 Jan 2023
 * Course - IS 413
 * Assignment - Mission 2
 * Description - This program simulates the rolling of 2 6-sided die. The user will be prompted to enter a number of rolls.
 *      The program will then track how many time the sum total of the die rolled is 2, 3, 4....12. It will then calculate
 *      the total percentage each sum was rolled and create a visual display by printing out asterisks according to each value. *      
 */

using System;

namespace Mission2
{
    class Program
    {
        public static void Main(string[] args)       
        {
            // variable & array declarations 
            string numRolls;
            int numDiceRolls;
            var rand1 = new Random();
            var rand2 = new Random();
            int randNum1;
            int randNum2;
            int rollSum;
            int[] totalRolls = new int[11];
            int[] rollPct = new int[11];

            // counter declarations
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;
            int counter6 = 0;
            int counter7 = 0;
            int counter8 = 0;
            int counter9 = 0;
            int counter10 = 0;
            int counter11 = 0;
            int counter12 = 0;
      
            // welcome message & gathering how many rolls the user would like 
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine();
            Console.Write("How many dice rolls would you like to simulate? ");
            numRolls = Console.ReadLine();
            numDiceRolls = Convert.ToInt32(numRolls);

            // generate 2 random numbers for each roll, calculate the sum, & update counts for each sum
            for (int ctr = 0; ctr < numDiceRolls; ctr++) 
            {
                rollSum = 0;
                randNum1 = rand1.Next(1, 7);
                randNum2 = rand2.Next(1, 7);
                rollSum = randNum1 + randNum2;
                
                // counters to track occurences of each sum
                if (rollSum == 2)
                {
                    counter2++;
                }
                else if (rollSum == 3)
                {
                    counter3++;
                }
                else if (rollSum == 4)
                {
                    counter4++;
                }
                else if (rollSum == 5)
                {
                    counter5++;
                }
                else if (rollSum == 6)
                {
                    counter6++;
                }
                else if (rollSum == 7)
                {
                    counter7++;
                }
                else if (rollSum == 8)
                {
                    counter8++;
                }
                else if (rollSum == 9)
                {
                    counter9++;
                }
                else if (rollSum == 10)
                {
                    counter10++;
                }
                else if (rollSum == 11)
                {
                    counter11++;
                }
                else if (rollSum == 12)
                {
                    counter12++;
                }            
            }

            // populate the totalRolls array with the counters
            totalRolls[0] = counter2;
            totalRolls[1] = counter3;
            totalRolls[2] = counter4;
            totalRolls[3] = counter5;
            totalRolls[4] = counter6;
            totalRolls[5] = counter7;
            totalRolls[6] = counter8;
            totalRolls[7] = counter9;
            totalRolls[8] = counter10;
            totalRolls[9] = counter11;
            totalRolls[10] = counter12;

            // determine the occurence percentage of each outcome
            for (int i = 0; i < totalRolls.Length; i++)
            {
                rollPct[i] = ((totalRolls[i] * 100) / numDiceRolls);
            }

            // display the results heading
            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls. ");
            Console.WriteLine("Total number of rolls = " + numDiceRolls + ".");
            Console.WriteLine();
            
            // print the visual asterisks display based on percentage from above^^
            for (int i = 0; i < rollPct.Length; i++)
            {
                Console.Write((i + 2) + ": ");
                for (int j = 0; j < rollPct[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // goodbye message
            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}

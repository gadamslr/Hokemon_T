using System;

namespace Hokemon_T
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring variables to use in the game

            Hokemon[] ChallengersArray = new Hokemon[3]; // An Array of 3 Hokemon Challengers
            Battle_Arena newBattleObject = new Battle_Arena(); // Creating the Battle object

            Random rnd = new Random();

            Boolean repeatGame = true; // To ask user if they want another Battle
            string result;

            Console.WriteLine("Hello welcome to Hokeworld home of the Hokemon!");

            Halor playerHoke = new Halor(); // INSTANTIATE from Halor child class

            while (repeatGame == true) // While ITERATION to continue more BATTLES
            {

                newBattleObject.requestAChallenger(playerHoke);  // In newBattleObject passing 
                                                             // Hoke02 object as an 
                                                             // Argument

                for (int i = 0; i < 3; i++)
                {
                    ChallengersArray[i] = new Hokemon(); // INSTANTIATING each new Hokemon Challeneger                
                }

                // Creating the BATTLE       
                newBattleObject.theBattle(playerHoke, ChallengersArray[rnd.Next(0,ChallengersArray.Length)]);

                playerHoke.get_details();

                Console.WriteLine("Do you want another battle? (y/n)");
                result = Console.ReadLine();
                if ((result.ToLower())[0] == 'n')
                {
                    repeatGame = false;
                }
            }
        }
    }
}

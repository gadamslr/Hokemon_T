using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon_T
{
    class Battle_Arena
    {
        public void requestAChallenger(Hokemon requestor)
        {
            Console.WriteLine("{0}: says 'I want a challenger!!!'", requestor.Name);
        }

        public void theBattle(Hokemon attacker, Hokemon defender)
        {

            int round = 0;
            int attackValue = 0;
            int defenceValue = 0;
            Hokemon tempHoke;

            Console.WriteLine("{0}: waits...", attacker.Name);
            System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
            Console.WriteLine("{0}: and waits...", attacker.Name);
            System.Threading.Thread.Sleep(1000); // Wait statement for 2 seconds
            Console.WriteLine("{0}: 'I accept the challenge!!", defender.Name);

            Console.WriteLine("*** Contender Stats ***");
            attacker.get_details();
            defender.get_details();

            Console.WriteLine("*** BATTLE BEGINS ***\n");

            while (Convert.ToInt32(defender.Health) >= 0 || Convert.ToInt32(attacker.Health) >= 0)
            {
                round += 1;
                attackValue = attacker.attackCalculator();
                defenceValue = defender.defenceCalculator();

                Console.WriteLine("*** ROUND {0} ***\n\n", round);

                for (int i = 0; i < 2; i++)
                {
                    System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds

                    Console.WriteLine("{0}: Prepares for an attack ...", attacker.Name);
                    System.Threading.Thread.Sleep(1000); // Wait statement for 2 seconds
                    Console.WriteLine("{0}: Attack value: {1}...\n\n", attacker.Name, attackValue);
                    System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
                    Console.WriteLine("{0}: 'Swiftly moves and creates a Defence value of: {1}", defender.Name, defenceValue);
                    System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
                    Console.WriteLine("{0}: Takes damage (HEALTH {1} + Defence {2}) = {3} - Attack {4}\n", defender.Name, defender.Health, defenceValue, (defender.Health + defenceValue), attackValue);
                    defender.Health = (defender.Health + defenceValue) - attackValue;
                    Console.WriteLine("{0}: New HEALTH value: {1} ", defender.Name, ((defender.Health + defenceValue) - attackValue));

                    Console.WriteLine("\n*********************\n");

                    // Example of how OBJECTS can be switched identifier names
                    // This saves on having to repeat code
                    Console.WriteLine("\n****\nSwitch turns: Defender becomes the Attacker...\n****\n");
                    tempHoke = attacker;
                    attacker = defender;
                    defender = tempHoke;
                }
            }

            if (attacker.Health > defender.Health)
            {
                Console.WriteLine("{0}: WINS", attacker.Name);  // Produces a LOGICAL error - why??
            }
            else
            {
                Console.WriteLine("{0}: WINS", defender.Name);  // Produces a LOGICAL error - why??
            }
            

        }
 
    }
}

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

            Console.WriteLine("*** BATTLE BEGINS ***");

            while (Convert.ToInt32(defender.Health) >= 0 || Convert.ToInt32(attacker.Health) >= 0)
            {
                round += 1;
                attackValue = attacker.attackCalculator();
                defenceValue = defender.defenceCalculator();

                for (int i = 0; i < 2; i++)
                {

                    Console.WriteLine("*** ROUND {0} ***", round);

                    System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds

                    Console.WriteLine("{0}: Prepares for an attck ...", attacker.Name);
                    System.Threading.Thread.Sleep(1000); // Wait statement for 2 seconds
                    Console.WriteLine("{0}: Attack value {0}...", attacker.Name, attackValue);
                    System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
                    Console.WriteLine("{0}: 'Swiftly moves and creates a Defence value of{1}", defender.Name, defenceValue);
                    System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
                    defender.Health = (defender.Health + defenceValue) - attackValue;
                    Console.WriteLine("{0}: HEALTH = {1} ", defender.Name, ((defender.Health + defenceValue) - attackValue));
                    Console.WriteLine("{0}: HEALTH = {1} ", defender.Name, ((defender.Health + defenceValue) - attackValue));

                    // Example of how OBJECTS can be switched identifier names
                    // This saves on having to repeat code
                    tempHoke = attacker;
                    attacker = defender;
                    defender = attacker;
                }
            }

            if (attacker.Health <= 0)
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

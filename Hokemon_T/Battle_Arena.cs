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
            Console.WriteLine("{0}: waits...", attacker.Name);
            System.Threading.Thread.Sleep(2000); // Wait statement for 2 seconds
            Console.WriteLine("{0}: and waits...", attacker.Name);
            System.Threading.Thread.Sleep(1000); // Wait statement for 2 seconds
            Console.WriteLine("{0}: 'I accept the challenge!!", defender.Name);


        }
 
    }
}

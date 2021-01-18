using System;

namespace Hokemon_T
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Hokeworld home of the Hokemon!");

            // Instantiation of new Hokemon

            Hokemon hoke01 = new Hokemon();  // INSTANTIATE new Hokemon object referred to as Hoke01

            hoke01.get_details();
            Console.WriteLine("Attack value is: {0}", hoke01.attackCalculator());
            Console.WriteLine("Defence value is: {0}", hoke01.defenceCalculator());

            Hokemon hoke02 = new Hokemon();  // INSTANTIATE Hoke02

            hoke02.get_details();
            Console.WriteLine("Attack value is: {0}", hoke02.attackCalculator());
            Console.WriteLine("Defence value is: {0}", hoke02.defenceCalculator());
            
            Hokemon hokemonObject = new Hokemon();  // INSTANTIATE hokemonObject

            hokemonObject.get_details();
            Console.WriteLine("Attack value is: {0}", hokemonObject.attackCalculator());
            Console.WriteLine("Defence value is: {0}", hokemonObject.defenceCalculator());

            Hokemon hoke03 = new Hokemon();  // INSTANTIATE from Hokemon Parent class

            Halor hoke04 = new Halor(); // INSTANTIATE from Halor child class
            Console.WriteLine("I am part of {0} team.", hoke04.team);



            /*

            Battle_Arena newBattleObject = new Battle_Arena();

            newBattleObject.requestAChallenger(hoke02);  // In newBattleObject passing 
                                                         // Hoke02 object as an 
                                                         // Argument

            newBattleObject.theBattle(hoke02, hokemonObject);
            */

        }
    }
}

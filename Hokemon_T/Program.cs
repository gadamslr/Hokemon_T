using System;
using Hokemon_T.impl;
using Hokemon_T.util;

namespace Hokemon_T
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Hokeworld home of the Hokemon!");

            // Instantiation of new Hokemon
/*
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
*/


            Console.WriteLine("Enter a team for your Hokemon: ");
            String team = Console.ReadLine();
            
            Hokemon hoke03 = new Hokemon(EnumUtil.GetEnumValue<PokeTeam>(team));  // INSTANTIATE from Hokemon Parent class

            Hokemon hoke04 = new Hokemon(PokeTeam.Halor); // Same class, but instead gives it a team.

            if (hoke03.getTeam() != PokeTeam.None) {
                Console.WriteLine("I am part of team {0}.", hoke03.getTeam());
            }

            if (hoke04.getTeam() != PokeTeam.None) {
                Console.WriteLine("I am part of team {0}.", hoke04.getTeam());
            }
            



            Battle_Arena newBattleObject = new Battle_Arena();

            newBattleObject.requestAChallenger(hoke03);  // In newBattleObject passing 
                                                         // Hoke02 object as an 
                                                         // Argument

            newBattleObject.theBattle(hoke03, hoke04);

        }
    }
}

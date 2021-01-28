using System;
using System.Collections.Generic;
using System.Text;
using Hokemon_T.impl;

namespace Hokemon_T
{
    class Hokemon
    {
        // MEMBERS - All Attributes, Methods and Properties are MEMBERS of this CLASS

        // VARIABLES a.k.a ATTRIBUTES inside a class can also be refered to as FIELDS
        private string name;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;
        private PokeTeam team;

        // PROPERTIES
                // PROPERTIES are a combination of a field and method - this keeps variables / attributes PRIVATE
                // and allows us to perform checks on what is input
        public string Name         // Notice PROPERTY has no parenthesis its identifier unlike the METHODS below
        {
            get { return name; }
            set { name = value; }
        }
        public int Health         // Health PROPERTY this is public keeping the 'health' 
        {
            get { return health; }
            set { health = value; }
        }
        
        // METHODS
        public Hokemon()  // CONSTRUCTOR method 
        {
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);
            team = PokeTeam.None;
        }

        public Hokemon(PokeTeam pokeTeam) {
            provide_name();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, 100);
            speed = random_int_generator(10, 100);
            defense = random_int_generator(10, 100);
            team = pokeTeam;
        }

        public void get_details()
        {
            Console.WriteLine("\n\n************\nName: {0}\nHealth: {1}/{2}\nAttack: {3}\nSpeed: {4}\nDefense: {5}\n**********\n", name, health, max_health, attack, speed, defense);
        }         // get_details METHOD 

        public void provide_name()
        {
            Console.WriteLine("Enter a name for your Hokemon: ");
            name = Console.ReadLine();
        }

        public PokeTeam getTeam() {
            return team;
        }

        public int random_int_generator(int min_value, int max_value) // PARAMETERS int min_value, int max_value
        {
            Random rnd = new Random(); // INSTANTIATING the rnd object from the RANDOM class 

            int randomValue;

            randomValue = rnd.Next(min_value, max_value);

            return randomValue;
        }

        public int attackCalculator()
        {
            int attackValue;
            Random rnd = new Random();
            attackValue = ((attack * speed) / 2) * rnd.Next(0, 2); // % Modulo how many times the value 2 goes into the attach calculation
            // attackValue = Math.Floor(((attack * speed) / 2 ) * rnd.Next(0, 2)); // % Modulo how many times the value 2 goes into the attach calculation

            return attackValue;
        }
        public int defenceCalculator()
        {
            int defenceValue;
            Random rnd = new Random();

            defenceValue = (defense * speed) / 10 * rnd.Next(0, 2);

            return defenceValue;
        }
    }
}

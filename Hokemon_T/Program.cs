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

            //Console.WriteLine("Name: {0}", hoke01.get_name());

            hoke01.get_details();

            Hokemon hoke02 = new Hokemon(); // INSTANTIATE a second Hokemon

            hoke02.get_details();

            Hokemon hoke03 = new Hokemon(); // INSTANTIATE a third Hokemon

            hoke03.get_details();

        }
    }
}

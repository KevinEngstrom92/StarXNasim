using System;
using static System.Console;
using System.Threading;
using Rocket_Simulator.Domain;
using System.Collections.Generic;

namespace Rocket_Simulator
{
    class Program
    {

        public static Rocket[] rocketlist = new Rocket[100];
        public static List<Rocket> rocketList = new List<Rocket>();

        static void Main(string[] args)
        {
            bool isWorking = true;


            while (isWorking)
            {
                Clear();

                WriteLine(" 1. Add rocket >");
                WriteLine(" 2. List Rockets >");
                WriteLine(" 3. Run simulation >");
                WriteLine(" 4. Exit > ");

                ConsoleKeyInfo pressedkey = ReadKey(true);

                Clear();

                // rocketlist[0] = new Rocket(string name, int fuelAmountInKilograms, int grossWeight, int thrustVacuum);

                switch (pressedkey.Key)
                {
                    case ConsoleKey.D1:

                        WriteLine("--Add your Rocket--");                           //--------------------------------------------------------
                        WriteLine();                                                //
                        WriteLine(" 1. Starship, SpaceX");                          //
                        WriteLine(" 2. Heavy Falcon, SpaceX");                      //
                        ReadKey();                                                  //Switch här igen eftersom 1 väljer starship och 2 Heavy falcon.
                        Rocket raket = new Starship("The StarShip", 1000, 100, 100);//------------------------------------------------------------
                        if (Program.rocketList.Count == 0)
                        {
                            Program.rocketList.Add(raket);
                            Console.WriteLine("Rocket Added");
                            Console.ReadKey();
                            break;
                        }
                        
                        foreach (var therocket in rocketList)
                        {
                                if (therocket.Name == raket.Name)
                            {
                                WriteLine("Rocket already added");
                                Console.ReadKey();
                            }
                            else
                            {
                                rocketList.Add(raket);
                            }

                            //Rocket raket = new Starship("The StarShip", 1000, 100, 100);//------------------------------------------------------------
                            //if (Program.rocketList.Count == 0)
                            //{
                            //    Program.rocketList.Add(raket);
                            //    Console.WriteLine("Rocket Added");
                            //    Console.ReadKey();
                            //    break;
                            //}
                                                                                                                        //Ska kunna användas "typ" i nya switchen
                            //foreach (var therocket in rocketList)
                            //{
                            //    if (therocket.Name == raket.Name)
                            //    {
                            //        WriteLine("Rocket already added");
                            //        Console.ReadKey();
                            //    }
                            //    else
                            //    {
                            //        rocketList.Add(raket);
                            //    }
                            }
                        break;
                    case ConsoleKey.D2:

                        WriteLine("  Simulated rockets     ");
                        WriteLine("------------------------------------------------------------------------");

                        foreach (var rocket in rocketList)
                        {
                            if (rocket == null) continue;
                            Console.WriteLine($"{Rocket.name}");
                        }
                        Console.ReadKey(true);


                        break;


                    case ConsoleKey.D3:


                        break;


                    case ConsoleKey.D4:

                        isWorking = false;

                        break;


                }

            }
        }

    }
}

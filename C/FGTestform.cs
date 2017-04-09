using System;

namespace Excercise3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(@"Pepino software [Version 10.0.10586]
(c) 2016 FG Corporation. All rights reserved.
");
            Console.WriteLine("THERE IS A COMMON BUG, DO NOT USE DOTS FOR DECIMALS! INSTEAD USE COMMAS \n  ");
        again:
            

            try
            {
                
                Console.WriteLine("Enter the speed limit of the road:");
                var speedLimit = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the speed of your car:");
                var speedOfCar = float.Parse(Console.ReadLine());

                if (speedOfCar <= speedLimit)
                {
                    Console.WriteLine("You drive at an acceptable speed.\n");
                    
                }
                else if (speedOfCar > speedLimit)
                {
                    float overSpeed = speedOfCar - speedLimit;
                    float demerit = overSpeed / 5.0f;
                    if (demerit > 12)
                    {
                        Console.WriteLine("You have {0} demerit points. Your driverslicense is suspended.\n", demerit);
                    }
                    else
                    {
                        if ((demerit < 12) && (demerit != 0))
                        {
                            Console.WriteLine("You're driving too fast. Your demerit points are {0}\n", demerit);
                        }


                        else if (demerit > 100)
                        {
                            Console.WriteLine("HOW ARE YOU STILL ALIVE?! I'M CALLING THE POLICE!\n");
                        }
                    }
                }
            askAgain:
                try
                {
                    Console.WriteLine("Do you want to continue? y/n \n");
                    var yesNo = Console.ReadLine();
                    switch (yesNo)
                    {
                        case "n":
                        case "N":
                            Console.WriteLine("\nThank you for using FGT Programs...");
                            break;
                        case "y":
                        case "Y":
                            Console.WriteLine("\n");
                            Console.Clear();
                            Console.WriteLine("THERE IS A COMMON BUG, DO NOT USE DOTS FOR DECIMALS! INSTEAD USE COMMAS \n  ");
                            goto again;
                        default:
                            Console.WriteLine("Please type y / n....");
                            goto askAgain;
                    }
                }
                catch
                {
                    Console.WriteLine("Please type y / n....");
                    goto askAgain;
                    
                }
                
                
            }
            catch
            {
                Console.Clear();
                
                Console.WriteLine("Something went wrong, please try again.\n");
                
                goto again;
                
            }
            
        }

        }



    }



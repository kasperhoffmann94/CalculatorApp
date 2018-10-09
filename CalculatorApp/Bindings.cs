using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;
using CalculatorLibrary;

namespace CalculatorApp
{
    public class Bindings : IBindings
    {
        public void Call(string id)

        {
            double first;
        double second;

            switch (id)
            {
                case "add":
                    Console.WriteLine(CalculatorLibrary.Calculator.Add());
                    break;

                case "sub":
                    Console.WriteLine(CalculatorLibrary.Calculator.Subtract());
                    break;

                case "something":
                    string temp = "";
                    bool running = true;
                    while (running != false)
                    {
                        Console.Write("Please enter anything: ");
                        temp = Console.ReadLine();
                        if (temp.Length <= 0)
                        {
                            Console.WriteLine("Enter something!");

                        }
                        else
                        {
                            running = false;
                        }
                    }
                    //Console.WriteLine(Functions.DoSomething(temp));
                    break;




                case "another":
                    //Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything() + "\n");
                    break;

                default:

                    break;

            }
        }
    }
}

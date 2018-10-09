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
        public double getInput()
        {

            double u;
            while(!double.TryParse(Console.ReadLine(), out u))
            {
                Console.WriteLine("Input er ikke gyldigt, venligst indtast gyldtigt tal");
            }
            return u;
        }

        public void Call(string id)

        {

            double u1;
            double u2;

            switch (id)
            {
                case "add":
                    Console.WriteLine("Indtast første tal: ");
                    u1 = getInput();
                    Console.WriteLine("Indtast andet tal: ");
                    u2 = getInput();
                    Console.WriteLine("Resultat: "+ CalculatorLibrary.Calculator.Add(u1,u2));
                    break;

                case "sub":
                    Console.WriteLine("Indtast første tal: ");
                    u1 = getInput();
                    Console.WriteLine("Indtast andet tal: ");
                    u2 = getInput();
                    Console.WriteLine("Resultat: " + CalculatorLibrary.Calculator.Subtract(u1, u2));
                    break;

                case "multiply":
                    Console.WriteLine("Indtast første tal: ");
                    u1 = getInput();
                    Console.WriteLine("Indtast andet tal: ");
                    u2 = getInput();
                    Console.WriteLine("Resultat: " + CalculatorLibrary.Calculator.Multiply(u1, u2));
                    break;

                case "divide":
                    Console.WriteLine("Indtast første tal: ");
                    u1 = getInput();
                    Console.WriteLine("Indtast andet tal: ");
                    u2 = getInput();
                    Console.WriteLine("Resultat: " + CalculatorLibrary.Calculator.Divide(u1, u2));
                    break;

                default:

                    break;

            }
        }
    }
}

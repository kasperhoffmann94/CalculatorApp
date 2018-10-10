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


        public double[] getMultipleInput()
        {
            
            bool valdInput = false;
            double temp = 0.0;
            string input;
            string[] stringToDoubleArray;
            double[] multipleInput = null ;

            while (valdInput != true){

                

                input = Console.ReadLine();
                stringToDoubleArray = input.Split(' ');
                multipleInput = new double[stringToDoubleArray.Length];



                for (int i = 0; i < stringToDoubleArray.Length; i++)
                {


                    if (input.Length <= 0)
                    {
                        Console.WriteLine("Please enter a number");
                    }
                    else if (!double.TryParse(stringToDoubleArray[i], out multipleInput[i]))
                    {
                        Console.WriteLine("that is not a number, please enter a number ");
                        break;
                    }


                    Console.ReadLine();
                    multipleInput[i] = double.Parse(stringToDoubleArray[i]);
                    valdInput = true;
                }

              

            }

            return multipleInput;

         
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

                case "sum":
                    Console.WriteLine("Please enter a series of numbers seperated by spaces, for example ´´10 20 12 22 1 2´´");
                    Console.WriteLine("Resultat: " + CalculatorLibrary.Calculator.Sum(getMultipleInput()));
                    break;

                case "min":
                    Console.WriteLine("Please enter a series of numbers seperated by spaces, for example ´´10 20 12 22 1 2´´");
                    Console.WriteLine("Resultat: " + CalculatorLibrary.Calculator.Minimum(getMultipleInput()));
                    break;

                case "max":
                    Console.WriteLine("Please enter a series of numbers seperated by spaces, for example ´´10 20 12 22 1 2´´");
                    Console.WriteLine("Resultat: " + CalculatorLibrary.Calculator.Maximum(getMultipleInput()));
                    break;

                case "ave":

                    Console.WriteLine("Please enter a series of numbers seperated by spaces, for example ´´10 20 12 22 1 2´´");
                    Console.WriteLine("Resultat: " + CalculatorLibrary.Calculator.Average(getMultipleInput()));
                    break;


                default:
                    Console.WriteLine("That is not a number please enter a number! ");
                    break;

            }
        }
    }
}

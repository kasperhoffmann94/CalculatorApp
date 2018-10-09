using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;
using CalculatorLibrary;

namespace CalculatorApp.cs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {

            Bindings bindings = new Bindings();
            SmartMenu menu = new SmartMenu();
            menu.LoadMenu(":MenuSpec.txt");
            menu.Activate(bindings);
        }
    }
}

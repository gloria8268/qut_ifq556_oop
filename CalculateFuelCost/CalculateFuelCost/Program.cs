using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFuelCost
{
    internal class Program
    {
        static void Main()
        {          
            /* 1. get fule type - evoke method of InputFuelType
               2. evoke method of EnterInfo to get liter and cost, careful for decical especially about dollar */
            string fuelType= InputFuelType();                    

            double litres = EnterInfo("The number of litres of fuel filled in the car >>");
            double costPerLitre = EnterInfo("The cost of the fuel >>");

            double totalCost = CalculateTotalCost(litres, costPerLitre);

            Console.WriteLine($"The number of Litres of fuel: {litres:F2}");
            Console.WriteLine($"Fuel Type: {fuelType}");
            Console.WriteLine($"Cost of fuel: ${costPerLitre:F2}");
            Console.WriteLine($"Total cost of fuel: ${totalCost:F2}");
        }
        public static bool IsValid(string code)
        {
            /*checking validation of entered fuel type*/
            if (code.Length != 3 || !char.IsUpper(code[0]) || !char.IsDigit(code[1]) || !char.IsDigit(code[2]))
            {
                Console.WriteLine("Please enter a valid fuel type!");
                return false;
            }        
            return true;
        }
        public static string InputFuelType() {
            /*using bool to control re-enter*/
            bool validation = false;
            string enterCode = null;
            while (!validation)
            {
                Console.WriteLine("Please enter fuel type >>");
                enterCode = Console.ReadLine();
                validation = IsValid(enterCode);
            }
            return enterCode;
        }
        public static double EnterInfo (string question)
        {
            Console.WriteLine($"{question}");
            double info = Convert.ToDouble(Console.ReadLine());
            return info;
        }
        public static double CalculateTotalCost(double litresFilled, double costPerLitre)
        {
            double result = litresFilled * costPerLitre;
            return result;
        }
    }
}

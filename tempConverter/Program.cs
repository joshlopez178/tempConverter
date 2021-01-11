//Joshua Lopez 
//COSC 1320 001
//9-18-2019
//Week 3 project
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempConverter
{
    class Program
    {
        static void Main()
        {
            //conversion from Kelvin to Celsius

            Console.WriteLine("Input the temperature value from Kelvin to Celsius: ");
            int kel = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //conversion formula from Kelvin to Celsius

            double KtoC = (kel - 273.15);
            Console.WriteLine("The celsius value is {0}:", KtoC);
            Console.ReadLine();

            Console.WriteLine("Do you want to run this conversion again? (Press y or yes or another key to convert Kelvin to Fahrenhiet.)");
            var yesOrNo = Console.ReadKey();
            if (yesOrNo.KeyChar == 'y')
            {
                Main();

            }
            else
            {
                //conversion from Kelvin to Fahrenheit
                Console.WriteLine("Input the temperature value from Kelvin to Fahrenheit: ");
                int newKel = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //conversion from K to F

                double KtoF = (newKel * (9 / 5)) - 459.67;
                Console.WriteLine("The Fahrenheit value is {0}:", KtoF);
                Console.ReadLine();

            }

        }
    }
}

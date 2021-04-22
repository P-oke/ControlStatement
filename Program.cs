
using System;


namespace ControlStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // int number = 20;
            // if (number == 20)
            // {
            //     Console.WriteLine("Number is 20");
            // }
            // else if (number == 30)
            // {
            //     Console.WriteLine("Number is 300");
            // }

            // else
            // {
            //     Console.WriteLine("Invalid number");

            // }

            // switch (number)
            // {
            //     case 10:
            //         Console.WriteLine("Number is 10");
            //         break;

            //     case 20:
            //         Console.WriteLine("Number is 20");
            //         break;

            //     default:
            //         Console.WriteLine("Invalid number");
            //         break;
            // }
            // int b = 10;

            // while (b < 20) //check condition first
            // {
            //     Console.WriteLine(b);
            //     b++;
            // }

            // string[] cars = { "BMW", "BENZ", "HONDA", "TOYOTA" };

            // string[] cars = new string[4];
            // cars[0] = "BMW";
            // cars[1] = "BMW";
            // cars[2] = "BMW";
            // cars[3] = "BMW";


            // // Console.WriteLine(cars[4]);


            // foreach (var item in cars)
            // {
            //     Console.WriteLine(item);
            // }

            // List<string> Cars = new List<string>();
            // Cars.Add("boy");

            // if (AmountCharged <= 100)
            // {
            //     Console.WriteLine($"Your minimum bill {AmountCharged} is not up to N100");
            // }







            double UnitConsumed = 0;
            double AmountCharged = 0;
            double SurchargeAmount = 0;
            double NetAmount = 0;

            Console.WriteLine("Welcome to your Water Bill Calculator App");


            Console.WriteLine("Enter your customer ID");
            string CustomerId = Console.ReadLine();

            Console.WriteLine("Enter your Name");
            string CustomerName = Console.ReadLine();

            Console.WriteLine("Enter your Unit consumed");
            UnitConsumed = double.Parse(Console.ReadLine());

            if (UnitConsumed <= 199)
            {
                AmountCharged = UnitConsumed * 1.2;
            }
            else if (UnitConsumed >= 200 && UnitConsumed < 400)
            {
                AmountCharged = UnitConsumed * 1.5;

            }
            else if (UnitConsumed >= 400 && UnitConsumed < 600)
            {
                AmountCharged = UnitConsumed * 1.8;

            }
            else
            {
                AmountCharged = UnitConsumed * 2;
            }


            if (AmountCharged >= 300)
            {
                SurchargeAmount = AmountCharged * 0.15;
                NetAmount = SurchargeAmount + AmountCharged;

            }
            if (AmountCharged <= 100 || AmountCharged < 300)
            {
                NetAmount = AmountCharged;

            }


            Console.WriteLine($" Customer IDNO: {CustomerId}\n Customer Name: {CustomerName}\n Unit Consumed: {UnitConsumed}\n Amount Charges @ N2.00 per unit: N {AmountCharged}\n Surchage Amount: N {SurchargeAmount}\n Net Amount paid by the Customer: N {NetAmount}");

        }



    }


}
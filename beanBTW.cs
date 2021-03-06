﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
	class Program
	{
        const float pintoBeanPrice = 1.15f;
        const float blackBeanPrice = 1.98f;
        const float redBeanPrice = 1.95f;
        const float coffeeBeanPrice = 3.70f;
        const float brownBeanPrice = 1.02f;
        const float whiteBeanPrice = 1.02f;
        const float borlottiBeanPrice = 1.19f;
        const float stringBeanPrice = 0.99f;
        const float greenBeanPrice = 2.49f;
        const float kidneyBeanPrice = 0.79f;
        const float btwPercentage = 1.21f;
		static void Main(string[] args)
		{

			Console.Write("Welcome to Magma's Bean Shop.\n");
			Console.Write("Here is our selection of beans:\n");
			Console.Write("____________________\n");
			Console.Write("| 1. Pinto Beans    |\n");
			Console.Write("| 2. Black Beans    |\n");
			Console.Write("| 3. Red Beans      |\n");
			Console.Write("| 4. Coffee Beans   |\n");
			Console.Write("| 5. Brown Beans    |\n");
			Console.Write("| 6. White Beans    |\n");
			Console.Write("| 7. Borlotti Beans |\n");
			Console.Write("| 8. String Beans   |\n");
			Console.Write("| 9. Green Beans    |\n");
			Console.Write("| 10. Kidney Beans  |\n");
			Console.Write("_____________________\n");
			Console.Write("What is your first bean order?\n: ");
			string beanInput = Console.ReadLine();
            if (!(Convert.ToInt32(beanInput) == 1 || Convert.ToInt32(beanInput) == 2 || Convert.ToInt32(beanInput) == 3 || Convert.ToInt32(beanInput) == 4 || Convert.ToInt32(beanInput) == 6 || Convert.ToInt32(beanInput) == 7 || Convert.ToInt32(beanInput) == 8 || Convert.ToInt32(beanInput) == 9 || Convert.ToInt32(beanInput) == 10))
            {
                Console.Write("Please enter a valid response.");
                Console.ReadLine();
            }
            else
            {
                int beanInt = Convert.ToInt32(beanInput);
                Console.Write("What amount of beans do you want?\n: "); ;
                int beanAmount = Convert.ToInt32(Console.ReadLine());
                if (beanInt == 1)
                {
                    float beanPrice = pintoBeanPrice * beanAmount;
                    Console.Write("That'll cost:\n" + (pintoBeanPrice * beanAmount) + " BeanCoins without BTW\n" + (pintoBeanPrice * beanAmount * btwPercentage) + " BeanCoins with BTW");
                }
                else if (beanInt == 2)
                {
                    float beanPrice = blackBeanPrice * beanAmount;
                    Console.Write("That'll cost:\n" + (blackBeanPrice * beanAmount) + " BeanCoins without BTW\n" + (blackBeanPrice * beanAmount * btwPercentage) + " BeanCoins with BTW");
                }
                else if (beanInt == 3)
                {
                    float beanPrice = redBeanPrice * beanAmount;
                    Console.Write("That'll cost:\n" + (redBeanPrice * beanAmount) + " BeanCoins without BTW\n" + (redBeanPrice * beanAmount * btwPercentage) + " BeanCoins with BTW");
                }
                else if (beanInt == 4)
                {
                    float beanPrice = coffeeBeanPrice * beanAmount;
                    Console.Write("That'll cost:\n" + (coffeeBeanPrice * beanAmount) + " BeanCoins without BTW\n" + (coffeeBeanPrice * beanAmount * btwPercentage) + " BeanCoins with BTW");
                }
                else if (beanInt == 5)
                {
                    float beanPrice = brownBeanPrice * beanAmount;
                    Console.Write("That'll cost:\n" + (brownBeanPrice * beanAmount) + " BeanCoins without BTW\n" + (brownBeanPrice * beanAmount * btwPercentage) + " BeanCoins with BTW");
                }
                else if (beanInt == 6)
                {
                    float beanPrice = whiteBeanPrice * beanAmount;
                    Console.Write("That'll cost:\n" + (whiteBeanPrice * beanAmount) + " BeanCoins without BTW\n" + (whiteBeanPrice * beanAmount * btwPercentage) + " BeanCoins with BTW");
                }
                else if (beanInt == 7)
                {
                    float beanPrice = borlottiBeanPrice * beanAmount;
                    Console.Write("That'll cost:\n" + (borlottiBeanPrice * beanAmount) + " BeanCoins without BTW\n" + (borlottiBeanPrice * beanAmount * btwPercentage) + " BeanCoins with BTW");
                }
                else if (beanInt == 8)
                {
                    float beanPrice = stringBeanPrice * beanAmount;
                    Console.Write("That'll cost:\n" + (stringBeanPrice * beanAmount) + " BeanCoins without BTW\n" + (stringBeanPrice * beanAmount * btwPercentage) + " BeanCoins with BTW");
                }
                else if (beanInt == 9)
                {
                    float beanPrice = greenBeanPrice * beanAmount;
                    Console.Write("That'll cost:\n" + (greenBeanPrice * beanAmount) + " BeanCoins without BTW\n" + (greenBeanPrice * beanAmount * btwPercentage) + " BeanCoins with BTW");
                }
                else if (beanInt == 10)
                {
                    float beanPrice = kidneyBeanPrice * beanAmount;
                    Console.Write("That'll cost:\n" + (kidneyBeanPrice * beanAmount) + " BeanCoins without BTW\n" + (kidneyBeanPrice * beanAmount * btwPercentage) + " BeanCoins with BTW");
                }
                Console.Write("\nWant to add more beans to your shopping cart?\nY/N : ");
                string shopContinue = Console.ReadLine();
                if (shopContinue.ToUpper() == "Y")
                {

                }
                else if (shopContinue.ToUpper() == "N")
                {
                    Console.Write("Hope to see you another time and enjoy your beans!");
                    System.Threading.Thread.Sleep(2500);
                    Environment.Exit(1);
                }
                else
                {
                    Console.Write("Please enter a valid response.");
                    Console.ReadLine();
                }
            }
        }
	}
}

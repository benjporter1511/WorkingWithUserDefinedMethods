using System;

namespace WorkingWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Heading();
            char aLetter;
            Console.Write("Enter a letter: ");
            aLetter = Convert.ToChar(Console.ReadLine());
            if (isVowel(aLetter))
                Console.WriteLine(aLetter + " is a vowel");
            else
                Console.WriteLine(aLetter + " is a consonant");

            Console.WriteLine("");


            int num1 = 12;
            int num2 = 435;
            Console.WriteLine("num1: " + num1 + ", num2: " + num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("num1: " + num1 + ", num2: " + num2);

            Console.WriteLine("");

            double amt, disc;
            Console.Write("Enter the original cost in dollars: ");
            amt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the percentage discount as a whole number: ");
            disc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your final cost is: $" + Math.Round(Discount(amt, disc),2));

            Console.WriteLine("");

            double bill, tip;
            Console.Write("Enter you bill in dollars: ");
            bill = Convert.ToDouble(Console.ReadLine());
            tip = Math.Round(tipcalc(bill),2);
            Console.WriteLine("You should tip $" + tip);

            Console.ReadKey();
        }

        //Predicate Methods

        static Boolean isVowel(char letter)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Void Method Examples

        static void Heading()
        {
            Console.WriteLine("************************");
            Console.WriteLine("         Porter         ");
            Console.WriteLine("        21/01/21        ");
            Console.WriteLine("************************");
        }

        //Swap Function
        //Pass-by-value

        //static void Swap(int number1, int number2) 
        //{
        //    int temp = number1;
        //    number1 = number2;
        //    number2 = temp;
        //}

        //Pass-by-reference

        static void Swap(ref int number1, ref int number2) 
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }

        //Discount Calculator

        static double Discount(double amount, double percent)
        {
            return (amount - (amount * (percent / 100)));
        }

        //Tip calculator

        static double tipcalc(double amount)
        {
            return amount * 0.15;
        }
    }
}

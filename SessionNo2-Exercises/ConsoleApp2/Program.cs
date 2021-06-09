
using System;

namespace ConsoleApp2
{

    class Program {

        static void Main(string[] args) {

            #region Question #1
            Console.WriteLine("Question 1");
            string name = "Eva";
            Console.WriteLine("Hello " + name);
            Console.WriteLine();
            #endregion

            #region Question #2
            Console.WriteLine("Question 2");
            decimal a = 5m;
            decimal b = 3m;

            decimal sum = a + b;
            decimal dividing = a / b;

            Console.WriteLine($"The sum of {a} and {b} is {sum}");
            Console.WriteLine($"The quotient of {a} and {b} is {dividing}");
            Console.WriteLine();
            #endregion

            #region Question #3
            Console.WriteLine("Question 3");
            Console.WriteLine(-1 + (5 * 6));
            Console.WriteLine(38 + (5 % 7));
            Console.WriteLine(14 + (-3 * 6 / 7));
            Console.WriteLine(2 + (13 / 6) * 6 + Math.Sqrt(7));
            Console.WriteLine((Math.Pow(6, 4) + Math.Pow(5, 7)) / (9 % 4));
            Console.WriteLine();
            #endregion

            #region Question #4
            Console.WriteLine("Question 4");
            Console.WriteLine("Enter 3 numbers and calculate the product");
            decimal multiplication = 1m;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter number {i + 1}");
                decimal num = Convert.ToDecimal(Console.ReadLine());
                multiplication *= num;
            }
            Console.WriteLine($"The product of these number is {multiplication}");
            Console.WriteLine();
            #endregion

            #region Question #5
            Console.WriteLine("Question 5");
            Console.WriteLine("Enter 5 numbers and calculate the average");
            decimal summary = 0m;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter number {i + 1}");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                summary += number;
            }
            decimal average = summary / 5;
            Console.WriteLine($"The average of these numbers is {average}");
            Console.WriteLine();
            #endregion

            #region Question #6
            Console.WriteLine("Question 6");
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your gender");
            string gender = Console.ReadLine();
            Console.WriteLine($"You are {gender} and you look younger then {age}");
            Console.WriteLine();
            #endregion

            #region Question #7
            Console.WriteLine("Question 7");
            Console.WriteLine("Enter seconds and press enter");
            double seconds = Convert.ToDouble(Console.ReadLine());
            double minutes = seconds / 60;
            double hours = seconds / 3600;
            double days = seconds / 86400;
            double years = days / 365;
            Console.WriteLine($"{seconds} seconds are {minutes} minutes");
            Console.WriteLine($"{seconds} seconds are {hours} hours");
            Console.WriteLine($"{seconds} seconds are {days} days");
            Console.WriteLine($"{seconds} seconds are {years} years");
            Console.WriteLine();
            #endregion

            #region Question #8
            Console.WriteLine("Question 8");
            Console.WriteLine("Enter seconds and press enter");
            double secs = Convert.ToDouble(Console.ReadLine());
            TimeSpan t = TimeSpan.FromSeconds(secs);
            double min = t.TotalMinutes;
            double h = t.TotalHours;
            double d = t.TotalDays;
            double y = d / 365;
            Console.WriteLine($"{secs} seconds are {min} minutes");
            Console.WriteLine($"{secs} seconds are {h} hours");
            Console.WriteLine($"{secs} seconds are {d} days");
            Console.WriteLine($"{secs} seconds are {y} years");
            Console.WriteLine();
            #endregion

            #region Question #9
            Console.WriteLine("Question 9");
            Console.WriteLine("Enter celsius degrees");
            decimal celsius = Convert.ToDecimal(Console.ReadLine());
            decimal kelvin = celsius + 273.15m;
            decimal fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius} celsius are {kelvin} kelvin");
            Console.WriteLine($"{celsius} celsius are {fahrenheit} fahrenheit");
            Console.WriteLine();
            #endregion

            #region Question #10
            Console.WriteLine("Question 10");
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                str = str.Replace("a", string.Empty);

            }
            Console.WriteLine(str);
            Console.ReadLine();
            #endregion

        }


    }
}








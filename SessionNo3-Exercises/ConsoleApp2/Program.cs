using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2 {

    class Program {

        static void Main(string[] args) {


            //Question #1
            string sentence = "lorem ipsum dolor sit amet consectetur adipiscing elit";
            string longestWord = Question1(sentence);
            Console.WriteLine("The longest word in the sentence \"lorem ipsum dolor sit amet consectetur adipiscing elit\" is  " + longestWord);
            Console.WriteLine();

            //Question #2
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string reverse = Question2(str);
            Console.WriteLine("The reversed string is " + reverse);
            Console.WriteLine();

            //Question #3
            Console.WriteLine("Enter an integer");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want to compute the sum or the product? Answer sum or product");
            string answer = Console.ReadLine();
            if (answer == "sum")
            {
                int sum = CalculateSum(number);
                Console.WriteLine("The sum is " + sum);
            }
            else if (answer == "product")
            {
                int product = CalculateProduct(number);
                Console.WriteLine("The product is " + product);
            }
            else
            {
                Console.WriteLine("Your answer must either be sum or product");
            }
            Console.WriteLine();

            //Question #4
            Console.WriteLine("Enter an integer");
            int range = Convert.ToInt32(Console.ReadLine());
            Question4(range);
            Console.WriteLine();

            //Question #5
            Console.WriteLine("Question 5");
            int[] array1 = { 2, 4, 9, 12 };
            int[] array2 = { 1, 3, 7, 10 };
            Question5(array1, array2);
            Console.WriteLine();

            //Question #6
            Console.WriteLine("Question 6");
            int[] myNumbers = { 0, -2, 1, 20, -31, 50, -4, 17, 89, 100 };
            Array.Sort(myNumbers);
            foreach (var myNumber in myNumbers)
            {
                Console.Write(myNumber + " ");
            }


            Console.ReadLine();
        }
        static string Question1(string sentence) {
            string[] words = sentence.Split(' ');
            string longestWord = "";
            int maxLength = 0;
            foreach (var word in words)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    longestWord = word;
                }
            }
            return longestWord.ToUpper();
        }

        static string Question2(string str)
        {
            string reverse = "";
            for (int i = str.Length - 1; i > -1; i--)
            {
                reverse += str[i];             
            }        
            return reverse;
        }

        static int CalculateSum(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }        
            return sum;
        }

        static int CalculateProduct(int number)
        {
            int product = 1;
            for (int i = 1; i <= number; i++)
            {
                product *= i;
            }
            return product;
        }

        static void Question4(int range)
        {
            Console.Write($"The prime numbers from 1 to {range} are: ");
            bool isPrime = false;
            for (int i = 2; i <= range; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i%j == 0 && j != 1 && j !=i )
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }                    
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static void Question5(int[] array1, int[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    Console.Write(array1[i] * array2[j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}








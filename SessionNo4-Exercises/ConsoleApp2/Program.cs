using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityLibrary;

namespace ConsoleApp2 {

    class Program {

        static void Main(string[] args) {


            //Question #1
            Console.WriteLine("Enter a number");
            decimal number = Convert.ToDecimal(Console.ReadLine());
            ConvertToBinary(Convert.ToInt32(number));
            Console.ReadLine();

            //Question #2
            Professor professor = new Professor();
            professor.GetName();
            Student student = new Student();
            student.Attend("Math", new DateTime(2021, 06, 04, 10, 30, 0));
        }

        static int ConvertToBinary(int number)
        {
            int bin;
            if (number != 0)
            {              
                bin = (number % 2) + 10 * ConvertToBinary(number / 2);
                Console.Write(bin);
                return 0;
            }
            else
            {
                return 0;
            }
        }

    }
}








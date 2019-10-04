using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int number = 0;
            //int i=0 - start of the loop, i < 10 -stop; i++ - step
            for (int i = 0; i < 10; i++) // alustab 0 st lugemist ja 9ni, kui tahan, et alustaks 1-10, siis i=1 ja i<11
            {
                Console.WriteLine($" i equals {i}");
            }
            Console.WriteLine("\n"); // tühi rida tekib
            for (int j=10; j>-1; j--)
            {
                Console.WriteLine($" j equals {j}");
            }




            Console.ReadLine(); */

            /* int number = 0;
             for (int i = 99; i > 0; i -=1)
             {
                 Console.WriteLine($" {i}  bottles of beer on the wall, {i} bottles of beer. \n Take one down and pass it around, {i -1} bottles of beer on the wall."); // \n saab kasutada ka teksti sees, eraldab

             }

             Console.WriteLine("\n");

             Console.WriteLine("1 bottle of beer on the wall, 1 bottle of beer. \n Take one down and pass it around, no more bottles of beer on the wall. ");

               Console.WriteLine("\n");

             Console.WriteLine("No more bottles of beer on the wall, no more bottles of beer. \n Go to the store and buy some more, 99 bottles of beer on the wall.");
             Console.ReadLine(); */

            int number;
            string vowel;
            int number2;
        
            Console.WriteLine("Enter a number: ");
            number =int.Parse( Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("Your number is positive");
            }
            else if (number <0)

            {
                Console.WriteLine("Your number is negative");
            }
            else
            {
                Console.WriteLine("Your number is zero");
            }

            if (number % 5 ==0)
            {
                Console.WriteLine("Your number is divisible by 5 ");
            }
            else if (number % 11 == 0)
            {
                Console.WriteLine("Your number is divisible by 11");
            }
            else
            {
                Console.WriteLine("Your numbed doesnt divisible by 5 or 11");
            }

            if (number% 2==0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your numbes is odd");
            }

            Console.WriteLine("Enter some vowel: ");
            vowel = Console.ReadLine();
            switch (vowel.ToUpper())
            {
                case "A":
                    Console.WriteLine("It is vowel");
                    break;
                case "E":
                    Console.WriteLine("It is vowel");
                    break;
                case "I":
                    Console.WriteLine("It is vowel");
                    break;
                case "O":
                    Console.WriteLine("It is vowel");
                    break;
                case "U":
                    Console.WriteLine("It is vowel");
                    break;
                case "Y":
                    Console.WriteLine("It is vowel");
                    break;
                default:
                    Console.WriteLine("It is something else");
                    break;

            }

            Console.WriteLine("Please enter number 1-7: ");
            number2 =int.Parse( Console.ReadLine());
            switch (number2)
            {
                case 1:
                    Console.WriteLine("It is a Monday!");
                    break;
                case 2:
                    Console.WriteLine("It is a Tuesday!");
                    break;
                case 3:
                    Console.WriteLine("It is a Wednesday!");
                    break;
                case 4:
                    Console.WriteLine("It is a Thursday!");
                    break;
                case 5:
                    Console.WriteLine("It is a Friday!");
                    break;
                case 6:
                    Console.WriteLine("It is a Saturday!");
                    break;
                case 7:
                    Console.WriteLine("It is a Sudnay!");
                    break;
                default:
                    {
                        Console.WriteLine("Enter number from 1 to 7!");
                        break;
                    }
            }




            Console.ReadLine();

        






        }
    }
}



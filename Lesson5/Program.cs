﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            int tries = 0; //katsed
            int consoleChoice;
            
            
            string name;
            bool gameOver = false; //mängu alguses on false kuna mäng pole alganudki (bool on true or false) kontrollime selle abil kas mäng on over

            Console.WriteLine("Enter your name, please: ");
            name = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {name}.");
            Random rnd = new Random();
            consoleChoice = rnd.Next(1, 6); //genereerib 1-5 numbreid

            while (!gameOver) //!gameover = NOT gameover = true
            {
                int userNumber; // pigem jäta siia sisse mitte deklareerida muutujana üleval, ümber  kirjutamine arvuti jaoks on kulukas
                Console.WriteLine("Try to guess the number:");
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber>consoleChoice)

                {
                    Console.WriteLine("CPU number is smaller");
                }
                else if (userNumber<consoleChoice)
                    {
                    Console.WriteLine("CPU number is bigger");

                }
                else
                {
                    Console.WriteLine("Got me!");
                    gameOver = true;
                }

                Console.ReadLine();

            }




            

        }
    }
}

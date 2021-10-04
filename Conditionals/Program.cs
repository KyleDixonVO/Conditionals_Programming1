﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static int score = 0;
        static int lives = 3;
        static bool oneUpGained = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals!");
            ShowHUD();
            
           
            //if, then, else, etc.
            score = score + 100;
            ShowHUD();
            score = score + 100;
            ShowHUD();
            score = score + 1000000;

            if (oneUpGained == false)
            {
                if (score >= 1000000)
                {
                    lives = lives + 1;
                    oneUpGained = true;
                }
            }

          
            ShowHUD();

        
            Console.ReadKey(true);
        }

        static void ShowHUD()
        {
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Lives: " + lives);

        }
    }
}

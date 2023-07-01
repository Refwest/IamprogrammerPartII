// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesI;

class Program
{
    static void Main(string[] args)
    {
        //If Statements, Else Statements

        Console.WriteLine("How old are you ?");
        int age = int.Parse(Console.ReadLine());
        if (age >= 18)
        {
            if (age <= 25)
            {
                Console.WriteLine("You are of age!");
                Console.WriteLine("You can make driver licence and still have student discount");
            }
            else
            {
                if (age <= 67)
                {
                    if (age >= 18)
                    { Console.WriteLine("Now you can be happy of your dream job!"); }

                }
                else
                { Console.WriteLine("Have a good time, you do not have to worry about anything"); }
            }
        }

        //Compound expression in If statement

        Console.WriteLine("How old are you?");
        int age2 = int.Parse(Console.ReadLine());

        if (age2 >= 18 && age2 <= 25)
        {
            Console.WriteLine("You are of age!");
            Console.WriteLine("You can make driver licence and still have student discount");
        }
        else
        if (age2 <= 67 && age2 > 25)
        {
            Console.WriteLine("Now you can be happy of your dream job!");
        }

        else
            if (age2 > 67 || age2 > 5)
        {
            Console.WriteLine("Have a good time, you do not have to worry about anything");
        }
        else
        {
            Console.WriteLine("Doesn't matter what I have written, you can't read yet");
        }
    }
}

      
       
               
                    
 
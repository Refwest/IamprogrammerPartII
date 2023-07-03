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
        //  !!If Statements, Else Statements!!

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

        ////    !!Compound expression in If statement!!

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


        ////    !!Switch statement!!

        Console.WriteLine("What is your average grades rounded to integer?");
        int averageGrade = int.Parse(Console.ReadLine());

        Console.WriteLine("Do you have sport achievements? [yes or no]");
        bool sportAchiv = (Console.ReadLine() == "yes");
        switch (averageGrade)
        {
            case 1:
                {
                    Console.WriteLine("Sorry, see you next year");
                    break;
                }
            case 2:
            case 3:
                {
                    Console.WriteLine("You have to study more");
                    break;
                }
        }
        if (averageGrade == 4 && sportAchiv == true)
        {
            Console.WriteLine("Great job! You earned scholarship");
        }
        else switch (averageGrade)
            {
                case 4:
                    {
                        Console.WriteLine("Good job!");
                        break;
                    }
                case 5:
                case 6:
                    {
                        Console.WriteLine("Great job! You earned scholarship");
                        break;
                    }
                case > 6:
                    {
                        Console.WriteLine("It's imposible, you have to redo math");
                        break;
                    }

                    //  !!default:
                    //    {
                    //        Console.WriteLine("It's imposible, you have to redo math");
                    //        break;
                    //    }   - If non case is fullfill than do"Console.WriteLine("It's imposible, you have to redo math");"
                    //   !! if(!(true))      !(true) = false !!



                    //  !!Conditional and not operators!!

                    Console.WriteLine("What is first number?");
        double number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("What is first number?");
        double number2 = double.Parse(Console.ReadLine());

        Console.WriteLine((number1 > number2) ? "First number is greater than second one" : "Second number is greater than first one");





    }
}
}

      
       
               
                    
 
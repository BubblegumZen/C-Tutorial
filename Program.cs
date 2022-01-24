using System;


namespace FirstProgram {
    class Program {
        
        static void Main(string[] args) {
        // ------------------------------------------------------------

            /*
               My First C# Program! 
            */

            // Console.WriteLine("Hello world");

        // ------------------------------------------------------------

            /* 
                This code works with variables
                It's from a tutorial
            */

            // string characterName = "Joseph";
            // int characterAge = 40;
            // Console.WriteLine(characterName + " is " + characterAge);
            // Console.ReadLine();

        // -------------------------------------------------------------

            /*
                Working with string in C# 
                Some Examples
            */

            // string phrase = "This is a " + "cool phrase";
            //                //0123456789 
            // string upperCase = phrase.ToUpper();
            // string lowerCase = phrase.ToLower();
            // int stringLength = phrase.Length;
            // Console.WriteLine("Upper Method on " + "'" +  phrase + "'" + " = " + upperCase);
            // Console.WriteLine("Lower Method on " + "'" +  phrase + "'" + " = " + lowerCase);
            // Console.WriteLine("Length of string is: " + stringLength);
            // Console.WriteLine("Does " + "'" + phrase + "'" + " contain \"cool\": " + phrase.Contains("cool"));
            // Console.WriteLine("Does " + "'" + phrase + "'" + " contain \"boxing\": " + phrase.Contains("boxing"));
            // Console.WriteLine("First letter of " + "'" + phrase + "'" + " is: " + phrase[0]);

        // -------------------------------------------------------------

            /*
                Working with numbers in C#
                Some Examples
            */

            // int num = -30;
            // num++; // increment of 1 to num, so num = -29
            // num--; // decrement of 1 to num, so num = -30 again
            // Console.WriteLine(num);
            // Console.WriteLine("Absolute value of " + num + " is " + Math.Abs(num));
            // Console.WriteLine("Square of " + num + " is " + Math.Pow(num, 2));
            // Console.WriteLine("Square root of " + num + " is " + Math.Round(Math.Sqrt(Math.Abs(num)), 2));
            // Console.WriteLine("Out of " + num + " and 60, The greater one is: " + Math.Max(num, 60));
            // Console.WriteLine("Out of " + num + " and 60, The smaller one is: " + Math.Min(num, 60));
        // -------------------------------------------------------------

            /*
                User Inputs In C#
                One Example
            */

            // Console.Write("Heya! Enter your name (I won't misuse it, promise!): ");
            // string name = Console.ReadLine();
            // Console.WriteLine("Nice to meet you " + name);
        // -------------------------------------------------------------

            /*
                Working with Arrays in C#
                Some Examples
            */

            // int[] coolArray = {1,2,3,4,5,6,7,8,9,0};
            // string[] newArray = new string[5];
            // newArray[1] = "nice";

            // Console.WriteLine("First element of array = " + coolArray[0]);
            // Console.WriteLine("Length of array = " + coolArray.Length);
            // Console.WriteLine("Last element of array = " + coolArray[coolArray.Length - 1]);
            // coolArray[0] = 1000;
            // Console.WriteLine("New value of first element = " + coolArray[0]);

            // Console.WriteLine("Second element of newArray is " + newArray[1]);

        // -------------------------------------------------------------

            /*
                Working with Functions/Method in C# with no return Value (void)
                One example
            */

            // SayHello("Mikey");
            // SayHello("George");
            // SayHello("Savannah");

        // -------------------------------------------------------------

            /*
                Working with Functions/Method in C# with a return Value (int/string/array/etc)
                One example
            */

            // int Cubed = Cube(300);
            // Console.WriteLine("Cube of 300 is " + Cubed);
            
        }

        // part of `Working with Functions/Method with no return Value (void)`
        // static void SayHello(string name) {
        //     Console.WriteLine("Hello " + name);
        // }

        // part of `Working with Functions/Method with a return value (int/string/array/etc)`
        // static int Cube(int number) {
        //     int numberCube = number * number * number;
        //     return numberCube;
        // }
    }
}
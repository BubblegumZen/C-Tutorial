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
            
        // -------------------------------------------------------------

            /*
                if | else if | else | OR (||) | AND (||) statements in C#
            */

            // bool isLazy = true;
            // bool isTall = false;
            // if (isLazy && isTall) {
            //     Console.WriteLine("You are lazy and tall!");
            // } 
            // else if (isLazy && !isTall) {
            //     Console.WriteLine("You are lazy but not tall!");
            // }
            // else if (!isLazy && isTall) {
            //     Console.WriteLine("You are not lazy but tall!");
            // }
            // if (isLazy || isTall) {
            //     Console.WriteLine("You are either tall or lazy!");
            // }

        // -------------------------------------------------------------

            /*
                Calculator Program in C#
            */

            // CalculatorStart();

        // -------------------------------------------------------------

            /*
                Switch Statements in C#
            */

            // int value = 4;
            // Console.WriteLine(getDay(value));

        // -------------------------------------------------------------

            /*
                Guessing Game in C# with a do while loop!
            */


           // GuessGameStart();

        // -------------------------------------------------------------


             /*
                 Exponent function in C#
            */

            // int a = 3;
            // int b = 20000;
            // Console.WriteLine(Power(a,b));

         // -------------------------------------------------------------
            /*
                PART OF Try catch in C# (Equivalent of try except in python)
            */
            // double number1 = GetNumber("First");
            // double number2 = GetNumber("Second");
            // Console.WriteLine("Sum is " + (number1 + number2));

         // -------------------------------------------------------------
            
        }


    // PART OF Try catch in C# (Equivalent of try except in python)
    // static double GetNumber(string indexNumber) {
    //     double number;
    //     while (true) {
    //         Console.Write("Enter your " + indexNumber + " Number: ");
    //         try {
    //             number = Convert.ToDouble(Console.ReadLine());
    //             break;
    //         }
    //         catch (FormatException) {
    //             Console.WriteLine("You have to enter a proper number");
    //             continue;
    //         }
    //     }
    //     return number;
    // }

        
    // PART OF Exponent function in C#
    // static double Power(double number1, double number2) {
    //     double result;
    //     result = number1;
    //     for (int index = 1; index < number2; index++) {
    //         result = result * number1;
    //     }
    //     return result;
    // }

    // static void GuessGameStart() {
    //     string secretWord = "cool gang";
    //     string guess = "";
    //     int chances = 0;
    //     do {
    //         Console.Write("Enter your guess: ");
    //         chances++;
    //         if (chances > 3) {
    //             Console.WriteLine("You ran out of attempts!");
    //             break;
    //         }
    //         guess = Console.ReadLine();
    //     } while (guess != secretWord);
    //     if (chances > 3) {
    //         Console.WriteLine("You lost the game!!");
    //     }
    //     else {
    //         Console.WriteLine("You guessed it correctly!");
    //     }
    
    // }

    // PART OF Calculator Program in C#
    //  static void CalculatorStart() {
    //         double result;
    //         char symbol;
    //         Console.WriteLine("Hello there! Welcome to this small Calculator program!\nPlease type in the number you want to perform beside their respective operation!");
    //         Console.WriteLine("[1] Addition (default)\n[2] Subtraction\n[3] Multiplication\n[4] Division (Return Remainder)\n[5] Division (return Quotient)");
    //         Console.Write("Enter your choice: ");
    //         int choice = Convert.ToInt32(Console.ReadLine());
    //         Console.Write("Enter the first number: ");
    //         double number1 = Convert.ToInt32(Console.ReadLine());
    //         Console.Write("Enter the second number: ");
    //         double number2 = Convert.ToInt32(Console.ReadLine());
    //         if (choice == 1) {
    //             result = CalculateNumbers(number1, number2, "add");
    //             symbol = '+';
    //         }
    //         else if (choice == 2) {
    //             result =CalculateNumbers(number1, number2, "subtract");
    //             symbol = '-';
    //         }
    //         else if (choice == 3) { 
    //             result = CalculateNumbers(number1, number2, "multiply");
    //             symbol = 'x';
    //         }
    //         else if (choice == 4) {
    //             result = CalculateNumbers(number1, number2, "mod");
    //             symbol = '%';
    //         }
    //         else if (choice == 5) {
    //             result = CalculateNumbers(number1, number2, "divide");
    //             symbol = '/';
    //         }
    //         else {
    //             result = CalculateNumbers(number1, number2, "add");
    //             symbol = '+';
    //         }
    //         Console.WriteLine(number1 + " " + symbol + " " + number2 + " = " + result);
    //     }

    //     static double CalculateNumbers(double number1, double number2, string choice) {
    //         double result;
    //         if (choice == "add") {
    //             result = number1 + number2;
    //         }
    //         else if (choice == "subtract") {
    //             result = number1 - number2;
    //         }
    //         else if (choice == "multiply") {
    //             result = number1 * number2;
    //         }
    //         else if (choice == "mod") {
    //             result = number1 % number2;
    //         }
    //         else if (choice == "divide") {
    //             result = number1 / number2;
    //         }
    //         else {
    //             result = number1 + number2;
    //         }
    //         return result;
    //     }


    // part of `Working with Functions/Method with no return Value (void)`
    // static void SayHello(string name) {
    //     Console.WriteLine("Hello " + name);
    // }

    // part of `Working with Functions/Method with a return value (int/string/array/etc)`
    // static int Cube(int number) {
    //     int numberCube = number * number * number;
    //     return numberCube;
    // }

    // PART OF switch statements in C#
    // static string getDay(int dayNumber) {
    //     string dayName;
    //     switch (dayNumber) {
    //         case 0:
    //             dayName = "Sunday";
    //             break;
    //         case 1:
    //             dayName = "Monday";
    //             break;
    //         case 2:
    //             dayName = "Tuesday";
    //             break;
    //         case 3:
    //             dayName = "Wednesday";
    //             break;
    //         case 4:
    //             dayName = "Thursday";
    //             break;
    //         case 5:
    //             dayName = "Friday";
    //             break;
    //         case 6:
    //             dayName = "Saturday";
    //             break;
    //         default:
    //             dayName = "Invalid Day Number";
    //             break;
    //     }
    //     return dayName;
    // }
    }

}
using System;


namespace FirstProgram {
    class Calculator {
        public void CalculatorStart() {
            double result, number1, number2;
            char symbol;
            int choice;
            Console.WriteLine("Hello there! Welcome to this small Calculator program!\nPlease type in the number you want to perform beside their respective operation!");
            Console.WriteLine("[1] Addition (default)\n[2] Subtraction\n[3] Multiplication\n[4] Division (Return Remainder)\n[5] Division (return Quotient)");
            choice = GetChoice();
            number1 = GetNumber("First");
            number2 = GetNumber("Second");
            if (choice == 1) {
                result = CalculateNumbers(number1, number2, "add");
                symbol = '+';
            }
            else if (choice == 2) {
                result =CalculateNumbers(number1, number2, "subtract");
                symbol = '-';
            }
            else if (choice == 3) { 
                result = CalculateNumbers(number1, number2, "multiply");
                symbol = 'x';
            }
            else if (choice == 4) {
                result = CalculateNumbers(number1, number2, "mod");
                symbol = '%';
            }
            else if (choice == 5) {
                result = CalculateNumbers(number1, number2, "divide");
                symbol = '/';
            }
            else {
                result = CalculateNumbers(number1, number2, "add");
                symbol = '+';
            }
            Console.WriteLine(number1 + " " + symbol + " " + number2 + " = " + result);
        }
        static double CalculateNumbers(double number1, double number2, string choice) {
            double result;
            if (choice == "add") {
                result = number1 + number2;
            }
            else if (choice == "subtract") {
                result = number1 - number2;
            }
            else if (choice == "multiply") {
                result = number1 * number2;
            }
            else if (choice == "mod") {
                result = number1 % number2;
            }
            else if (choice == "divide") {
                result = number1 / number2;
            }
            else {
                result = number1 + number2;
            }
            return result;
        }

        // PART OF Try catch in C# (Equivalent of try except in python)
        static double GetNumber(string indexNumber) {
            double number;
            while (true) {
                Console.Write("Enter your " + indexNumber + " Number: ");
                try {
                    number = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException) {
                    Console.WriteLine("You have to enter a proper number");
                    continue;
                }
            }
            return number;
        }
        static int GetChoice() {
            int number;
            while (true) {
                Console.Write("Enter your choice: ");
                try {
                    number = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (FormatException) {
                    number = 0;
                    break;
                }
            }
            return number;

        }
    }
}
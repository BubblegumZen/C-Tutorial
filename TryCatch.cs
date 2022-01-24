using System;


namespace FirstProgram {
    class TryCatch {

        public void Start() {
            double number1 = GetNumber("First");
            double number2 = GetNumber("Second");
            Console.WriteLine("Sum is " + (number1 + number2));
        }
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
    } 
}
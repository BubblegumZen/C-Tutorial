namespace FirstProgram {
    class Exponent {
    // PART OF Exponent function in C#

        public void Start(double a, double b) {
            Console.WriteLine(Power(a,b));
        }
        static double Power(double number1, double number2) {
            double result;
            result = number1;
            for (int index = 1; index < number2; index++) {
                result = result * number1;
            }
            return result;
        }
    }
}
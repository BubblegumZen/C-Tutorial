using System;

namespace FirstProgram {
    class GuessGame {
        static void GuessGameStart() {
            string secretWord = "cool gang";
            string guess = "";
            int chances = 0;
            do {
                Console.Write("Enter your guess: ");
                chances++;
                if (chances > 3) {
                    Console.WriteLine("You ran out of attempts!");
                    break;
                }
                guess = Console.ReadLine();
            } while (guess != secretWord);
            if (chances > 3) {
                Console.WriteLine("You lost the game!!");
            }
            else {
                Console.WriteLine("You guessed it correctly!");
            }
        }
    }
}
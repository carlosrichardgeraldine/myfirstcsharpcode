namespace MyNinthCode {
    class Program {
        public static void RunFizzBuzz() {
            for (int x = 1; x < 101; x++) {         Console.Write(x);
                if (x % 3 == 0 && x % 5 != 0)       Console.WriteLine(" - Fizz");
                else if (x % 3 != 0 && x % 5 == 0)  Console.WriteLine(" - Buzz");
                else if (x % 3 == 0 && x % 5 == 0)  Console.WriteLine(" - FizzBuzz");
                else                                Console.WriteLine();
            }
        }
    }
}
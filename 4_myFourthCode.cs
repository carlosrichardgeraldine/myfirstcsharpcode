namespace MyFourthCode {
    class Program {
        public static void RunRandomNumbers() {
            for (int x = 0; x < 5; x++) {
                int[] diceRolls = new int[3];

                for (int y = 0; y < diceRolls.Length; y++) {
                    Random random = new Random();
                    int roll = random.Next(1, 7);
                    diceRolls[y] = roll;
                }
                
                int totalDiceRolls = diceRolls[0] + diceRolls[1] + diceRolls[2];
                Console.WriteLine($"Dice roll: " + diceRolls[0] + " + " + diceRolls[1] + " + " + diceRolls[2] + " = " + (totalDiceRolls));

                if (diceRolls[0] == diceRolls[1] && diceRolls[1] == diceRolls[2]) {
                    Console.WriteLine("You rolled triples! +6 bonus to total!");
                    totalDiceRolls += 6;
                } else if (diceRolls[0] == diceRolls[1] || diceRolls[1] == diceRolls[2] || diceRolls[0] == diceRolls[2]) {
                    Console.WriteLine("You rolled doubles! +2 bonus to total!");
                    totalDiceRolls += 2;
                } else {
                    Console.WriteLine("No bonus.");
                }
                
                Console.WriteLine("Final total: " + totalDiceRolls);

                if (totalDiceRolls >= 16) {
                    Console.WriteLine("You win a new car!\n");
                } else if (totalDiceRolls >= 10) {
                    Console.WriteLine("You win a new laptop!\n");
                } else if (totalDiceRolls == 7) {
                    Console.WriteLine("You win a trip for two!\n");
                } else {
                    Console.WriteLine("You win a kitten!\n");
                }
            }
        }
    }
}
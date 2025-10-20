using System.Security.Cryptography;

namespace MySecondCode {
    class Program {
        public static void RunRandomBytes() {
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] randomBytes = new byte[16];

            for (int x = 0; x < randomBytes.Length; x++) {
                rng.GetBytes(randomBytes);
                Console.WriteLine(randomBytes[x]);
            }
        }
    }
}
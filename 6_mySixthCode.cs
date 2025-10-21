namespace MySixthCode {
    class Program {
        public static void RunFraudDetector() {
            string[] orderIDList = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

            foreach (string orderID in orderIDList) {
                if (orderID.StartsWith("B")) {
                    Console.WriteLine($"{orderID} - The Order ID starts with 'B'!");
                } else {
                    Console.WriteLine(orderID);
                }
            }
        }
    }
}
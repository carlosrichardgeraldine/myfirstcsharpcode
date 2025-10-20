namespace MyFirstCode {
    class Program {
        public static void RunSophiaReportCard() {
            string studentName = "Sophia Johnson";
            string[] sophiaCourse = { "English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101" };
            int[] sophiaCredit = { 3, 3, 4, 4, 3 };
            int[] sophiaGrade = { 4, 3, 3, 3, 4 };
            int totalCredits = 0;
            int weightedSum = 0;

            for (int x = 0; x < sophiaCourse.Length; x++) {
                weightedSum += sophiaGrade[x] * sophiaCredit[x];
                totalCredits += sophiaCredit[x];
            }
            decimal finalGPA = Math.Round((decimal) weightedSum / totalCredits, 2);
            int[] sophiaGradePoints = new int[sophiaGrade.Length];
            for (int x = 0; x < sophiaGrade.Length; x++) {
                sophiaGradePoints[x] = sophiaGrade[x] * sophiaCredit [x];
            }
            string[] sophiaLetterGrade = new string[sophiaGrade.Length];
            for (int x = 0; x < sophiaGrade.Length; x++) {
                if (sophiaGrade[x] == 4) sophiaLetterGrade[x] = "A";
                else if (sophiaGrade[x] == 3) sophiaLetterGrade[x] = "B";
                else sophiaLetterGrade[x] = "null";
            }

            Console.WriteLine($"Student: {studentName}\n");
            Console.WriteLine("{0,-22}{1,-10}{2,-17}{3,-17}{4,-17}", "Course", "Grade", "Credit Hours", "Grade Points", "Letter Grade");
            for (int x = 0; x < sophiaCourse.Length; x++) {
                Console.WriteLine("{0,-22}{1,-10}{2,-17}{3,-17}{4,-17}", sophiaCourse[x], sophiaGrade[x], sophiaCredit[x], sophiaGradePoints[x], sophiaLetterGrade[x]);
            }
            Console.WriteLine("\n" + "{0,-22}{1,-10}", "Final GPA:", finalGPA);
        }
    }
}
using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string teacherOne = "Ms. Lapan";
            string teacherTwo = "Mrs. Gideon";
            string teacherThree = "Mr. Davis";
            string teacherFour = "Ms. Palmer";
            string teacherFive = "Ms. Garcia";
            string teacherSix = "Mrs. Barnett";
            string teacherSeven = "Ms.Johannessen";
            string teacherEigth = "Mr. James";

            string subjectOne = "English III ";
            string subjectTwo = "Precalculus ";
            string subjectThree = "Music Theory ";
            string subjectFour = "Biotechnology ";
            string subjectFive = "Principles of Technology I ";
            string subjectSix = "Latin II ";
            string subjectSeven = "AP US History ";
            string subjectEigth = "Business Computer Infomation Systems ";

            int multiplierOne = 37 - subjectOne.Length;
            int multiplierTwo = 37 - subjectTwo.Length;
            int multiplierThree = 37 - subjectThree.Length;
            int multiplierFour = 37 - subjectFour.Length;
            int multiplierFive= 37 - subjectFive.Length;
            int multiplierSix = 37 - subjectSix.Length;
            int multiplierSeven = 37 - subjectSeven.Length;
            int multiplierEigth = 37 - subjectEigth.Length;

            string spaceOne = new string(' ', multiplierOne);
            string spaceTwo = new string(' ', multiplierTwo);
            string spaceThree = new string(' ', multiplierThree);
            string spaceFour = new string(' ', multiplierFour);
            string spaceFive = new string(' ', multiplierFive);
            string spaceSix = new string(' ', multiplierSix);
            string spaceSeven = new string(' ', multiplierSeven);
            string spaceEigth = new string(' ', multiplierEigth);

            string spaceOne1 = new string(' ', 15 - teacherOne.Length);
            string spaceTwo2 = new string(' ', 15 - teacherTwo.Length);
            string spaceThree3 = new string(' ', 15 - teacherThree.Length);
            string spaceFour4 = new string(' ', 15 - teacherFour.Length);
            string spaceFive5 = new string(' ', 15 - teacherFive.Length);
            string spaceSix6 = new string(' ', 15 - teacherSix.Length);
            string spaceSeven7 = new string(' ', 15 - teacherSeven.Length);
            string spaceEigth8 = new string(' ', 15 - teacherEigth.Length);



            Console.WriteLine("+------------------------------------------------------------+");
            Console.WriteLine($"| 1 |{spaceOne}{subjectOne}|{spaceOne1}{teacherOne}   |");
            Console.WriteLine($"| 2 |{spaceTwo}{subjectTwo}|{spaceTwo2}{teacherTwo}   |");
            Console.WriteLine($"| 3 |{spaceThree}{subjectThree}|{spaceThree3}{teacherThree}   |");
            Console.WriteLine($"| 4 |{spaceFour}{subjectFour}|{spaceFour4}{teacherFour}   |");
            Console.WriteLine($"| 5 |{spaceFive}{subjectFive}|{spaceFive5}{teacherFive}   |");
            Console.WriteLine($"| 6 |{spaceSix}{subjectSix}|{spaceSix6}{teacherSix}   |");
            Console.WriteLine($"| 7 |{spaceSeven}{subjectSeven}|{spaceSeven7}{teacherSeven}   |");
            Console.WriteLine($"| 8 |{spaceEigth}{subjectEigth}|{spaceEigth8}{teacherEigth}   |");
            Console.WriteLine("+------------------------------------------------------------+");
            
        }
    }
}

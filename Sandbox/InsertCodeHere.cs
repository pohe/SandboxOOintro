using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Student s1 = new Student("Victor"); // creates an object of a Student class
            //s1.Name = "Victor"

            Student s2 = new Student();
            Console.WriteLine($"S2s navn {s2.Name}");
            s2.Name = "Charlotte";
            Console.WriteLine($"S2s navn {s2.Name}");

            Console.WriteLine($"S1s name {s1.Name}");

            Student s3 = new Student("Magnus");
            s3.Grade1 = -500;
            s3.Grade2 = 700;
            double gennemsnit= s3.CalculateAverage();
            Console.WriteLine($"Gennemsnit for s3 {gennemsnit}");
            s1.Cpr = 0310395453; 
            s2.Cpr = 0302944444;

            //Grade 2
            s1.Grade2 = 12;
            s2.Grade2 = 7;
            s1.Mobile = "0045-66666"; 
            Console.WriteLine($"S1s cpr {s1.Cpr} og mobile nummer {s1.Mobile}");
            Console.WriteLine($"S2s name {s2.Cpr}");

            Student s4 = new Student("Poul", "111",6666);
           


            // The LAST line of code should be ABOVE this line
        }
    }
}
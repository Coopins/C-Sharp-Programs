class Program
{
    static void Main(string[] args)
    {
        //SpeechSynthesizer synth = new SpeechSynthesizer();
        //synth.Speak("Welcome, to the Grade Book Program.");

        //SpeechSynthesizer justMoreToSay = new SpeechSynthesizer();
        //justMoreToSay.Speak("Okay, Now that we got that out of the way. May you input the Grades please.");


        /*Gradebook book = new Gradebook();
        book.AddGrade(91);
        book.AddGrade(89);
        book.AddGrade(83.5f);
        book.AddGrade(78);
        book.AddGrade(98);
        book.AddGrade(93);
        book.AddGrade(79);
        book.AddGrade(64);
        book.AddGrade(32);
        book.AddGrade(45);
        book.AddGrade(67);
        book.AddGrade(90);
        book.AddGrade(58);
        book.AddGrade(72);
        book.AddGrade(100);
        book.AddGrade(85);*/

        Console.WriteLine("Please go ahead and Listen to the Voice and input the Grades:");

        Gradebook inputValues = new Gradebook();
        inputValues.AddGrade(85);
        inputValues.AddGrade(62);


        GradeStatistics stats = inputValues.ComputeStatistics();
        //Console.WriteLine(stats.HighestGrade);
        //Console.WriteLine(stats.AverageGrade);
        //Console.WriteLine(stats.LowestGrade);
        Console.WriteLine("The average for this person is {0} and the Highest grade he made is {1} and the Lowest is {2}. If you May please select any character to exit the program!", stats.AverageGrade, stats.HighestGrade, stats.LowestGrade);

    }
}

public class Gradebook
{

    public Gradebook()
    {
        grades = new List<float>();
    }

    public GradeStatistics ComputeStatistics()
    {
        GradeStatistics stats = new GradeStatistics();

        float sum = 0;
        foreach (float grade in grades)
        {
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                sum = sum + grade;
            }
        }
        stats.AverageGrade = sum / grades.Count;
        return stats;
    }

    public void AddGrade(float grade)
    {
        grades.Add(grade);
    }

    public List<float> grades;
}
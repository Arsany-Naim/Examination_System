using System.Diagnostics;

namespace Exam_02_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject1 = new Subject(10, "C#");
            subject1.CreateExam();
            Console.Clear();
            Console.WriteLine("Do You Want To Start The Exam (Y | N): ");

            if(char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                subject1.Exam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {stopwatch.Elapsed}");
            }

        }
    }
}

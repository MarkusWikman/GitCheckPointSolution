namespace GitCheckPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckTest checkTest = new CheckTest();
            Calculate calculate = new Calculate();

            Console.WriteLine("This is the Git checkpoint task 1.1");
            checkTest.testMessage("Task 2 checked");
            Console.WriteLine(calculate.Add(5, 2));
        }
    }
}
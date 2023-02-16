namespace GitCheckPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Git checkpoint task 1.1");
            CheckTest checkTest = new CheckTest();
            checkTest.testMessage("Task 2 checked");
        }
    }
}
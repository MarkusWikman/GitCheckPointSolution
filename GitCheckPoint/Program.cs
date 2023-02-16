namespace GitCheckPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the Git checkpoint task 1.1");
            CheckTest.testMessage("Task 2 checked");
            Console.WriteLine(Calculate.Add(5, 2));
        }
    }
}
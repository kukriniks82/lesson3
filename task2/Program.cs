namespace task2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("input number");
        int WrongAttemptsCoutn = 0;
        while (WrongAttemptsCoutn<5)
        {
          
            var input = Console.ReadLine();
            bool isCorrect = Int32.TryParse(input, out int digit);

            if (isCorrect)
            {
                if (digit % 2 == 0)
                {
                    Console.WriteLine($"number {digit} is even");
                }
                else
                    Console.WriteLine($"number {digit} is odd");

            }
            else
            {
                Console.WriteLine("wrong number!");
                WrongAttemptsCoutn++;
            }
            if (WrongAttemptsCoutn>=5)
            {
                Console.WriteLine("You are tied \n good BY!");
                Thread.Sleep(5000);
            }
        }
    }
}


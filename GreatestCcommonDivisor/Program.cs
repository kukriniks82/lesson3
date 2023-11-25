//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GreatestCommonDivisor;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's try to finde biggest division)");
        Console.WriteLine("enter numbers\n For exit enter 'Q'");
        string input = "";
        List<int> numbers = new List<int>();
        int gratestDivision = 0;

        while (input != "Q")
        {        
            input = Console.ReadLine();
            if (input != "Q")
            {
                int tempDigit = CheckInput(input);
                if (tempDigit !=0)
                {
                    numbers.Add(tempDigit);
                }          

            }
        }

        for (int i = 0; i < numbers.Count -1; i++)
        {            
            gratestDivision = GratestDivision(numbers[i], numbers[i + 1]);
            System.Console.WriteLine(gratestDivision);
        }
        

       // Console.ReadLine();

        int GratestDivision (int firstNumber, int secondNumber)
        {            
                while (secondNumber!=0)
                {
                  var temp = secondNumber;
                  secondNumber = firstNumber % secondNumber;
                  firstNumber = temp;
                }    
            
            return firstNumber;
        }

        int CheckInput(string input)
        {
            
            bool isCorrectInput = Int32.TryParse(input, out int output);
            if (isCorrectInput & output != 0)
            {
                return output;
            }
            Console.WriteLine("Wron value");
            return 0;
        }

    }
}


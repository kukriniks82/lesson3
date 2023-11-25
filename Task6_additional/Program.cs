//using static System.Runtime.InteropServices.JavaScript.JSType;



namespace GreatestCommonDivisor;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's try to find biggest division)");
        Console.WriteLine("enter numbers\n For stop adding'Q'");
        string input = "";
        List<int> numbers = new List<int>(); //store entered number there
        int greatestDivision = 0;

        while (input != "Q") // Q for exit 
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
            if (numbers.Count == 1) //add same value 
            {
                System.Console.WriteLine("You add only one number");
                numbers.Add(numbers[0]);    
            }
            if (numbers.Count < 1)
            {
                System.Console.WriteLine("Nothing to proceed");
                Environment.Exit(0);
            }
        numbers.Sort();
        numbers.Reverse();

        greatestDivision = GreatestDivision(numbers[0], numbers[numbers.Count-1]); /*take  Max and Min value find potentially needed division
        then will check other value with received division */        
        System.Console.WriteLine("Max number " + numbers[0] + "\t" + "Min number " + numbers[numbers.Count-1]); 
        
        int count = 1;
        while(greatestDivision!=1 && count < numbers.Count-1)
        {
            var tempDivision = GreatestDivision(numbers[count],greatestDivision);
            if (greatestDivision > tempDivision)
            {
                greatestDivision = tempDivision;
            }
            count++;
            System.Console.WriteLine(   nameof(greatestDivision) + " = " + greatestDivision);
        }


        System.Console.WriteLine(   "You added those numbers");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + "\t");                
            }
            Console.WriteLine();
        System.Console.WriteLine("GreatestDivision = " + greatestDivision);
        

       // Console.ReadLine();

        int GreatestDivision (int firstNumber, int secondNumber)
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
            Console.WriteLine("Wrong value");
            return 0;
        }

    }
}


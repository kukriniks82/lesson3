
while(true)
{
    Console.WriteLine("enter digit (100-999) or 'Q' for exit");
    string input = Console.ReadLine();
    if (input=="Q")
    {
         Environment.Exit(0);
    }
    int digit = CheckInput(input) ;
    if (digit>99 & digit<1000)
    {
        System.Console.WriteLine("Your number consist of:"); 
            System.Console.WriteLine(input[input.Length-1] + " units");
            System.Console.WriteLine(input[input.Length-2] + " tens");
            int sum=0;
            int mult=1;
        for (int i = 0; i < input.Length; i++)
        {
            sum += CheckInput(input[i].ToString());
            mult *= CheckInput(input[i].ToString());
        }
        System.Console.WriteLine("Sum of digit = "+sum);
        System.Console.WriteLine("multiplication = "+mult);
    }
    else
    {
        Console.WriteLine("Wrong value");
    }
}
        int CheckInput(string input)
        {            
            bool isCorrectInput = Int32.TryParse(input, out int output);
            if (isCorrectInput)
            {
                return Math.Abs(output);
            }
            Console.WriteLine("Wrong value");
            return 0;
        }


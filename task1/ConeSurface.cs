namespace lesson3;

class Program
{
    static void Main(string[] args)
    {
        int radius=0, slant = 0;     
        
        
        Console.WriteLine("Calculating the surface area of cone \n input radius \n");
        Console.WriteLine("Input radius");
        while (radius==0)
        {            
             Console.Write("r=");
            radius = CheckInput();
        }

        Console.WriteLine("Input slant");
        while (slant == 0)
        {
            Console.Write("l=");
            slant = CheckInput();
        }

        Console.WriteLine("Cone suface = " + Math.PI*radius*(radius+slant));
        Console.ReadKey();

        int CheckInput()
        {
            int output;
            bool isCorrectInput = Int32.TryParse(Console.ReadLine(), out output);
                if (isCorrectInput & output != 0)
                {
                    return output;
                }
                Console.WriteLine("Wron value");
                return 0;
                

        }

    }
}


namespace task3;

class Program
{
    static void Main(string[] args)
    {
        int x = 14, y = 1, z = 5;
        Console.WriteLine(x += y-x++ * z);//1. x++ /2. *z /3.y- /4.x= x+()
        Console.WriteLine(z = --x -y*5); //1. --x /2. y*5 /3. x-y 4./z= ()
        Console.WriteLine(y /= x + 5%z);//1. 5%z /2. x+ /3. y=y/()
        Console.WriteLine(z = x++ +y*5);//1. x++ /2. y+5 /3. x+ /4. z=()
        Console.WriteLine(x = y - x++ *z);//1. x++ /2. x*z /3. y-x /4. x=()


    }
}


namespace task4;

class Program
{
    static void Main(string[] args)
    {
        //int? , string, object - default value null

        Console.WriteLine("byte \t" + default(byte));
        Console.WriteLine("sbyte \t" + default(sbyte));
        Console.WriteLine("shot \t" + default(short));
        Console.WriteLine("ushot \t" +default(ushort));
        Console.WriteLine("int \t" + default(int));
        Console.WriteLine("int? \t" + default(int?) == null ? "null" : "empty");
        Console.WriteLine("long \t" + default(long));
        Console.WriteLine("ulong \t" + default(ulong));
        Console.WriteLine("float \t" + default(float));
        Console.WriteLine("double \t" + default(double));
        Console.WriteLine("Decimal \t" + default(decimal));
        Console.WriteLine("string \t" + default(string) == null ? "null" : "empty");
        Console.WriteLine("object \t" + default(object) == null ? "null" : "empty");
        Console.ReadLine();
    }    
}


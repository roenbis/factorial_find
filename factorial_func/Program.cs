namespace factorial_func;

class Program
{
    static void Main()
    {
        double factorial = 1.0;
        
        for (int i = 1; i < 6; ++i)
        {
            factorial *= i;
            Console.WriteLine(factorial);;
        }
    }
}
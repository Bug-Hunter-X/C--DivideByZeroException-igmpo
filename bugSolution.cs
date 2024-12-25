public class ExampleClass
{
    public int Calculate(int a, int b)
    {
        try
        {
            return a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero detected. "+ex.Message);
            return 0; // Or handle the exception appropriately
        }
    }
}
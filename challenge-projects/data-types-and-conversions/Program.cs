internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Problem 1:");
        string message = "";
        float total = 0;

        string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        for (int i = 0; i < values.Length; i++)
        {
            float number = 0;
            if (float.TryParse(values[i], out number))
            {
                total += number;
            }
            else
            {
                message += values[i];
            }
        }
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {total}");


        ////////////////////////////////////////////////////////////////


        Console.WriteLine("\nProblem 2:");

        int value1 = 12;
        decimal value2 = 6.2m;
        float value3 = 4.3f;

        int result1 = value1 / Convert.ToInt32(value2);
        // Hint: You need to round the result to nearest integer (don't just truncate)
        Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

        decimal result2 = value2 / (decimal)value3;
        Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

        float result3 = value3 / (float)value1;
        Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer value between 5 and 10");

        int integerValue = 0;
        bool validNumber = false;
        string? userInputOne;
        bool questionOne = false;

        do
        {
            userInputOne = Console.ReadLine();

            if (userInputOne == null)
            {
                Console.WriteLine("Enter an integer value between 5 and 10");
            }
            else
            {
                validNumber = int.TryParse(userInputOne, out integerValue);

                if (validNumber == false)
                {
                    Console.WriteLine("Sorry, you entered an invalid number, please try again.");
                }
                else if (integerValue < 5 || integerValue > 10)
                {
                    Console.WriteLine($"You entered {integerValue}. Please enter a number between 5 and 10");
                }
                else
                {
                    Console.WriteLine($"Your input value ({integerValue}) has been accepted.");
                    questionOne = true;
                }
            }
        } while (questionOne == false);

        /*
        Enter an integer value between 5 and 10
        two
        Sorry, you entered an invalid number, please try again
        2
        You entered 2. Please enter a number between 5 and 10.
        7
        Your input value (7) has been accepted.
        */

    }
}
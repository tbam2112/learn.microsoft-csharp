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
        Console.ReadLine();




        string? userInputTwo;
        bool questionTwo = false;
        Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

        do
        {
            userInputTwo = Console.ReadLine();
            userInputTwo = userInputTwo.Trim().ToLower();

            if ((userInputTwo == "administrator") || (userInputTwo == "manager") || (userInputTwo == "user"))
            {
                Console.WriteLine($"your input value ({userInputTwo}) has been accepted");
                questionTwo = true;
            }
            else
            {
                Console.WriteLine($"The role name that you entered, \"{user
                InputTwo}\" is not valid. Eneter your role name (Administrator, Manager, or User)");
            }

        } while (questionTwo == false);
        Console.ReadLine();




        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
        int stringsCount = myStrings.Length;

        string myString = "";
        int periodLocation = 0;

        for (int i = 0; i < stringsCount; i++) 
        {
            myString = myStrings[i];
            periodLocation = myString.IndexOf(".");

            string mySentence;

            while (periodLocation != -1)
            {
                mySentence = myString.Remove(periodLocation);

                myString = myString.Substring(periodLocation + 1);

                myString = myString.TrimStart();

                periodLocation = myString.IndexOf(".");

                Console.WriteLine(mySentence);
            }

            mySentence = myString.Trim();
            Console.WriteLine(mySentence);
            
        }


    }
}
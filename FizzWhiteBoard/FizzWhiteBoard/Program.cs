

//when the number is divisible by 3 return the word fizz

//when the number is divisible by 5 return the word buzz

//when the number is divisible by both, return the word fizzbuzz



namespace ChristmasWithTypes
{
    class Program
    {
        public static string Main(int number)
        {  
            if (number % 3 == 0)
                return "fizz";
            if (number % 5 == 0)
                return "buzz";
            else if (number % 3 == 0 && number % 5 == 0)
                return "fizzbuzz";
            else
                return null;
        }
    }
}

// LinkedIN Learning Challenge
// Learning Path: Software Development Fundamentals
// Course: Learning C#
// Challenge: Palindrome
// Student: Andrey Ivanov


internal class Program
{
    private static (bool, int) CheckPalindrome(string inputString)
    {
        string tmpString = new string(inputString.Where(Char.IsLetter).ToArray()).ToLower();
        bool isPalindrome = tmpString.Equals(new string (tmpString.ToCharArray().Reverse().ToArray()));

        return (isPalindrome, isPalindrome ? inputString.Length : 0);
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Let's begin:");

        while (true)
        {
            string? inputString = Console.ReadLine();

            if (inputString == null || inputString.ToLower().Equals("exit"))
            {
                break;
            }
            else
            {
                (bool, int) result = CheckPalindrome(inputString);
                Console.WriteLine($"Palindrome: {result.Item1}, Length: {result.Item2}");
            }
        }
    }
}
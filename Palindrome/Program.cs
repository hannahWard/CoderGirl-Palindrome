using System;

namespace Palindrome
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please, enter a word: ");
            string userInput = Console.ReadLine();
            char[] userInputArray = userInput.ToCharArray();
            userInput = string.Join("", userInputArray);

            Array.Reverse(userInputArray);
            string reverseUserInput = string.Join("", userInputArray);

            Console.WriteLine(CheckPalindrome(reverseUserInput, userInput));
            Console.ReadLine();

        }

        // TODO: Create a method that recognizes palindromes.

        public static bool CheckPalindrome(string reverseUserInput, string userInput)
        {

            if (reverseUserInput.Equals(userInput))
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }
    }
}

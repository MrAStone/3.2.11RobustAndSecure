using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._11RobustAndSecure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(validPWDFormatCheck("abc123"));
            Console.WriteLine(authenitcated("Bob", "letmen"));
            Console.WriteLine(authenticated2D("Bob", "letmein"));

        }

        // Be able to write simple data validation routines.
        //checking if an entered string has a
        //minimum length
        static bool StringMinLength(string input, int lengthRequired)
        {
            if (input.Length < lengthRequired)
            {
                return false;
            }
            return true;
        }
        //Checking if a string is empty
        static bool isStringEmpty(string input)
        {
            if (input.Length == 0)
            {
                return true;
            }
            return false;
        }

        //Checking if data entered lies within a give range
        //e.g. between 1 and 10
        static bool rangeCheck(int input,int lower, int upper)
        {
            if (input>=lower && input<=upper)
            {
                return true;
            }
            return false;
        }

        // Other validation functions
        // Check a string contains a character
        static bool containsChar(string input,char charToCheck)
        {
            if (input.Contains(charToCheck))
            {
                return true;
            }
            return false;
        }
        // Check a string contains
        // at least
        // one upper case
        // one lower case
        // one number
        // at least 8 characters
             static bool validPWDFormatCheck(string input)
        {
            if (!StringMinLength(input,8)) // if the result of using the StringMinLength function is not true (!true)
            {
                return false;
            }
            bool containsUpper = false;
            bool containsLower = false;
            bool containsNumber = false;
            
            foreach (char c in input)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    containsUpper = true;
                }
                if (c >= 'a' && c <= 'z')
                {
                    containsLower = true;
                }
                if(c >= '0' && c <= '9')
                {
                    containsNumber = true;
                }
                
            }
            return containsUpper && containsLower && containsNumber;
        }

        //Be able to write simple authentication routines
        static bool authenitcated(string username, string password)
        {
            string[] usernames = new string[] { "Bob", "Bill", "Betty" };
            string[] passwords = new string[] { "letmein", "123456", "password" };
            int index = 0;
            while (index < usernames.Length)
            {
                if (usernames[index] == username && passwords[index] == password)
                {
                    return true;
                }
                index++;
            }
            return false;

        }

        static bool authenticated2D(string username, string password)
        {
            string[,] usernamePwds = { { "Bob", "Bill", "Betty" }, { "letmein", "123456", "password" } };
            for(int i = 0;i < usernamePwds.GetLength(0);i++)
            {
                if (usernamePwds[0,i]==username && usernamePwds[1, i] == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

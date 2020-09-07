﻿
namespace Library
{
    public class StringClass
    {
        //This function counts how many Js there are in a string

        //eg "ehj" = 1, "jjj" = 3
        // 

        //Difficulty 3/5
        public static int CountJs(string testString)
        {
            string lowerString = testString.ToLower();
            var counter = 0;
            char compare = 'j';

            for (int i = 0; i < lowerString.Length; i++)
            {
                char character = lowerString[i];
                if (character == compare)
                {
                    counter += 1;
                }
            }
            return counter;
         }


        //This functions removed undesirables from a string
        //It removes :
            //Trailing whitespace
                // "     eg      "
            //hyphens
                // "----eg----"
            //make it lowercase
                // "ARGH" => "argh"

        //Difficulty 4/5
        public static string RemoveArtefacts(string testString)
        {
            return testString.Trim(' ','-').ToLower();
        }

        //SUPER BLOCK
        //This is a function that returns an integer
        //for the longest chain of a certain char in a string
        // for example:

        //
            /*
            "ACIEWHJSLKOSJDOD" returns 1
            "ss" return 2
            "sS" return 1
            "cjeijifjDDDDdoj3iufji3j" returns 4
            */
        //

        //Difficulty 5/5
        public static int SuperBlock(string testString)
        {
            var counter = 0;
            var longestChain = 0;
            char lastCharacter = testString[0];

            if(testString[0] == ' ')
            {
                return 0;
            }
            for (int i = 0; i < testString.Length; i++)
            {
                char character = testString[i];
                if ( character == lastCharacter)
                {
                    counter += 1;
                }
                else
                {
                    counter = 0;
                }
                
                if(counter > longestChain)
                {
                    longestChain = counter;
                }
                lastCharacter = character;
            }
            return longestChain;
        }

        //This function checks if the string is the same forward as backwards
        // eg => "racecar" or "wow"

        //HINT: for loops can go backwards too! i--

        //Difficulty 5/5
        public static bool IsPalindrome(string testString)
        {
            string forwardString = testString;
            string backwardString = "";

            for (int i = testString.Length -1; i >=0; i--)
            {
                string character = testString[i].ToString();
                backwardString += character;
            }
            
            if (forwardString == backwardString)
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

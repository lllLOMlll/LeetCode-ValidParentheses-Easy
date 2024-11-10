using System.Reflection.Metadata;
using Microsoft.VisualBasic;

class Program
{

    public bool IsValid(string s)
    {

        bool isParenthesesOpen = false;
        bool isBracketsOpen = false;
        bool isCurlyBracketsOpen = false;

        int currentIndex = 0;

        int openedParentheses = 0;
        int closedParentheses = 0;
        int openedBrackets = 0;
        int closedBrackets = 0;
        int openedCurlyBrackets = 0;
        int closedCurlyBrackets = 0;

        foreach (char charOfs in s)
        {
            // Begin with closing sign
            if (currentIndex == 0)
            {
                if (charOfs == ')' || charOfs == ']' || charOfs == '}')
                {
                    return false;
                }
            }

            // Parentheses
            if (charOfs == '(')
            {
                isParenthesesOpen = true;
                openedParentheses += 1;
            }
            else if (charOfs == ')')
            {
                if (s[currentIndex - 1] == '[' || s[currentIndex - 1] == '{')
                {
                    return false;
                }
                closedParentheses += 1;
                if ((openedParentheses - closedParentheses) == 0)
                {
                    isParenthesesOpen = false;
                }
            }

            // Brackets
            if (charOfs == '[')
            {
                if (isParenthesesOpen || isCurlyBracketsOpen)
                {
                    // if not last iteration -> I dont want to go out of bound
                    if (currentIndex != s.Length - 1)
                    {

                        if (s[currentIndex + 1] == ']')
                        {
                            if (currentIndex != s.Length - 2)
                            {
                                if (s[currentIndex + 2] == ']')
                                {
                                    return false;
                                }
                            }
                            break;
                        }
                    }
                    return false;
                }
            }
            if (charOfs == '[')
            {
                openedBrackets += 1;
                isBracketsOpen = true;
            }
            else if (charOfs == ']')
            {
                if (s[currentIndex - 1] == '(' || s[currentIndex - 1] == '{')
                {
                    return false;
                }
                closedBrackets += 1;
                if ((openedBrackets - closedBrackets) == 0)
                {
                    isBracketsOpen = false;
                }
            }

            // Curly Brackets
            if (charOfs == '{')
            {
                openedCurlyBrackets += 1;
                isCurlyBracketsOpen = true;
            }
            else if (charOfs == '}')
            {
                if (s[currentIndex - 1] == '(' || s[currentIndex - 1] == '[')
                {
                    return false;
                }
                closedCurlyBrackets += 1;
                if ((openedCurlyBrackets - closedCurlyBrackets) == 0)
                {
                    isCurlyBracketsOpen = false;
                }
            }


            // Last iteration
            if (currentIndex == s.Length - 1)
            {
                if (charOfs == '(' || charOfs == '[' || charOfs == '{')
                {
                    return false;
                }
                if ((openedParentheses - closedParentheses) != 0 || (openedBrackets - closedBrackets) != 0 || (openedCurlyBrackets - closedCurlyBrackets) != 0)
                {
                    return false;
                }
            }

            currentIndex += 1;
        }


        return true;
    }

    static void Main(string[] args)
    {
        Program p = new Program();
        //Test 1
        string test1 = "()";
        Console.WriteLine("() = " + p.IsValid(test1));

        // Test 1.2
        string test1_2 = "(()";
        Console.WriteLine("(() = " + p.IsValid(test1_2));

        // // Test 1.22
        string test1_22 = "(())";
        Console.WriteLine("(()) = " + p.IsValid(test1_22));

        // Test 1.222
        string test1_222 = "([)])";
        Console.WriteLine("([)]) = " + p.IsValid(test1_222));

        // Test 1.3
        string test1_3 = "(())(";
        Console.WriteLine("(())( = " + p.IsValid(test1_3));

        // Test 2
        string test2 = "()[]{}";
        Console.WriteLine("()[]{} = " + p.IsValid(test2));

        // Test 3
        string test3 = "(]";
        Console.WriteLine("(] = " + p.IsValid(test3));

        // Test 4
        string test4 = "([])";
        Console.WriteLine("([]) = " + p.IsValid(test4));

        // Test 4
        string test5 = "([)]";
        Console.WriteLine("([)] = " + p.IsValid(test5));

        // Final test 
        string testFinal = "[([]])";
        Console.WriteLine("[([]]) = " + p.IsValid(testFinal));
    }
}

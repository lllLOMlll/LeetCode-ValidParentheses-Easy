using System.Reflection.Metadata;
using Microsoft.VisualBasic;

class Program 
{
 
        public bool IsValid(string s) {
        // IDEA -> Making a array for opening and closing signs
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
                if (charOfs == ')' || charOfs == ']' ||charOfs == '}')
                {
                    return false;
                }
            }

            // Parentheses
            if (charOfs == '(' )
            {
                openedParentheses += 1;
            } 
            else if (charOfs == ')')
            {
                if (s[currentIndex-1] == '[' || s[currentIndex-1] == '{')
                {
                    return false;
                }
                closedParentheses += 1;
            }

            // Brackets
                  if (charOfs == '[' )
            {
                openedBrackets += 1;
            } 
            else if (charOfs == ']')
            {
                if (s[currentIndex-1] == '(' || s[currentIndex-1] == '{')
                {
                    return false;
                }
                closedBrackets += 1;
            }

            // Curly Brackets
                  if (charOfs == '{' )
            {
                openedCurlyBrackets += 1;
            } 
            else if (charOfs == '}')
            {
                if (s[currentIndex-1] == '(' || s[currentIndex-1] == '[')
                {
                    return false;
                }
                closedCurlyBrackets += 1;
            }


        // Last iteration
            if (currentIndex == s.Length - 1)
            {
                if ((openedParentheses - closedParentheses)!=0 || (openedBrackets - closedBrackets)!=0 || (openedCurlyBrackets - closedCurlyBrackets)!=0)
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
}
}

using System.Reflection.Metadata;
using Microsoft.VisualBasic;

class Program 
{
 
        public bool IsValid(string s) {
     
        int currentIndex = 0;
        int openedParentheses = 0;
        int closedParentheses = 0;
        int openedBrackets = 0;
        int closedBrackets = 0;
        int openedCurlyBrackets = 0;
        int closedCurlyBrackets = 0;
   
        foreach (char charOfs in s)
        {
            if (charOfs == '(' )
            {
                
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

    // // Test 1.3
    // string test1_3 = "(())(";
    // Console.WriteLine("(())( = " + p.IsValid(test1_3));

    // // Test 2
    // string test2 = "()[]{}";
    // Console.WriteLine("()[]{} = " + p.IsValid(test2));

    // // Test 3
    // string test3 = "(]";
    // Console.WriteLine("(] = " + p.IsValid(test3));

    // // Test 4
    // string test4 = "([])";
    // Console.WriteLine("([]) = " + p.IsValid(test4));

    // // Test 4
    // string test5 = "([)]";
    // Console.WriteLine("([)] = " + p.IsValid(test5));
}
}

using System.Reflection.Metadata;
using Microsoft.VisualBasic;

class Program 
{
 
        public bool IsValid(string s) {
        // How long is the string
        int stringLength = s.Length;
    
        // Flags for Parentheses and Brackets
        bool isParenthesesOpen = false;
        bool isBracketsOpen = false;
        bool isCurlyBraketsOpen = false;
        
   
        foreach (char charOfs in s)
        {
            
        // Parentheses
            if (charOfs == '(' && isParenthesesOpen == false)
            {
                isParenthesesOpen = true;             
            } 
            else if (charOfs == '(' && isParenthesesOpen == true)
            {
                return false;              
            }

            if (charOfs == ')' && isParenthesesOpen == true)
            {
                if (isBracketsOpen || isCurlyBraketsOpen)
                {
                    return false;
                } else
                {
   isParenthesesOpen = false;     
                }
                     
            } 
            else if (charOfs == ')' && isParenthesesOpen == false)
            {
                return false;
            }

            // Brakets
            if (charOfs == '[' && isBracketsOpen == false)
            {
                isBracketsOpen = true;             
            } 
            else if (charOfs == '[' && isBracketsOpen == true)
            {
                return false;              
            }

            if (charOfs == ']' && isBracketsOpen == true)
            {
                if (isParenthesesOpen || isCurlyBraketsOpen)
                {
                    return false;
                }
                else
                {
                    isBracketsOpen = false;    
                }
                      
            } 
            else if (charOfs == ']' && isBracketsOpen == false)
            {
                return false;
            }

            // Brakets
            if (charOfs == '{' && isCurlyBraketsOpen == false)
            {
                isCurlyBraketsOpen = true;             
            } 
            else if (charOfs == '{' && isCurlyBraketsOpen == true)
            {
                return false;              
            }

            if (charOfs == '}' && isCurlyBraketsOpen == true)
            {
                if (isParenthesesOpen || isBracketsOpen)
                {
                    return false;
                }
                else     
                {
                  isCurlyBraketsOpen = false;   
                }
                        
            } 
            else if (charOfs == '}' && isCurlyBraketsOpen == false)
            {
                return false;
            }
        }
            
    
        return true;
    }

static void Main(string[] args)
{
    Program p = new Program();
    // Test 1
    string test1 = "()";
    Console.WriteLine("() = " + p.IsValid(test1));

    // Test 1.2
    string test1_2 = "(()";
    Console.WriteLine("(() = " + p.IsValid(test1_2));

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

using System.Reflection.Metadata;
using Microsoft.VisualBasic;

class Program
{

    public bool IsValid(string s) {
        // Stack to keep track of opening brackets
        Stack<char> stack = new Stack<char>();

        // Iterate through each character in the string
        foreach (char c in s) {
            if (c == '(' || c == '{' || c == '[') {
                // If it's an opening bracket, push it onto the stack
                stack.Push(c);
            } else {
                // If it's a closing bracket
                if (stack.Count == 0) {
                    return false; // No matching opening bracket
                }

                char top = stack.Pop();
                if ((c == ')' && top != '(') || 
                    (c == '}' && top != '{') || 
                    (c == ']' && top != '[')) {
                    return false; // Mismatched brackets
                }
            }
        }

        // If the stack is empty, all brackets were matched correctly
        return stack.Count == 0;
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

        // Last charcacter is open
        string lastCharOpen = "([]){";
        Console.WriteLine("([]){ : " + p.IsValid(lastCharOpen));
    }
}

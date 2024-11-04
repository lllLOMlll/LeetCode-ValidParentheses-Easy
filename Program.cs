using System.Reflection.Metadata;

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
            if (charOfs == '(' && isParenthesesOpen == false)
            {
                isParenthesesOpen = true;
            } 
            
            if (charOfs == '(' && isParenthesesOpen == true)
            {
                return false;
            }

            if (charOfs == ')' && isParenthesesOpen == true)
            {
                isParenthesesOpen = false;
            }

            if (charOfs == ')' && isParenthesesOpen == false)
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

    // // Test 2
    // string test2 = "()[]{}";
    // Console.WriteLine("()[]{} = " + p.IsValid(test2));

    // // Test 3
    // string test3 = "(]";
    // Console.WriteLine("(] = " + p.IsValid(test3));

    // // Test 4
    // string test4 = "(]";
    // Console.WriteLine("(] = " + p.IsValid(test4));
}
}

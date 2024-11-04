class Program 
{
        public bool IsValid(string s) {
        int stringLength = s.Length;
        bool isParentheseOpen = false;

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

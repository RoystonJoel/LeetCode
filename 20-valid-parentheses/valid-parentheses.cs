public class Solution {
    public bool IsValid(string s) {
        List<char> open = new List<char>();
        List<char> close = new List<char>();
        Stack<char> stack = new Stack<char>();

        open.Add('(');
        open.Add('[');
        open.Add('{');
        
        close.Add(')');
        close.Add(']');
        close.Add('}');

        foreach(char c in s)
        {
            if(open.Contains(c)){
                stack.Push(c);
            } else if(close.Contains(c)){
                if (stack.Count == 0) {
                    return false;
                }
                char topChar = stack.Peek();
                 if (DoesMatch(topChar, c)){
                    stack.Pop();
                } else {
                    return false;
                }
            }
        }
        // After checking all characters, if the stack is empty, all brackets were matched
        // If it's not empty, there are unmatched opening brackets
        return stack.Count == 0;
    }

    public bool DoesMatch(char open, char close)
    {
        switch (open)
        {
            case '(':
                return close == ')';
            case '[':
                return close == ']';
            case '{':
                return close == '}';
            default:
                return false;
        }
    }
}
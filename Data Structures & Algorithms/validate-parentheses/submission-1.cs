public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 == 1) {
            return false;
        }
        var stack  = new Stack<char>();
        char expected;
        foreach(char c in s) {
            switch(c) {
                case '(':
                    stack.Push(')');
                    break;
                case '[':
                    stack.Push(']');
                    break;
                case '{':
                    stack.Push('}');
                    break;
                case ')':
                    if(stack.Count == 0 || stack.Pop() != ')') {
                        return false;
                    }
                    break;
                case ']':
                    if(stack.Count == 0 || stack.Pop() != ']') {
                        return false;
                    }
                    break;
                case '}':
                    if(stack.Count == 0 || stack.Pop() != '}') {
                        return false;
                    }
                    break;
                default:
                // Invalid char
                return false;
            }
        }

        if(stack.Count != 0) {
            return  false;
        }
        return true;
    }
}

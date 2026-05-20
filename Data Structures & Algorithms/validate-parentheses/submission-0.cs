public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary <char,char> pairs = new Dictionary<char,char>
        {
            {')','('},
            {']','['},
            {'}','{'}
        };

        foreach (char c in s){
            if (!pairs.ContainsKey(c)) 
            {
                stack.Push(c); //opening pair
            }
            else if(stack.Count == 0 || stack.Pop() != pairs[c]) //closing pair
                return false;
        }
        return stack.Count == 0;

        
        
    }
}

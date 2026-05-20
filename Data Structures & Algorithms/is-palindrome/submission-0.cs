public class Solution {
    public bool IsPalindrome(string s) {

        int p = 0, q= s.Length - 1;

        while (p < q)
        {
            if(!char.IsLetterOrDigit(s[p])) {
                p++;
            }
           else if (!char.IsLetterOrDigit(s[q])) {
            q--;
           }  else{
            if (char.ToLower(s[p]) != char.ToLower(s[q])){
                return false;
            }
            p++;
            q--;
            
           }

          
        }
        return true;
    }
}

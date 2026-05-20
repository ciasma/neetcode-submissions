public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

            Dictionary<char, int> checker = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (checker.ContainsKey(c))
                    ++checker[c];
                else
                    checker[c] = 1;
            }

            foreach (char c in t)
            {
                if (!checker.ContainsKey(c))
                    return false;
                --checker[c];
            }

            return checker.Values.Any(x => x != 0)  ? false : true;

    }
}

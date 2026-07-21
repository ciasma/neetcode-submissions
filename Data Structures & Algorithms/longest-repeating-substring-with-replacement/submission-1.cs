public class Solution {
    public int CharacterReplacement(string s, int k) {
        int left = 0, maxFreq = 0, maxLength = 0;
        int[] count = new int[26];

        for (int right = 0; right < s.Length; right++) {
            maxFreq = Math.Max(maxFreq, ++count[s[right] - 'A']);

            while ((right - left + 1) - maxFreq > k) {
                maxFreq = Math.Max(maxFreq,--count[s[left] - 'A']);
                left++;
            }
            maxLength = Math.Max(maxLength, right - left + 1);
        }
        return maxLength;
    }
}

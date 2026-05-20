public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
                
            Dictionary<string, List<string>> sortedStrsDict = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                char[] input = str.ToCharArray();
                Array.Sort(input);
                var sortedStr = new string(input);
                if (!sortedStrsDict.ContainsKey(sortedStr))
                {
                    sortedStrsDict.Add(sortedStr, new List<string>());
                }

                sortedStrsDict[sortedStr].Add(str);

            }

            var output = new List<List<string>>();
            foreach (var kvp in sortedStrsDict)
            {
                output.Add(kvp.Value);
            }

            return output;
        
    }
}

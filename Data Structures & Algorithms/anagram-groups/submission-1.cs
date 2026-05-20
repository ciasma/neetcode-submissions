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

         
            return new List<List<string> >(sortedStrsDict.Values);
        
    }
}

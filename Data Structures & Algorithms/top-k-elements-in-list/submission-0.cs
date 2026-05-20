public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
         Dictionary<int, int> frequencyDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (frequencyDict.ContainsKey(nums[i]))
                {
                    frequencyDict[nums[i]]++;
                }
                else
                {
                    frequencyDict[nums[i]] = 1;
                }
            }
            //sort dictionary by value
            var frequencies = 
                frequencyDict.OrderByDescending(x => x.Value);
        
            // select keys from kvp change to a list so that getrange can be used and return as an array
            return  frequencies.Select(pair => pair.Key).ToList().GetRange(0, k).ToArray();
           

    }
}

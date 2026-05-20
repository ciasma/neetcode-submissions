// Definition for a pair
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<List<Pair>> InsertionSort(List<Pair> pairs) {
        if(pairs.Count == 0)return new List<List<Pair>>();
        
        var result = new List<List<Pair>>();
        result.Add(new List<Pair>(pairs));
        for(int i = 1; i < pairs.Count; i++){ //first item is its own subarray
            var j = i-1;
            var currentPair  = pairs[i];
            while(j > -1 && pairs[j].Key > currentPair.Key) {
                pairs[j+1] = pairs[j];               
                j--;
            }
            pairs[j + 1] = currentPair;
            
            result.Add(new List<Pair>(pairs));
            
        }
        return result;    

    }
}

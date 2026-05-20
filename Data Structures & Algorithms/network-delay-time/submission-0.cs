public class Solution {
    public int NetworkDelayTime(int[][] times, int n, int k) {
        Dictionary<int, List<(int, int)>> adj = new Dictionary<int, List<(int, int)>>();

        int[] timeTaken = new int[n + 1];
        Array.Fill(timeTaken, int.MaxValue);
        timeTaken[0] = 0;

        PriorityQueue<(int, int), int> minHeap = new PriorityQueue<(int, int), int>();

        //populate adjacency list

        for (int i = 0; i < times.Length; i++)
        {
            var edge = times[i];
            if (!adj.ContainsKey(edge[0]))
            {
                adj[edge[0]] = new List<(int, int)>();
            }

            adj[edge[0]].Add((edge[1], edge[2]));

        }

        // add start to queue
        minHeap.Enqueue((k, 0), 0);
        timeTaken[k] = 0;

        while(minHeap.Count > 0){
            (int currentNode, int currentTime) = minHeap.Dequeue();
            if (!adj.ContainsKey(currentNode)) continue;

            foreach (var (neighbor,   time) in adj[currentNode])
            {
                var newTime = currentTime + time;
                if (newTime < timeTaken[neighbor])
                {
                    timeTaken[neighbor] = newTime;
                    minHeap.Enqueue((neighbor, newTime), newTime);
                }
            }
        }

        Console.WriteLine(string.Join(" ",timeTaken));

    
        return timeTaken.Any(x => x == int.MaxValue) ? -1 : timeTaken.Max();
    }
}

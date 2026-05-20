public class Solution {
    public Dictionary<int, int> ShortestPath(int n, List<List<int>> edges, int src) {

            
        Dictionary<int, List<(int, int)>> adj = new Dictionary<int, List<(int, int)>>();
        HashSet<int> visited = new HashSet<int>();
        Dictionary<int, int> distances = new Dictionary<int, int>();
        PriorityQueue<(int, int), int> priorityQueue = new PriorityQueue<(int, int), int>();

        foreach (var edge in edges)
        {

            if (!adj.ContainsKey(edge[0]))
            {
                adj[edge[0]] = new List<(int, int)>();
            }
            adj[edge[0]].Add((edge[1], edge[2]));

        }

        for (int i = 0; i < n; i++)
        {
            distances[i] = Int32.MaxValue;
        }

        distances[src] = 0;
        priorityQueue.Enqueue((src, 0), 0);
        while (priorityQueue.Count > 0)
        {
            (int currentNode, int currentCost) = priorityQueue.Dequeue();
            if (visited.Contains(currentNode)) continue;
            visited.Add(currentNode);



            if (!adj.ContainsKey(currentNode)) continue;


            foreach (var (neighbor, cost) in adj[currentNode])
            {
                int newCost = currentCost + cost;
                if (newCost < distances[neighbor])
                {
                    distances[neighbor] = newCost;
                    priorityQueue.Enqueue((neighbor, newCost), newCost);
                }
            }
        }

        distances =  distances.ToDictionary(kvp => kvp.Key, kvp => kvp.Value == int.MaxValue ? -1 : kvp.Value);
       

        return distances;
    }
}

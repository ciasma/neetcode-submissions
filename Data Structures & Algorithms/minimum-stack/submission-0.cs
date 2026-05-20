public class MinStack {

    private List <int> _minStack;
    public MinStack() {
        _minStack = new List<int>();
        
    }
    
    public void Push(int val) {
        _minStack.Add(val);
    }
    
    public void Pop() {
        _minStack.RemoveAt(_minStack.Count - 1);
    }
    
    public int Top() {
        return _minStack[_minStack.Count - 1];
    }
    
    public int GetMin() {
        var minValue = Int32.MaxValue;
        foreach (int ele in _minStack)
        {
            minValue = Math.Min(minValue, ele);
        }
        return minValue;
    }
}

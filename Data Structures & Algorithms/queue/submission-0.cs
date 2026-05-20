class Deque {
    public LinkedList<int> deq;

    public Deque() {
        deq = new LinkedList<int>();

    }

    public bool isEmpty() {
        return deq.Count == 0;
    
    }

    public void append(int value) {
        deq.AddLast(value);

    }

    public void appendleft(int value) {
        deq.AddFirst(value);

    }

    public int pop() {
        if(deq.Count <= 0) return -1;
        var last = deq.Last.Value;
        deq.RemoveLast();
        return last;
    }

    public int popleft() {
        if(deq.Count <= 0) return -1;
        var first = deq.First.Value;
        deq.RemoveFirst();
        return first;

    }
}

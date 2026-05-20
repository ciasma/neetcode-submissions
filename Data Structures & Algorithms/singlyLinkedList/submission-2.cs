public class Node {
    public int value;
    public Node next;
    public Node () {
        next = null;
    }
}
public class LinkedList {
    public Node head;
    public Node tail;
    public int counter = 0;

    public LinkedList() {


    }

    public int Get(int index) {
        if(index >= counter) return -1;
        var curr = head;
        for(int i = 0; i < index; i++){
            curr = curr.next;
        }
        return curr.value;
    }

    public void InsertHead(int val) {
        var newNode = new Node();
        newNode.value = val;
        newNode.next = head;
        head = newNode;
        if(counter == 0){
            tail = head;
        }
        counter++;
    }

    public void InsertTail(int val) {
        var newNode = new Node();
        newNode.value = val;
        newNode.next = null;
        if(tail == null){
            tail = newNode;
            head = tail;
        }
        else{         
            tail.next = newNode;
            tail = newNode;
        }
        counter++;

    }

    public bool Remove(int index) {  
        if(index >= counter) return false;

        if(index == 0) {
            head = head.next;
            counter--;
            if(counter == 0) tail=null;
            return true;
        }
        Node prev = null;
        Node curr = head;
        for(int i = 0; i < index; i++){
            prev = curr;
            curr = curr.next;
        }
        prev.next = curr.next;
        if (prev.next == null) {
            tail = prev; // Update metadata to match the new reality
        }
        counter--;
        curr = head;
        return true;      

    }

    public List<int> GetValues() {
        List<int> values = new List<int>();
        var curr = head;
        for(int i = 0; i < counter; i++)
        {
           // Console.WriteLine(i + " " + curr.value + " " + counter);
            values.Add(curr.value);
            curr= curr.next;
        }
        return values;
    }

}
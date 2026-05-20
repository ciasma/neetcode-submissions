public class DynamicArray {
    private int _capacity;
    private int _size;
    private int [] _arr;
    public DynamicArray(int capacity) {
        _capacity = capacity;
        _arr = new int [capacity];
        _size =0;


    }

    public int Get(int i) {
        return _arr[i];
    }

    public void Set(int i, int n) {
        _arr[i] = n;

    }

    public void PushBack(int n) {

       if(GetSize() == GetCapacity())
       {
        Resize();
       }
       _arr[_size] = n;
       _size++;

    }

    public int PopBack() {
        _size--;        
        return _arr[GetSize()];
    }

    private void Resize() {
        var newArray = new int[_size * 2];
        for(int i = 0; i < _size; i++) {
            newArray[i] = _arr[i];
        }
        _arr = newArray;
        _capacity = _size * 2;
        //delete [] newArray;

    }

    public int GetSize() {
        return _size;
    }

    public int GetCapacity() {
        return _capacity;
    }
}

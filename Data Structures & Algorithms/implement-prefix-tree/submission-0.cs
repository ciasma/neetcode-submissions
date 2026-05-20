public class PrefixTree {
    class TrieNode {
        public bool leaf;   // isLeaf
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    }
    private TrieNode root;
    public PrefixTree() {
        root = new TrieNode();        
        
    }
    
    public void Insert(string word) {
        TrieNode curr = root;
        foreach(char c in word){
            if(!curr.children.ContainsKey(c)){
                curr.children[c] = new TrieNode();
            }
            curr = curr.children[c];
        }
        curr.leaf = true;
    }
    
    public bool Search(string word) {
        TrieNode curr = root;
        foreach(char c in word){
            if(!curr.children.ContainsKey(c)){
                return false;
            }

            curr = curr.children[c];
        }
        
        if(curr.leaf) return true;
        return false;

       
    }
    
    public bool StartsWith(string prefix) {
        TrieNode curr = root;
        foreach(char c in prefix){
            if(!curr.children.ContainsKey(c)){
                return false;
            }
            curr = curr.children[c];
        }
        return true;
        
    }
}

 class TreeNode
    {
        public TreeNode left;
        public  TreeNode right;
        public  (int key, int val) entry;
        public TreeNode(int key, int val)
        {
            entry.key = key;
            entry.val = val;

        }
    }
    class TreeMap
    {

        public TreeNode root;

        public TreeMap()
        {
            root = null;

        }

        public void Insert(int key, int val)
        {

            TreeNode newNode = new TreeNode(key, val);
            if (root == null)
            {
                root = newNode;
                return;
            }

            var curr = root;
            while (true)
            {
                if (key < curr.entry.key)
                { 
                    if (curr.left == null)
                    {
                        curr.left = newNode;
                        return;
                    }
                    curr = curr.left;
                }
                else if (key > curr.entry.key)
                {
                    if (curr.right == null)
                    {
                        curr.right = newNode;
                        return;
                    }
                    curr = curr.right;
                }
                else
                {
                    curr.entry.val = val;
                    return;
                }

            }
        }
  

    public int Get(int key)
    {
        var curr = root;

        while (curr != null)
        {
            if (key < curr.entry.key)
            {
                curr = curr.left;
            }
            else if (key > curr.entry.key )
            {
                curr = curr.right;
            }
            else
            {
                return curr.entry.val;
            }
        }
        return -1;

    }

    public int GetMin()
    {
        var curr = root;
        if (curr == null) return -1;
        while (curr != null)
        {
            if (curr.left != null)
            {
                curr = curr.left;
            }
            else return curr.entry.val;

        }
            return -1;
    }

    public int GetMax()
    {
        var curr = root;
        if (curr == null) return -1;
        while (curr != null)
        {
            if (curr.right != null)
            {
                curr = curr.right;
            }
            else return curr.entry.val;
        }
            return -1;
    }

    public TreeNode FindMin(TreeNode node)
    {
        var curr = node;
        while (curr.left != null)
        {
            curr = curr.left;
        }
        return curr;
    }

    public void Remove(int key)
    {
        root = RemoveNode(key, root);
    }

    public TreeNode RemoveNode(int key, TreeNode curr)
    {
        if (curr == null) return curr;

        if (key > curr.entry.key)
        { 
            curr.right = RemoveNode(key, curr.right);
        }
        else if (key < curr.entry.key)
        {
            curr.left = RemoveNode(key, curr.left);
        }
        else
        {
            if (curr.left == null)
            {
                return curr.right;
            }
            else if (curr.right == null)
            {
                return curr.left;
            }

            var minNode = FindMin(curr.right);
            curr.entry.key = minNode.entry.key;
            curr.entry.val = minNode.entry.val;
            curr.right = RemoveNode(minNode.entry.key, curr.right);

        }
        return curr;
    }

    public List<int> GetInorderKeys()
    {
        List<int> result = new List<int>();
        GetInorderKeys(root, result);
        return result;

    }
    public void GetInorderKeys(TreeNode root, List<int> result)
    {
        if (root != null)
        {
            GetInorderKeys(root.left, result);
            result.Add(root.entry.key);
            GetInorderKeys(root.right, result);
        }

    }
}
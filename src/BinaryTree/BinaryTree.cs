namespace BinaryTree
{
    public class BinaryTree
    {
        public int Count { get; private set; }

        public BinaryTreeNode Root { get; set; }

        public void Add(int value)
        {
            if (Root == null)
            {
                Root = new BinaryTreeNode(value);
            }
            else
            {
                AddTo(Root, value);
            }
            Count++;
        }

        private void AddTo(BinaryTreeNode root, int value)
        {
            if (value < root.Data)
            {
                if (root.Left == null)
                {
                    root.Left = new BinaryTreeNode(value);
                }
                else
                {
                    AddTo(root.Left, value);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = new BinaryTreeNode(value);
                }
                else
                {
                    AddTo(root.Right, value);
                }
            }
        }
    }
}

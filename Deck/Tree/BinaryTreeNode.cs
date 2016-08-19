namespace Tree
{
    public class BinaryTreeNode<T>
    {
        public BinaryTreeNode(T content)
        {
            Content = content;
        }

        public BinaryTreeNode<T> Parent { get; set; }
        public BinaryTreeNode<T> LeftChild { get; set; }
        public BinaryTreeNode<T> RightChild { get; set; }
        public T Content { get; set; }

        public bool IsLeaf()
        {
            return LeftChild == null && RightChild == null;
        }
    }
}
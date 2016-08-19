using System.Collections.Generic;

namespace Tree
{
    public class BinaryTree<T>
    {
        private readonly IComparer<T> _comparer;
        public BinaryTreeNode<T> Root { get; set; }
        public BinaryTree(IComparer<T> comparer)
        {
            _comparer = comparer;
        }

        public void AddNode(T node)
        {
            var child = new BinaryTreeNode<T>(node);
            if (Root == null)
            {
                Root = child;
            }
            else
            {
                var current = Root;
                while (true)
                {
                    var compare = _comparer.Compare(current.Content, node);
                    if (compare == 1)
                    {
                        if (current.LeftChild == null)
                        {
                            current.LeftChild = child;
                            child.Parent = current;
                            break;
                        }
                         current = current.LeftChild;
                    }
                    else
                    {
                        if (current.RightChild == null)
                        {
                            current.RightChild = child;
                            child.Parent = current;
                            break;
                        }
                        current = current.RightChild;
                    }

                }
            }
        }

        public BinaryTreeNode<T> GetFarLeft(BinaryTreeNode<T> node)
        {
            var current = node;
            while (current.LeftChild != null)
                current = current.LeftChild;
            return current;
        }
    }
}
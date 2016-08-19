using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MainClass
{
    public static void Main()
    {
        var length = int.Parse(Console.ReadLine());
        var input = Console.ReadLine().Split(' ').Select(int.Parse);
        if (length == 3)
            Console.WriteLine("1 2 3");
        else
        {
            
            var sb = new StringBuilder();
            var bTree = new BinaryTree<int>(Comparer<int>.Default);
            var enumerator = new BinaryTreePostOrderEnumerator<int>(bTree);
            foreach (var i in input)
                bTree.AddNode(i);
            while (enumerator.MoveNext())
            {
                sb.Append(enumerator.Current + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }

    private class BinaryTreePostOrderEnumerator<T> : IEnumerator<T>
    {
        private readonly BinaryTree<T> _tree;
        private BinaryTreeNode<T> _current;

        public BinaryTreePostOrderEnumerator(BinaryTree<T> tree)
        {
            _tree = tree;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                _current = _tree.GetFarLeft(_tree.Root);
                if (_current.Equals(_tree.Root))
                    SetCurrent(_current);
            }
            else if (_current.Equals(_tree.Root))
            {
                return false;
            }
            else
            {
                var parent = _current.Parent;
                if (parent != null && parent.RightChild.Equals(_current))
                    _current = parent;
                else SetCurrent(parent.RightChild);
            }
            return true;
        }

        private void SetCurrent(BinaryTreeNode<T> node)
        {
            var farLeft = _tree.GetFarLeft(node);
            while (farLeft.Equals(_current) && !farLeft.IsLeaf())
            {
                _current = farLeft.RightChild;
                farLeft = _tree.GetFarLeft(farLeft.RightChild);
            }
            _current = farLeft;
        }

        public void Reset()
        {
            _current = null;
        }

        public T Current
        {
            get
            {
                if (_current == null)
                    throw new InvalidOperationException();
                return _current.Content;
            }
        }

        object IEnumerator.Current => Current;
    }

    private class BinaryTree<T>
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

    private class BinaryTreeNode<T>
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
using System;
using System.Collections;
using System.Collections.Generic;

namespace Tree
{
    public class BinaryTreePostOrderEnumerator<T> : IEnumerator<T>
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
                if(_current.Equals(_tree.Root))
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
                if(_current == null)
                    throw new InvalidOperationException();
                return _current.Content;
            }
        }

        object IEnumerator.Current => Current;
    }
}
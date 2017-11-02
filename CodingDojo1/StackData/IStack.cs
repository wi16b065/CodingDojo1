using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingDojo1.StackData
{
    class IStack<T>
    {

        private IStackNode<T> _currentStackNode;

        public void Push(T obj)
        {
            if (isEmpty())
            {
                this._currentStackNode = new IStackNode<T>(obj, null);
            }
            else
            {
                //shift current node back to previous node position
                this._currentStackNode = new IStackNode<T>(obj, this._currentStackNode);
            }
        }

        public T Pop()
        {
            if (isEmpty())
            {
                throw new Exception("IStack is empty.");
            }
            //cache popped value
            T poppedValue = _currentStackNode.Value;
            //shift previous node on top
            this._currentStackNode = this._currentStackNode.Previous;
            return poppedValue;
        }

        public T Peek()
        {
            return this._currentStackNode.Value;
        }

        public bool isEmpty()
        {
            return _currentStackNode == null;
        }
    }
}

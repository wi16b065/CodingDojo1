using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingDojo1.StackData
{
    class IStackNode<T>
    {
        public IStackNode(T obj, IStackNode<T> prev)
        {
            this.Value = obj;
            this.Previous = prev;
        }
        public T Value { get; set; }
        public IStackNode<T> Previous { get; set; }
    }
}

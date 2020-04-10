using System;
using System.Collections.Generic;
using System.Linq;

namespace _010_Min_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // ["MinStack","push","push","push","getMin","pop","top","getMin"]
            // [[],[-2],[0],[-3],[],[],[],[]]
            // Expected: [null,null,null,null,-3,null,0,-2]

            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            var min = minStack.GetMin(); //--> Returns - 3.
            minStack.Pop();
            var top = minStack.Top();    //--> Returns 0.
            min = minStack.GetMin();     //--> Returns - 2.
        }
    }

    class MinStack
    {
        private List<int> _stack;

        /** initialize your data structure here. */
        public MinStack()
        {
            _stack = new List<int>();
        }

        public void Push(int x)
        {
            _stack.Add(x);
        }

        public void Pop()
        {
            _stack.RemoveAt(_stack.Count - 1);
        }

        public int Top()
        {
            return _stack.Last();
        }

        public int GetMin()
        {
            return _stack.Min(it => it);
        }
    }
}

using System.Collections.Generic;

namespace QueueWithTwoStacks
{
    // Queue that is using internally two stacks to do its operations.
    public class MyQueue<T>
    {
        private Stack<T> pushStack;
        private Stack<T> popStack;

        public MyQueue()
        {
            pushStack = new Stack<T>();
            popStack = new Stack<T>();
        }

        public void Enqueue(T value)
        {
            pushStack.Push(value);
        }

        public T Dequeue()
        {
            if (popStack.Count <= 0)
            {
                while (pushStack.Count > 0)
                {
                    popStack.Push(pushStack.Pop());
                }
            }
            return popStack.Pop();
        }
    }
}

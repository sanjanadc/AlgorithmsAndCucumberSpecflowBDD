using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo_Repository.Arrays_Strings
{
    public  class MyCircularQueue
    {

        private int[] queue;
        private int head;
        private int count;
        private int capacity;

        public MyCircularQueue(int k)
        {

            this.queue = new int[k];
            this.capacity = k;
            this.head = 0;
            this.count = 0;

        }

        public bool EnQueue(int value)
        {
            if (this.count == this.capacity)
                return false;

            this.queue[(this.head + this.count) % this.capacity] = value;
            this.count += 1;
            return true;
        }

        public bool DeQueue()
        {
            if (this.count == 0)
                return false;

            this.head = (this.head + 1) % this.capacity;
            this.count -= 1;
            return true;
        }

        public int Front()
        {

            if (this.count == 0)
                return -1;
            return this.queue[this.head];
        }

        public int Rear()
        {

            if (this.count == 0)
                return -1;

            int tail = (this.head + this.count - 1) % this.capacity;
            return queue[tail];
        }

        public bool IsEmpty()
        {
            return (this.count == 0);
        }

        public bool IsFull()
        {
            return (this.capacity == this.count);

        }


        //public static void Main()
        //{
        //    MyCircularQueue obj = new MyCircularQueue(3);
        //    bool param_1 = obj.EnQueue(1);
        //    bool param_7 = obj.EnQueue(2);
        //    bool param_8= obj.EnQueue(3);
        //    bool param_9= obj.EnQueue(4);
        //    bool param_2 = obj.DeQueue();
        //    int param_3 = obj.Front();
        //    int param_4 = obj.Rear();
        //    bool param_5 = obj.IsEmpty();
        //    bool param_6 = obj.IsFull();
        //}
    }

   

    /**
     * Your MyCircularQueue object will be instantiated and called as such:
     * MyCircularQueue obj = new MyCircularQueue(k);
     * bool param_1 = obj.EnQueue(value);
     * bool param_2 = obj.DeQueue();
     * int param_3 = obj.Front();
     * int param_4 = obj.Rear();
     * bool param_5 = obj.IsEmpty();
     * bool param_6 = obj.IsFull();
     */
}

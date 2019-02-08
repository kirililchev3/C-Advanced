using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class DoublyLinkedList
    {
        private class ListNode
        {
            public ListNode(object value)
            {
                this.Value = value;
            }
            public object Value { get; private set; }

            public ListNode Next { get; set; }
            public ListNode Previous { get; set; }
        }
        private ListNode head;
        private ListNode tail;

        public int Count { get; private set; }

        public object Head
        {
            get
            {
                this.ValidateIfListIsEmpty();
                return this.head.Value;
            }
        }

        public object Tail
        {
            get
            {
                this.ValidateIfListIsEmpty();

                return this.tail.Value;
            }
        }
        public void AddHead(object value)
        {
            var newNode = new ListNode(value);
            if (this.Count == 0)
            {
                this.head = this.tail = newNode;
            }
            else
            {
                var newHead = newNode;
                newHead.Next = this.head;
               this.head.Previous = newHead;
               
               
                this.head = newHead;
            }
            this.Count++;
        }

        public void AddTail (object value)
        {
            
            var newNode = new ListNode(value);
            if (this.Count == 0)
            {
                this.head = this.tail = newNode;
            }
            else
            {
                var newTail = newNode;
               newTail.Previous = this.tail;
                this.tail.Next = newTail;
                this.tail = newTail;
            }
            this.Count++;
        }

        public object RemoveFirst()
        {
            this.ValidateIfListIsEmpty();
            var value = this.head.Value;
            this.head = this.head.Next;
            
            if (this.head != null)
            {
                this.head.Previous = null;
                
            }
            else
            {
                this.tail = null;
            }
            this.Count--;
            return value;
        }
        public object RemoveLast()
        {
            this.ValidateIfListIsEmpty();

            var value = this.tail.Value;
            this.tail = this.tail.Previous;
            if (this.tail != null)
            {
                
                this.tail.Next = null;
            }
            else
            {

                this.head = null;
            }

            this.Count--;

            return value;
        }

        

        

        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.Count = 0;
        }
        public void ForEach(Action<object> action)
        {
            var currentNode = this.head;
                
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public object[] ToArray()
        {
            object[] arr = new object[this.Count];
            var currentNode = this.head;
            var index = 0;

            while (currentNode != null)
            {
                arr[index] = currentNode.Value;
                
                currentNode = currentNode.Next;
                index++;
            }

            return arr;
        }
        private void ValidateIfListIsEmpty()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Doubly linked list is empty.");
            }
        }
    }
}

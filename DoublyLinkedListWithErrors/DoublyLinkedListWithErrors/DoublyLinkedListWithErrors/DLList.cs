namespace DoublyLinkedListWithErrors
{
    public class DLList
    {
        public DLLNode head; // pointer to the head of the list
        public DLLNode tail; // pointer to the tail of the list
        public DLList() { head = null; tail = null; } // constructor


        // This method will add a node to the tail of the list.
        public void addToTail(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                // ORIGINAL CODE
                // New node previous needs to be the old tail first, moved up in order.
                // tail.next = p;
                // tail = p;
                // p.previous = tail;

                tail.next = p;
                p.previous = tail;
                tail = p;
            }
        } // addToTail method complete


        // This method will add a node to head of the list
        // No errors to correct.
        public void addToHead(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.next = this.head;
                this.head.previous = p;
                head = p;
            }
        } // addToHead method complete


        //This method will remove the head node from the list.
        public void removeHead()//FIXED: typo, remov to remove
        {
            if (this.head == null)//Added in new code so return into nested brackets.
            {
                return;
            }//End of code I added in
            if (this.head == this.tail) //Added in new code: Check if there was only one node in the list .
            {
                this.head = null;
                this.tail = null;
            } //End of code I added in
            else
            {
                this.head = this.head.next;
                this.head.previous = null;
            }
        } // removeHead method complete


        // Remove the tail node from the list.
        public void removeTail()
        {
            if (this.tail == null) //Added in code to move return into nested brackets.
            {
                return;
            }//End of code I added in
            if (this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
            }
            else //Added in code to check for multi-node list.
            {
                this.tail = this.tail.previous;
                this.tail.next = null;
            } //End of code I added in
        } // removeTail method complete


        // Search method will look for a specified node
        public DLLNode search(int num)
        {
            DLLNode p = head;
            while (p != null)
            {
                // Original code:
                // moved p = p.next below if statement
                // {
                //      p = p.next;
                //      if (p.num == num) break;
                // }
                if (p.num == num)
                {
                    return p;
                }
                p = p.next;
            }
            return null; //FIXED: if the num is not found, return null
        } // search method complete


        // Remove a node from a list, for empty, singular, or multi-node list.
        public void removeNode(DLLNode p)
        {
            if (head == null) //Added in code to test for empty list, nothing else changed.
            {
                return;
            } //End of code I added in
            if (p.next == null)
            {
                this.tail = this.tail.previous;
                this.tail.next = null;
                p.previous = null;
                return;
            }
            if (p.previous == null)
            {
                this.head = this.head.next;
                p.next = null;
                this.head.previous = null;
                return;
            }
            p.next.previous = p.previous;
            p.previous.next = p.next;
            p.next = null;
            p.previous = null;
            return;
        } // removeNode method complete


        // Calculate the total of the nodes in the list
        public int total()
        {
            DLLNode p = head;
            int tot = 0;
            while (p != null)
            {
                tot += p.num;
                // Original code
                // FIXED: removed extra .next
                // p = p.next.next;
                p = p.next;
            }
            return (tot);
        } // total method complete.
    } // end of DLList class
}

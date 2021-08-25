using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAdvenced.Ariel.Hw.Generics
{
    // Targil 1 onther try 
    class GenricListArray<TArray>
    {
        public class Node
        {
            public TArray[] Data { get; set; }
            public Node Next { get; set; }

        }
        private Node head = null;
        public void Combine(TArray[] array)
        {
            if (head == null)
            {
                Node node = new Node() { Data = array, Next = null };
                head = node;
            }
            else
            {
                Node node = head;
                while (node.Next != null)
                {
                    node.Next = null;
                }
                node.Next = new Node() { Data = array, Next = null };
            }
        }
    }

}

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManagement
{
    class SystemLinkedListString : ICustomString
    {
        private LinkedList<char> linkedList;
        private Node start;

        public SystemLinkedListString()
        {
            linkedList = new LinkedList<char>();
            start = null;
        }

        public void DisplayList()
        {
            Node node;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("List is : ");
            node = start;
            while (node != null)
            {
                Console.Write(node.data + " ");
                node = node.nextNode;
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            int count = 0;
            Node node = start;
            while (node != null)
            {
                count++;
                node = node.nextNode;
            }
            Console.WriteLine($"Number of nodes in the list = {count}");
        }

        public bool Search(char charToFind)
        {
            int position = 1;
            Node node = start;
            while (node != null)
            {
                if (node.data == charToFind)
                {
                    break;
                }
                position++;
                node = node.nextNode;
            }
            if (node == null)
            {
                Console.WriteLine($"{charToFind} is not in the linked list");
                return false;
            }
            else
            {
                Console.WriteLine($"{charToFind} is at position {position}");
                return true;
            }
        }

        public new string ToString()
        {
            return linkedList.ToString();
        }

        public void InsertAtBeginning(char data)
        {
            Node temp = new Node(data);
            temp.nextNode = start;
            start = temp;
        }

        public void InsertAtEnd(char data)
        {
            Node node;
            Node temp = new Node(data);
            if (start == null)
            {
                start = temp;
                return;
            }
            node = start;
            while (node.nextNode != null)
            {
                node = node.nextNode;
            }
            node.nextNode = temp;
        }

        public void CreateLinkedList()
        {
            int i;
            int numberOfNodes;
            char data;
            Console.Write("Enter the number of nodes: ");
            numberOfNodes = int.Parse(Console.ReadLine());
            if (numberOfNodes == 0)
            {
                return;
            }
            for (i = 1; i <= numberOfNodes; i++)
            {
                Console.WriteLine("Enter the element to be inserted: ");
                data = Convert.ToChar(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void InsertAfter(char data, int nodePosition)
        {
            Node node = start;
            while (node != null)
            {
                if (node.data == nodePosition)
                {
                    break;
                }
                node = node.nextNode;
            }
            if (node == null)
            {
                Console.WriteLine($"{data} is not in the linked list");
            }
            else
            {
                Node temp = new Node(data);
                temp.nextNode = node.nextNode;
                node.nextNode = temp;
            }
        }

        public void InsertBefore(char data, int nodePosition)
        {
            Node temp;
            if (start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (nodePosition == start.data)
            {
                temp = new Node(data);
                temp.nextNode = start;
                start = temp;
                return;
            }
            Node node = start;
            while (node.nextNode != null)
            {
                if (node.nextNode.data == nodePosition)
                {
                    break;
                }
                node = node.nextNode;
            }
            if (node.nextNode == null)
            {
                Console.WriteLine($"{nodePosition} is not present in the Linked List");
            }
            else
            {
                temp = new Node(data);
                temp.nextNode = node.nextNode;
                node.nextNode = temp;
            }
        }

        public void Insert(int startIndex, string stringToInsert)
        {
            char charToInsert = Convert.ToChar(stringToInsert);
            Node temp;
            int i;
            if (startIndex == 1)
            {
                temp = new Node(charToInsert);
                temp.nextNode = start;
                start = temp;
                return;
            }
            Node node = start;
            for (i = 1; i < startIndex && node != null; i++)
            {
                node = node.nextNode;
            }
            if (node == null)
            {
                Console.WriteLine($"You can insert only up to {i}th position");
            }
            else
            {
                temp = new Node(charToInsert);
                temp.nextNode = node.nextNode;
                node.nextNode = temp;
            }
        }

        public void RemoveFirstNode()
        {
            if (start == null)
            {
                Console.WriteLine("Linked List is empty\n");
                return;
            }
            start = start.nextNode;
        }

        public void RemoveLastNode()
        {
            if (start == null)
            {
                Console.WriteLine("Linked List is empty\n");
                return;
            }
            if (start.nextNode == null)
            {
                start = null;
                return;
            }
            Node node = start;
            while (node.nextNode.nextNode != null)
            {
                node = node.nextNode;
            }
            node.nextNode = null;
        }

        public void RemoveNodeByValue(char charToRemove)
        {
            if (start == null)
            {
                Console.WriteLine("Linked List is empty\n");
                return;
            }
            if (start.data == charToRemove)
            {
                start = start.nextNode;
                return;
            }
            Node node = start;
            while (node.nextNode != null)
            {
                if (node.nextNode.data == charToRemove)
                {
                    break;
                }
                node = node.nextNode;
            }
            if (node.nextNode == null)
            {
                Console.WriteLine($"Element {charToRemove} is not in the linked list");
            }
            else
            {
                node.nextNode = node.nextNode.nextNode;
            }
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            if (start == null)
            {
                Console.WriteLine("Linked List is empty\n");
                return;
            }
            Node node = start;
            if (startIndex == 1)
            {
                for (int i = 0; i < numCharsToRemove && node != null; i++)
                {
                    start = node.nextNode;
                    node.nextNode = node.nextNode.nextNode;
                }
            }
            else
            {
                for (int i = 0; i < numCharsToRemove && node != null; i++)
                {
                    node.nextNode = node.nextNode.nextNode;
                }
            }
        }

        public int Lenght()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListContestants
{
    public class ContestantLinkedList
    {
        private Node<Contestant> head;

        public ContestantLinkedList()
        {
            head = null;
        }

        // Add a new contestant to the linked list
        public void AddContestant(Contestant contestant)
        {
            // Check if the contestant with the same unique number already exists
            if (SearchByUniqueNumber(contestant.UniqueNumber) != null)
            {
                Console.WriteLine($"Error: Contestant with unique number {contestant.UniqueNumber} already exists!");
                return;
            }

            Node<Contestant> newNode = new Node<Contestant>(contestant);

            // If the list is empty or the new contestant should be at the beginning (sorted by unique number)
            if (head == null || head.data.UniqueNumber > contestant.UniqueNumber)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                // Find the appropriate position to insert
                Node<Contestant> current = head;
                while (current.next != null && current.next.data.UniqueNumber < contestant.UniqueNumber)
                {
                    current = current.next;
                }

                newNode.next = current.next;
                current.next = newNode;
            }

            Console.WriteLine($"Added contestant: {contestant}");
        }

        // Delete a contestant by unique number
        public bool DeleteContestant(int uniqueNumber)
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty. No contestant to delete.");
                return false;
            }

            // If the head is the node to delete
            if (head.data.UniqueNumber == uniqueNumber)
            {
                head = head.next;
                Console.WriteLine($"Contestant with unique number {uniqueNumber} has been deleted.");
                return true;
            }

            // Search for the node to delete
            Node<Contestant> current = head;
            Node<Contestant> previous = null;

            while (current != null && current.data.UniqueNumber != uniqueNumber)
            {
                previous = current;
                current = current.next;
            }

            // If contestant not found
            if (current == null)
            {
                Console.WriteLine($"Contestant with unique number {uniqueNumber} not found.");
                return false;
            }

            // Remove the contestant
            previous.next = current.next;
            Console.WriteLine($"Contestant with unique number {uniqueNumber} has been deleted.");
            return true;
        }

        // Search for a contestant by unique number
        public Contestant SearchByUniqueNumber(int uniqueNumber)
        {
            Node<Contestant> current = head;

            while (current != null)
            {
                if (current.data.UniqueNumber == uniqueNumber)
                {
                    return current.data;
                }
                current = current.next;
            }

            return null; // Not found
        }

        // Display all contestants and their results
        public void ShowAllContestants()
        {
            if (head == null)
            {
                Console.WriteLine("No contestants in the list.");
                return;
            }

            Console.WriteLine("\n=== COMPETITION RESULTS ===");
            Node<Contestant> current = head;
            int position = 1;

            while (current != null)
            {
                Console.WriteLine($"{position}. {current.data}");
                current = current.next;
                position++;
            }
            Console.WriteLine("==========================\n");
        }

        // Sort contestants by result (highest to lowest)
        public void SortByResult()
        {
            if (head == null || head.next == null)
            {
                return; // Nothing to sort
            }

            // Convert linked list to array for easier sorting
            List<Contestant> contestants = new List<Contestant>();
            Node<Contestant> current = head;

            while (current != null)
            {
                contestants.Add(current.data);
                current = current.next;
            }

            // Sort by result (descending)
            contestants.Sort((a, b) => b.Results.CompareTo(a.Results));

            // Rebuild the linked list
            head = null;
            foreach (var contestant in contestants)
            {
                Node<Contestant> newNode = new Node<Contestant>(contestant);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = newNode;
                }
            }

            Console.WriteLine("Contestants sorted by result (highest to lowest).");
        }
    }
}

using System;

namespace AlgorithmsAndDataStructures
{ 
    public class Request
    {
        public string Data { get; }
        public DateTime Timestamp { get; }
        public int ID { get; }
        private static int nextID = 1;

        public Request(string data)
        {
            Data = data;
            Timestamp = DateTime.Now;
            ID = nextID++;
        }

        public override string ToString()
        {
            return $"Request {ID}: \"{Data}\" (създадена в {Timestamp:HH:mm:ss})";
        }
    }
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> next { get; set; }
        public Node(T d)
        {
            this.data = d;
            this.next = null;
        }
    }
    public class Queue<T>
    {
        private Node<T> head; 
        private Node<T> tail; 
        public int Count { get; private set; }

        public Queue()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }

            Count++;
        }
        public T Dequeue()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Опашката е празна");
            }

            T data = head.data;

            head = head.next;

            if (head == null)
            {
                tail = null;
            }

            Count--;
            return data;
        }

        public T Peek()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Опашката е празна");
            }

            return head.data;
        }
        public void ForEach(Action<T> action)
        {
            Node<T> current = head;
            while (current != null)
            {
                action(current.data);
                current = current.next;
            }
        }
    }
    public class Stack<T>
    {
        private Node<T> top;
        public int Count { get; private set; }

        public Stack()
        {
            top = null;
            Count = 0;
        }
        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (top == null)
            {
                top = newNode;
            }
            else
            {
                newNode.next = top;
                top = newNode;
            }

            Count++;
        }
        public T Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Стекът е празен");
            }

            T data = top.data;
            top = top.next;

            Count--;
            return data;
        }
        public T Peek()
        {
            if (top == null)
            {
                throw new InvalidOperationException("Стекът е празен");
            }

            return top.data;
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];
            Node<T> current = top;
            for (int i = 0; i < Count; i++)
            {
                array[i] = current.data;
                current = current.next;
            }
            return array;
        }
    }
    public class List<T>
    {
        private Node<T> head;
        public int Count { get; private set; }

        public List()
        {
            head = null;
            Count = 0;
        }
        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }

            Count++;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException("Невалиден индекс");
            }

            if (index == 0)
            {
                head = head.next;
            }
            else
            {
                Node<T> current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.next;
                }
                current.next = current.next.next;
            }

            Count--;
        }
        public T Get(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException("Невалиден индекс");
            }

            Node<T> current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }

            return current.data;
        }
        public void ForEach(Action<T> action)
        {
            Node<T> current = head;
            while (current != null)
            {
                action(current.data);
                current = current.next;
            }
        }
    }
    public class ServerSimulator
    {
        private Queue<Request> requestQueue;      
        private Stack<Request> processedStack;    
        private List<Request> requestHistory; 

        public ServerSimulator()
        {
            requestQueue = new Queue<Request>();
            processedStack = new Stack<Request>();
            requestHistory = new List<Request>();

            Console.WriteLine("Създаден е нов сървър със следните структури от данни:");
            Console.WriteLine(" - Queue<Request> за входящи заявки");
            Console.WriteLine(" - Stack<Request> за последно обработени заявки (undo буфер)");
            Console.WriteLine(" - List<Request> за история на всички обработени заявки");
        }
        public void Add(string data)
        {
            Request request = new Request(data);
            requestQueue.Enqueue(request);
            Console.WriteLine($"ADD: Добавена е нова заявка в опашката: {request}");
            Console.WriteLine($"Текущ размер на опашката: {requestQueue.Count}");
        }

        public void Process()
        {
            if (requestQueue.Count == 0)
            {
                Console.WriteLine("PROCESS: Няма заявки в опашката за обработка!");
                return;
            }

            Request request = requestQueue.Dequeue();
            processedStack.Push(request);
            requestHistory.Add(request);

            Console.WriteLine($"PROCESS: Обработена е заявка: {request}");
            Console.WriteLine($"Текущ размер на опашката: {requestQueue.Count}");
            Console.WriteLine($"Текущ размер на стека: {processedStack.Count}");
            Console.WriteLine($"Текущ размер на историята: {requestHistory.Count}");
        }
        public void Undo()
        {
            if (processedStack.Count == 0)
            {
                Console.WriteLine("UNDO: Няма обработени заявки, които могат да бъдат отменени!");
                return;
            }

            Request request = processedStack.Pop();
            requestHistory.RemoveAt(requestHistory.Count - 1);

            Console.WriteLine($"UNDO: Отменена е заявка: {request}");
            Console.WriteLine($"Текущ размер на стека: {processedStack.Count}");
            Console.WriteLine($"Текущ размер на историята: {requestHistory.Count}");
        }

        public void History()
        {
            if (requestHistory.Count == 0)
            {
                Console.WriteLine("HISTORY: Няма история на обработени заявки!");
                return;
            }

            Console.WriteLine("HISTORY: История на обработените заявки:");
            for (int i = 0; i < requestHistory.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {requestHistory.Get(i)}");
            }
        }

        public void ShowQueue()
        {
            if (requestQueue.Count == 0)
            {
                Console.WriteLine("QUEUE: Опашката е празна!");
                return;
            }

            Console.WriteLine("QUEUE: Текущо състояние на опашката (първата заявка ще бъде обработена първа):");
            int index = 1;
            requestQueue.ForEach(request => {
                Console.WriteLine($"  {index++}. {request}");
            });
        }
        public void ShowStack()
        {
            if (processedStack.Count == 0)
            {
                Console.WriteLine("STACK: Стекът е празен!");
                return;
            }

            Console.WriteLine("STACK: Текущо състояние на стека (последната заявка ще бъде отменена първа):");

            Request[] stackArray = processedStack.ToArray();
            for (int i = 0; i < stackArray.Length; i++)
            {
                Console.WriteLine($"  {i + 1}. {stackArray[i]}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ServerSimulator server = new ServerSimulator();
            bool running = true;

            Console.WriteLine("\n=== Симулация на сървър с генерични структури от данни ===");
            Console.WriteLine("Налични команди:");
            Console.WriteLine("  ADD <данни>  - Добавя нова заявка към опашката");
            Console.WriteLine("  PROCESS      - Обработва първата заявка от опашката");
            Console.WriteLine("  UNDO         - Отменя последната обработена заявка");
            Console.WriteLine("  HISTORY      - Показва всички обработени заявки");
            Console.WriteLine("  QUEUE        - Показва текущата опашка от заявки");
            Console.WriteLine("  STACK        - Показва текущия стек от обработени заявки");
            Console.WriteLine("  EXIT         - Изход от програмата");
            Console.WriteLine("===========================================================");

            while (running)
            {
                Console.Write("\nВъведете команда> ");
                string input = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(input))
                    continue;

                string[] parts = input.Split(new[] { ' ' }, 2);
                string command = parts[0].ToUpper();

                try
                {
                    switch (command)
                    {
                        case "ADD":
                            if (parts.Length < 2 || string.IsNullOrEmpty(parts[1]))
                            {
                                Console.WriteLine("Грешка: Моля, въведете данни за заявката (ADD <данни>)");
                            }
                            else
                            {
                                server.Add(parts[1]);
                            }
                            break;

                        case "PROCESS":
                            server.Process();
                            break;

                        case "UNDO":
                            server.Undo();
                            break;

                        case "HISTORY":
                            server.History();
                            break;

                        case "QUEUE":
                            server.ShowQueue();
                            break;

                        case "STACK":
                            server.ShowStack();
                            break;

                        case "EXIT":
                            running = false;
                            Console.WriteLine("Изход от програмата...");
                            break;

                        default:
                            Console.WriteLine("Непозната команда. Възможни команди: ADD, PROCESS, UNDO, HISTORY, QUEUE, STACK, EXIT");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Грешка при изпълнение на командата: {ex.Message}");
                }
            }
        }
    }
}

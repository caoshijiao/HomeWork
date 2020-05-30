using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{

    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            Node<T> n = this.head;
            while (n != null)
            {
                action(n.Data);
                n = n.Next;
            }
        }
        public delegate T FuncTwo(T x, T y);
        public T FuncExVal(FuncTwo funcTwo, T exVal)
        {
            Node<T> n = this.head;
            while (n != null)
            {
                exVal = funcTwo(n.Data, exVal);
                n = n.Next;
            }
            return exVal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            intlist.ForEach(x => Console.Write(x));
            Console.WriteLine();
            Console.WriteLine($"total:{intlist.FuncExVal((x, y) => x + y, 0)}");
            Console.WriteLine($"max:{intlist.FuncExVal((x, y) => x > y ? x : y, int.MinValue)}");
            Console.WriteLine($"min:{intlist.FuncExVal((x, y) => x < y ? x : y, int.MaxValue)}");
            for (Node<int> node = intlist.Head;
                  node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }

            // 字符串型List
            GenericList<string> strList = new GenericList<string>();
            for (int x = 0; x < 10; x++)
            {
                strList.Add("str" + x);
            }
            for (Node<string> node = strList.Head;
                    node != null; node = node.Next)
            {
                Console.WriteLine(node.Data);
            }


        }

    }
}

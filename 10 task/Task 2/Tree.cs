using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_10
{
    class Tree:Form1
    {
        public Point root = null; //корень

        public Tree(params  int[] arr)
        {
            root = new Point(arr[0]);//первый элемент
            for (int i = 1; i < arr.Length; i++)
            {
                Add(root, arr[i]);
            }

        }

        public static void Add(Point  root, int d)
        {
            Point  p = root;
            Point r = null;
            bool ok = false;
            while (p != null && !ok)
            {
                r = p;
                if (d.CompareTo(p.data) == 0) ok = true;
                else
               if (d.CompareTo(p.data) < 0) p = p.Left;
                else p = p.Right;
            }
            if (ok) return;
            Point  NewPoint = new Point (d);
            if (d.CompareTo(r.data) < 0) r.Left = NewPoint;
            else r.Right = NewPoint;
            //  return NewPoint;
        }
        public void Run(out int level, out List<Point> list)
        {
            level = 1;
            Queue<Point> current = new Queue<Point>();
            list = new List<Point>();
            root.Level = level;
            current.Enqueue(root);              //добавить в очередь 
            while (current.Count != 0)          //пока очередь не пустая
            {
                Point x = current.Dequeue();    //взять первый элемент из очереди 
                list.Add(x);                    // добавить в лист 
                if (x.Left != null)             //если существует левый элемент
                {
                    x.Left.Level = x.Level + 1; //увеличиваем уровень
                    if (x.Left.Level > level)   
                        level = x.Left.Level;   //сдвигаем текущий уровень если все элементы уже 
                    current.Enqueue(x.Left);
                }
                if (x.Right != null)
                {
                    x.Right.Level = x.Level + 1;
                    if (x.Right.Level > level)
                        level = x.Right.Level;
               
                    current.Enqueue(x.Right);
                }
            }
            
        }
    }
}

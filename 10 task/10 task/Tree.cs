using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_task
{
    class Tree
    {
        public Point  root = null; //корень

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
        public void Run()
        {
            int level = 1;
            Queue<Point > current = new Queue<Point>();
            List<Point > list = new List<Point>();
            root.Level = level;
            current.Enqueue(root);
            while (current.Count != 0)
            {
                Point x = current.Dequeue();
                list.Add(x);
                if (x.Left != null)
                {
                    x.Left.Level = x.Level + 1;
                    if (x.Left.Level > level)
                        level = x.Left.Level;
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
            Console.WriteLine("Количество уровней: " + level);
            for (int i = 1; i <= level; i++)
            {
                int num = (from c in list select c).Where(c => c.Level == i).Count();
                Console.WriteLine($"Количество элементов на {i}-м ярусе: " + num);
            }
        }
    }
}

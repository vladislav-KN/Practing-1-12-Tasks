using System;

namespace _10_task
{
    public class Point 
    {
        public int data;
        public Point  Left { get; set; }
        public Point  Right { get; set; }
        public int Level;
        public Point()
        {
            data = default;
            Left = null;
            Right = null;
        }

        public Point(int d)
        {
            data = d;
            Left = null;
            Right = null;

        }

        public override string ToString()
        {
            return data.ToString() + " ";
        }
    }
}
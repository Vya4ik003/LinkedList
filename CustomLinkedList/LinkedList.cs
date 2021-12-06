using System;
using System.Collections;

namespace CustomLinkedList
{
    class LinkedList
    {
        private Point[] _points;
        private PointEnumerator _enumerator;

        public LinkedList(int size)
        {
            _points = new Point[size];
            _enumerator = new PointEnumerator(ref _points);
        }

        public void Add(Point item)
        {
            _enumerator.Move();
            _enumerator.Current = item;
        }

        public void Test()
        {
            _enumerator.Move();
            Console.WriteLine($"{_enumerator.Current.Value}");
        }

        public void Remove(Point item)
        {
            for (int i = 0; i < _points.Length - 1; i++)
            {
                Point point = _points[i];
                if (point == item)
                {
                    _points[i] = null;
                    return;
                }
            }
        }

        public void RemoveAt(int index)
        {
            if (index > 0 && index < _points.Length)
                _points[index] = null;
        }

        public Point this[int index]
        {
            get
            {
                return _points[index];
            }
            set
            {
                _points[index] = value;
            }
        }
    }
}

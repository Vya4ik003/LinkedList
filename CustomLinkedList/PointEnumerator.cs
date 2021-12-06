namespace CustomLinkedList
{
    class PointEnumerator
    {
        private Point[] _array;
        private int _index = -1;
        public Point Current
        {
            get
            {
                return _array[_index];
            }
            set
            {
                ref Point point = ref _array[_index];
                point = value;
                point.PrevIndex = GetPrevious();
                point.NextIndex = GetNext();
            }
        }

        public PointEnumerator(ref Point[] array)
        {
            _array = array;
        }

        public void Move()
        {
            _index++;
            if (_index > _array.Length - 1)
                _index = 0;
        }

        private int GetPrevious()
        {
            if (_index > 0)
                return _index - 1;
            return _array.Length - 1;
        }

        private int GetNext()
        {
            if (_index < _array.Length - 1)
                return _index + 1;
            return 0;
        }
    }
}

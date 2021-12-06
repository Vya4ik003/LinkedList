namespace CustomLinkedList
{
    class Point
    {

        public int PrevIndex { private get; set; }
        public Point PrevPoint
        {
            get
            {
                return Program.List[PrevIndex];
            }
        }

        public int Value { get; set; }
        public int NextIndex { private get; set; }
        public Point NextPoint
        {
            get
            {
                return Program.List[NextIndex];
            }
        }

        public Point()
        {
            Value = 0;
        }

        public Point(int value)
        {
            Value = value;
        }
    }
}

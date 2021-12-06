using System;

namespace CustomLinkedList
{
    class Program
    {
        public static LinkedList List;

        static void Main(string[] args)
        {
            List = new LinkedList(10);
            
            for (int i = 0; i < 10; i++)
            {
                List.Add(new Point(i));
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{List[i].PrevPoint.Value} – {List[i].Value} – {List[i].NextPoint.Value}");
            }
        }
    }
}

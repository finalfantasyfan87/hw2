using System;
using System.Reflection.Metadata.Ecma335;

namespace HW2
{
    public class SeLinkList
    {
        private static int indexCounter = 0;
        public SeLinkList prev;
        public SeLinkList next;
        private int a;
        private int b;
        private int c;
        private int index;

        public SeLinkList()
        {
            prev = null;
            next = null;
            a = 0;
            b = 0;
            c = 0;
            index = indexCounter;
            indexCounter++;
        }

        public SeLinkList(int _a, int _b, int _c)
        {
            next = null;
            prev = null;
            a = _a;
            b = _b;
            c = _c;
            index = indexCounter;
            indexCounter++;
        }

        public int getWeight()
        {
            return a + b + c;
        }

        public int Index
        {
            get { return index; }
        }

        public void print()
        {
            Console.WriteLine("player {0}"+index);
        }
    }
  
}
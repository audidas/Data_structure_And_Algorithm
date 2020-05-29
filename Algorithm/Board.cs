using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{


    public class Board
    {
        public int[] _data = new int[25]; // 배열

        public LinkedList<int> _data3 = new LinkedList<int>(); // 연결 리스트


        public void Initialize()
        {

            _data3.AddLast(101);
            _data3.AddLast(102);
            LinkedListNode<int> node = _data3.AddLast(103);
            _data3.AddLast(104);
            _data3.AddLast(105);

            _data3.Remove(node);
        }
    }

}
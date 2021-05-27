using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osAndXs
{
    class OsAndXs
    {
        private Board board;
        private int turn;
        public OsAndXs()
        {
            board = new Board();
            turn = 1;
        }

        public bool addCounter(int pos)
        {
            bool added = false;
            added = board.addCounter(pos, turn);
            if (added == true) 
            { 
                if (turn == 1)
                {
                    turn = 2;
                } else turn = 1;
            }
            return added; ;
        }

        public Board getBoard()
        {
            return board;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Node
    {
        //public int flag = 0;
        char[] mark;
        public char[] Mark
        {
            get
            {
                if (mark == null)
                    mark = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                return mark;
            }
            set { mark = value; }
        }

        int player;
        public int Player
        {
            get
            {
                if (player.ToString() == null)
                    player = 1;
                return player;
            }
            set { player = value; }
        }


        

    }
}

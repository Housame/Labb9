using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Game
{
    class Counter
    {
        public event EventHandler WinMessage;
        public int WinWin { get; set; }

        public virtual void OnWinnigHappend(object sender, EventArgs e)
        {
            EventHandler handler = WinMessage;
            if (handler != null)
            {
                handler(sender, e);
            }

        }

        public event EventHandler DrawMessage;
        public int DrawDraw { get; set; }

        public virtual void OnDrawHappend(object sender, EventArgs e)
        {
            EventHandler handler = DrawMessage;
            if (handler != null)
            {
                handler(sender, e);
            }

        }
    }
}

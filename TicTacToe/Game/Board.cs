using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe.Game
{
    class Board : IBoard
    {
        public Node Grid { get; set; }

        public void PlaceMarker(int choice, char[] arr, int player)
        {
            GUI gui = new GUI();
            // checking that position where player want to run is marked (with X or O) or not
            if (arr[choice] != 'X' && arr[choice] != 'O')
            {
                if (player % 2 == 0) //if chance is of player 2 then mark O else mark X  
                {
                    arr[choice] = 'O';
                }
                else
                {
                    arr[choice] = 'X';
                }
                    
            }
            else //If there is any possition where user want to run and that is already marked then show message and load board again  
            {
                gui.ErrorMessage(choice,arr[choice]);
            }
            
            Runtime.flag = Runtime.CheckWin(arr);// calling of check win  
           
        }
    }
}

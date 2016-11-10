using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TicTacToe.Game;

namespace TicTacToe
{
    class Runtime
    {
        IBoard board = new Board();
        GUI gui = new GUI();
        int choice;
        public static int flag { get; set; } = 0;

        public void Start()
        {
            Node grid = new Node();
            int player = grid.Player = 1;
            char[] mark = grid.Mark;
            
            do
            {
                Console.Clear();
                GraficGrid(mark,player);
                choice = gui.TakeChoice();
                board.PlaceMarker(choice, mark, player);// calling the PlaceMarker Function  
                player++;
                Console.ResetColor();
            } while (flag != 1 && flag != -1);// This loop will be run until all cell of the grid is not marked with X and O or some player is not win
            GameOver(mark,flag,player);
        }




        void GraficGrid(char[] mark, int player)
        {
            gui.PlayerTurn(player);
            gui.GraficGrid(mark);
        }

        public static int CheckWin(char[] arr)
        {

            #region Horzontal Winning Condtion
            //Winning Condition For First Row   
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row   
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row   
            else if (arr[7] == arr[8] && arr[8] == arr[9])
            {
                return 1;
            }
            #endregion

            #region vertical Winning Condtion
            //Winning Condition For First Column       
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column  
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column  
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion

            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion

            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match  
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion

            else
            {
                return 0;
            }
        }

        void GameOver(char[] arr, int flag, int player)
        {
            Console.Clear();// clearing the console  
            if (flag==1)
            {                
                gui.PlayerWin(arr, player);
                gui.BackOrExit();
            }

            else// if flag value is -1 the match will be draw and no one is winner  
            {
                gui.PlayerDraw(arr, player);
                gui.BackOrExit();
            }
            Console.ReadLine();

        }

        
        

        

        
    }
}


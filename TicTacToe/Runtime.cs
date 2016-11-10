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
        public static int flag = 0;

        public void Start()
        {
            Node grid = new Node();
            int player = grid.Player=1;
            char[] mark = grid.Mark;

            do
            {
                Console.Clear();
                
                gui.PlayerTurn(player);
                gui.GraficGrid(mark);
                choice = TakeChoice();
                board.PlaceMarker(choice, mark, player);// calling the PlaceMarker Function  
                player++;
                Console.ResetColor();
            } while (flag != 1 && flag != -1);// This loop will be run until all cell of the grid is not marked with X and O or some player is not win
            GameOver(mark,flag,player);
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
              

            if (flag == 1)// if flag value is 1 then someone won or means who played marked last time which has win  
            {
                gui.PlayerWin(arr,player);
            }
            else// if flag value is -1 the match will be draw and no one is winner  
            {
                gui.PlayerDraw(arr, player);
                
            }
            Console.ReadLine();

        }


        int TakeChoice()//Taking users choice 
        {

            int x = 0;
            bool loop = true;
            while (loop)
            {
               string input = Console.ReadLine();
                if (input == "1")
                { 
                    x = Convert.ToInt16(input);
                    loop = false;
                }
                if (input == "2")
                {
                    x = Convert.ToInt16(input);
                    loop = false;
                }
                if (input == "3")
                {
                    x = Convert.ToInt16(input);
                    loop = false;
                }
                if (input == "4")
                {
                    x = Convert.ToInt16(input);
                    loop = false;
                }
                if (input == "5")
                {
                    x = Convert.ToInt16(input);
                    loop = false;
                }
                if (input == "6")
                {
                    x = Convert.ToInt16(input);
                    loop = false;
                }
                if (input == "7")
                {
                    x = Convert.ToInt16(input);
                    loop = false;
                }
                if (input == "8")
                {
                    x = Convert.ToInt16(input);
                    loop = false;
                }
                if (input == "9")
                {
                    x = Convert.ToInt16(input);
                    loop = false;
                }
                else
                    Console.WriteLine("Choose between 1-9");
                Thread.Sleep(1200);
                    ClearOneLine();
                ClearOneLine();
            }

            #region switch
            //var input = Console.ReadKey(true).Key;
            //switch (input)
            //{
                //case ConsoleKey.NumPad1:
                //case ConsoleKey.D1:
                //    Console.WriteLine("1");
                //    x = 1;
                //    break;
                //case ConsoleKey.NumPad2:
                //case ConsoleKey.D2:
                //    Console.WriteLine("2");
                //    x = 2;
                //    break;
                //case ConsoleKey.NumPad3:
                //case ConsoleKey.D3:
                //    Console.WriteLine("3");
                //    x = 3;
                //    break;
                //case ConsoleKey.NumPad4:
                //case ConsoleKey.D4:
                //    Console.WriteLine("4");
                //    x = 4;
                //    break;
                //case ConsoleKey.NumPad5:
                //case ConsoleKey.D5:
                //    Console.WriteLine("5");
                //    x = 5;
                //    break;
                //case ConsoleKey.NumPad6:
                //case ConsoleKey.D6:
                //    Console.WriteLine("6");
                //    x = 6;
                //    break;
                //case ConsoleKey.NumPad7:
                //case ConsoleKey.D7:
                //    Console.WriteLine("7");
                //    x = 7;
                //    break;
                //case ConsoleKey.NumPad8:
                //case ConsoleKey.D8:
                //    Console.WriteLine("8");
                //    x = 8;
                //    break;
                //case ConsoleKey.NumPad9:
                //case ConsoleKey.D9:
                //    Console.WriteLine("9");
                //    x = 9;
                //    break;
                //default:
                //    Console.WriteLine("Choose between 1-9 plz");
                //    break;
                #endregion
            

            return x;
        }
        void ClearOneLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

    }
}


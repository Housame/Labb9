﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        internal void Start()
        {
            Node grid = new Node();
            int player = grid.Player=1;
            char[] mark = grid.Mark;

            do
            {
                Console.Clear();// whenever loop will be again start then screen will be clear 
                
                gui.PlayerTurn(player);
                gui.GraficGrid(mark);
                choice = TakeChoice();//Taking users choice  
                board.PlaceMarker(choice, mark, player);// calling the PlaceMarker Function  
                player++;
                Console.ResetColor();
            } while (flag != 1 && flag != -1);// This loop will be run until all cell of the grid is not marked with X and O or some player is not win
            GameOver(mark,flag,player);
        }

        internal static int CheckWin(char[] arr)
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
            else if (arr[6] == arr[7] && arr[7] == arr[8])
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

        private void GameOver(char[] arr, int flag, int player)
        {
            Console.Clear();// clearing the console  
              

            if (flag == 1)// if flag value is 1 then some one has win or means who played marked last time which has win  
            {
                gui.PlayerOneWin(arr,player);
            }
            else// if flag value is -1 the match will be draw and no one is winner  
            {
                gui.PlayerTwoWin(arr, player);
                
            }
            Console.ReadLine();

        }


        private int TakeChoice()
        {
            int x = 0;
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    Console.WriteLine("1");
                    x = 1;
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Console.WriteLine("2");
                    x = 2;
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Console.WriteLine("3");
                    x = 3;
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    Console.WriteLine("4");
                    x = 4;
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    Console.WriteLine("5");
                    x = 5;
                    break;
                case ConsoleKey.NumPad6:
                case ConsoleKey.D6:
                    Console.WriteLine("6");
                    x = 6;
                    break;
                case ConsoleKey.NumPad7:
                case ConsoleKey.D7:
                    Console.WriteLine("7");
                    x = 7;
                    break;
                case ConsoleKey.NumPad8:
                case ConsoleKey.D8:
                    Console.WriteLine("8");
                    x = 8;
                    break;
                case ConsoleKey.NumPad9:
                case ConsoleKey.D9:
                    Console.WriteLine("9");
                    x = 9;
                    break;
            }
            return x;
        }
    }
}

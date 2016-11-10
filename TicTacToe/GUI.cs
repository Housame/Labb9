using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    class GUI
    {
       
        public void GraficGrid(char[] arr)
        {
            Console.WriteLine("********************");
            Console.WriteLine("*     |     |      *");
            Console.WriteLine("*  {0}  |  {1}  |  {2}   *", arr[1], arr[2], arr[3]);
            Console.WriteLine("*_____|_____|_____ *");
            Console.WriteLine("*     |     |      *");
            Console.WriteLine("*  {0}  |  {1}  |  {2}   *", arr[4], arr[5], arr[6]);
            Console.WriteLine("*_____|_____|_____ *");
            Console.WriteLine("*     |     |      *");
            Console.WriteLine("*  {0}  |  {1}  |  {2}   *", arr[7], arr[8], arr[9]);
            Console.WriteLine("*     |     |      *");
            Console.WriteLine("********************");
        }

        public void PlayerTurn(int player)
        {
            GraficTopView();
            if (player % 2 == 1)//checking the chance of the player  
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Player 1 Chance");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Player 2 Chance");
            }
            Console.WriteLine("\n");
        }

        private void GraficTopView()
        {
            Console.WriteLine("*****************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Player1: X ");
            Console.ResetColor();
            Console.Write("******");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Player2: O");
            Console.ResetColor();
            Console.WriteLine("*****************************\n");
        }

        internal void ErrorMessage(int choice, char arr)
        {
            Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr);
            Console.WriteLine("\n");
            Console.WriteLine("Please wait 2 second board is loading again.....");
            Thread.Sleep(2000);
        }

        internal void PlayerWin(char[] arr, int player)
        {
            if ((player % 2) + 1 == 1)
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                GraficGrid(arr);// getting filled board again
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Player {0} has won", (player % 2) + 1);
                    Thread.Sleep(700);
                    ClearOneLine();
                    Thread.Sleep(500);
                }
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
                Thread.Sleep(200);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                GraficGrid(arr);// getting filled board again
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Player {0} has won", (player % 2) + 1);
                    Thread.Sleep(700);
                    ClearOneLine();
                    Thread.Sleep(500);
                }
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
                Thread.Sleep(200);
                Console.ResetColor();
            }
        }

        internal void PlayerDraw(char[] arr, int player)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            GraficGrid(arr);// getting filled board again
            Console.WriteLine("Draw");
            Console.ResetColor();
        }

        internal void BackOrExit()
        {
            var runtime = new Runtime();
            Console.WriteLine("***************************");
            Console.WriteLine("*   1. Start Game again   *");
            Console.WriteLine("*   2. Exit               *");
            Console.WriteLine("***************************");
            var input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    runtime.Start();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Environment.Exit(0);
                    break;
            }
        }

        public int TakeChoice()//Taking users choice 
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
                Thread.Sleep(1000);
                ClearOneLine();
                ClearOneLine();
            }

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

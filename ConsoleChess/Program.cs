using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            string[] board = p.SetBoard();
            p.PrintBoard(ref board);
            Console.ReadLine();

        }

        string[] Player1Move(ref string[] board)
        {
            string userInput1;
            string userInput2;
            Console.WriteLine("Please give me Row then Colum of the Token you would like to move");

            return board;
        }



        // 64 element array to store player pos
        // Array will work by printing left to right top to bottom
        // Any empty element will mean nothing in there
        // Possible elements are
        // R, H, B, K, Q, B, H, R
        // p, p, p, p, p, p, p, p
        //
        //
        //
        //
        // p, p, p, p, p, p, p, p
        // R, H, B, K, Q, B, H, R
        string[] SetBoard()
        {
            string[] board = new string[] {"R", "H", "B", "K", "Q", "B", "H", "R", "p", "p", "p", "p", "p", "p", "p", "p", "'", "'", "'", "'",
            "'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","'","p","p","p",
            "p","p","p","p","p","R","H","B","K","Q","B","H","R"};
            return board;
        }
        /// <summary>
        /// Takes an array and prints it out onto screen top left to bottom right
        /// </summary>
        /// <param name="boardPos">Array of 64 elements to be printed</param>
        void PrintBoard(ref string[] boardPos)
        {
            int i = 8;
            int currentPosToBePrinted = 0;
            while (i >= 0)
            {
                
                if (i == 0)
                {
                    Console.WriteLine("    A   B   C   D   E   F   G   H");
                }
                else
                {
                    Console.Write("{0}   ", i);
                    for (int colum = 0; colum < 8; colum++)
                    {
                        Console.Write("{0}   ",boardPos[currentPosToBePrinted]);
                        currentPosToBePrinted ++;
                    }
                    Console.WriteLine("\n");
                }
                i -= 1;
            }
        }
    }
}

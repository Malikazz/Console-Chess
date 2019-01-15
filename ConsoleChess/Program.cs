using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace ConsoleChess
{
    class Program
    {
        string[] validColInputs = new string[] {"a", "b", "c", "d", "e", "f", "g", "h"};
        string[] validRowInputs = new string[] {"1", "2", "3", "4", "5", "6", "7","8"};

        static void Main(string[] args)
        {
            Program p = new Program();

            string[] board = p.SetBoard();
            p.PrintBoard(ref board);
            p.Player1Move(ref board, p.validColInputs, p.validRowInputs);
            Console.ReadLine();
            
        }

        string[] Player1Move(ref string[] board, string[] validColInputs, string[] validRowInputs)
        {
            string userInput;
            Console.Write("COL then ROW to select: ");
            userInput = Console.ReadLine().ToLower();
            if (userInput.Length > 2)
            { 
                userInput = userInput.Remove(2);
                Console.WriteLine(userInput);
            }
            for (int i = 0; i < validColInputs.Length; i++)
            {
                if (userInput.Contains(validColInputs[i]))
                {
                    Console.WriteLine("{0}",userInput[0]);
                }
            }
            for (int i = 0; i < validRowInputs.Length; i++)
            {
                if (userInput.Contains(validColInputs[i]))
                {
                    Console.WriteLine("{0}", userInput[1]);
                }
            }
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

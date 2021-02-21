using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TicTacToe
{
   public class Board
    {

      public  char[] place = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        CheckWinner w = new CheckWinner();

        public char[] updatedArray()
        {
            return place;
        }

        public void Update(int a, char b)
        {
            place[a - 1] = b;

            Thread.Sleep(100);

           
           
        }

        

        public void Board1()
        {

            
            Console.WriteLine("Loading Board");
            Console.WriteLine("                  |                 |                  ");
            Console.WriteLine("        {0}         |        {1}        |       {2}        ", place[0], place[1], place[2]);
            Console.WriteLine(" _________________|_________________|_________________ ");
            Console.WriteLine("                  |                 |                  ");
            Console.WriteLine("        {0}         |        {1}        |       {2}        ", place[3], place[4], place[5]);
            Console.WriteLine(" _________________|_________________|_________________ ");
            Console.WriteLine("                  |                 |                  ");
            Console.WriteLine("        {0}         |        {1}        |       {2}        ", place[6], place[7], place[8]);
            Console.WriteLine("                  |                 |                  ");
           


        }

      

        internal static void update(int choice, char v)
        {
            throw new NotImplementedException();
        }
    }
}

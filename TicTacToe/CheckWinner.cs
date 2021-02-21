using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TicTacToe
{
    class CheckWinner
    {
    
        public char Check(char[] a)
        {

           // Console.WriteLine("Hii");

          
            Thread.Sleep(1000);
            // Checking 1st  horizontal Line:
            if (a[0] == a[1] && a[1] == a[2])
            {
                return a[0];
            }
            // Checking 2nd  horizontal Line:
            else if (a[3] == a[4] && a[4] == a[5])
            {
                return a[3];
            }
            // Checking 3rd  horizontal Line:
            else if (a[6] == a[7] && a[7] == a[8])
            {
                return a[6];
            }
            // Checking 1st vertical Line:
            else if (a[0] == a[3] && a[3] == a[6])
            {
                return a[0];
            }
            // Checking 2nd vertical Line:

            else if (a[1] == a[4] && a[4] == a[7])
            {
                return a[1];
            }
            // Checking 3rd vertical Line:
            else if (a[2] == a[5] && a[5] == a[8])
            {
                return a[2];
            }
            //checking Diagonal (left to right )
            else if (a[0] == a[4] && a[4] == a[8])
            {
                return a[0];
            }
            // checking Diagonals (right to left)
            else if (a[2] == a[4] && a[4] == a[6])
            {
                return a[2];
            }
            else
            {
                return 'd';
            }
        }
    
    
    }
}

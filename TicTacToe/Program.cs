using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class Program
    {
      //  private static object place;
        public int flag = 0;
        
        static void Main(string[] args)
        {
            var input = new List<int> (); // List to Store users input 
            int player = 0;
           
            


            Console.WriteLine("-------------------Tic Tac Toe---------------");
            Console.WriteLine("Player 1: X  And Player 2: O");
            Board game = new Board();

            game.Board1();
            CheckWinner w = new CheckWinner();

            while (input.Count<9)
            { 
           // Console.WriteLine("enter the value");
                if (player %2 ==0)
                {
                    Console.Write(" Player 1 Chance : ");

                }
                else
                {
                    Console.Write("Player 2 Chance : ");
                }
            int choice = int.Parse(Console.ReadLine());


            if(input.Contains(choice))
                {
                    Console.WriteLine("the location is already Marked");
                }
                else
                {
                    input.Add(choice);
                    if (player % 2 == 0)
                    {
                        game.Update(choice,'x');
                        game.Board1();
                            
                        
                    }
                    else
                    {
                        game.Update(choice, 'O');
                        game.Board1();
                       
                    }
                    var result = w.Check(game.updatedArray());
                    if (result == 'x')
                    {
                        Console.WriteLine("Player 1 Wins ");
                        break;
                    }
                    else if (result == 'O')
                    {
                        Console.WriteLine("Player 2 Wins ");
                        break;
                    }
                    
                    player++;
                }



            }

            Console.WriteLine("Match Tied");
        }
    }
}

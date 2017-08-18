using CardMatch.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMatch.Model
{
    class Program
    {
        static void Main(string [] args)
        {
            //Console.WriteLine("Hola Mundo");
            Board board = new Board();
            board.printBoard();
            windowLogin init = new windowLogin();
            System.Windows.Forms.Application.Run(init);
            //init.ShowDialog();
            Console.ReadKey();
        }
    }
}

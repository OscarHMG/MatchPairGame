using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMatch.Model

{
    //Window, maybe?
    class Board
    {
        private List<Card> cardsList;
        private List<string> contents;
        private static int MAX_X = 4;
        private static int MAX_Y = 4;


        public Board()
        {
            initBoard();

        }

        public void initBoard()
        {
            cardsList = new List<Card>();
            Card card;
            createListContent();
            for (int i = 0; i<MAX_X; i ++)
            {
                for (int j = 0; j < MAX_Y; j++)
                {
                    card = new Card(i,j, null);
                    cardsList.Add(card);
                }
            }
            fillBoard();
        }

        //Create the content of the cards
        public void createListContent()
        {
            contents = new List<string>();
            for (int i = 0; i < MAX_X *2; i++)
            {
                contents.Add(""+i);
            }
        }


        public void fillBoard()
        {
            Random randomNumber = new Random();
            int posX, posY, cont = 0;
            foreach (string content in contents)
            {
                while (cont != 2)   
                {
                    posX = randomNumber.Next(MAX_X);
                    posY = randomNumber.Next(MAX_Y);
                    foreach (Card card in cardsList)
                    {

                        if (card.getPositionX() == posX && card.getPositionY() == posY ) //Here obtain the card
                        {
                            if(card.getContent() == null)
                            { 
                                card.setContent(content);
                                cont++;
                                Console.WriteLine("Content: " + content + " Position: (" +posX +"," +posY+")");
                                break; //Finish iterate board
                            }
                        }
                    }
                }
                cont = 0;
            }
        }

        public void printBoard()
        {
            string x = "";
            for (int i = 0; i<16; i++)
            {
                Card c = cardsList[i];
                if (i != 3 && i!=7 && i!=11 && i!=15)
                {
                    Console.Write(c.getContent() + " ");
                }
                else
                {
                    Console.Write(c.getContent() + "\n");
                }
            }
        }

        public void fill()
        {
            Random randomNumber = new Random();
            int posX, posY, cont = 0;
            foreach (string content in contents)
            {

            }
        }

    }
}

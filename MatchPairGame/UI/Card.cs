using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CardMatch.Model
{
    class Card : Button
    {
        //Attributes of Card (Button maybe)
        private int position_x;
        private int position_y;
        //Status: True -> Covered, False -> Discovered
        private bool status;
        private string content;
        private System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));

        public static MatchPairGame.UI.Board board;
        public static int numClicks = 0;
        


        //Constructor
        public Card(int x, int y, String content)
        {
            this.position_x = x;
            this.position_y = y;
            this.status = false;
            this.content = content;

            //Propiedades graficas del boton
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            //this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            //this.BackgroundImage = 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.FlatAppearance.BorderSize = 10;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Location = new System.Drawing.Point(75 * x, 75 * y);
            this.Name = "button"+x + "y";
            this.Size = new System.Drawing.Size(66, 60);
            this.TabIndex = x + y;
            this.UseVisualStyleBackColor = false;
            this.Text = "TAP";
            //Agrego el evento al boton para que responda cuando haga click
            this.Click += new System.EventHandler(this.clickEvent);
        }

        private void clickEvent(object sender, EventArgs e)
        {
            numClicks++;
            Console.WriteLine("Pos(" + this.position_x + "," +position_y + ") ----" + this.content + "Click: " + numClicks);
            //True. Volteada , False. Cubierta
            if (this.status == false) { 
                this.Text = this.content;
                this.status = true;
                this.Enabled = false;
            }
            else
            {
                this.status = true;
                this.Text = "TAP";
            }

            if (numClicks!=0 && numClicks%2==0)
            {
                Console.WriteLine("Click 2 veces");
                int cont = 0;
                Card[] cardsCompare = new Card[2];
                foreach (Card card in board.getCards())
                {
                    if (card.getStatus() == true)
                    {
                        cardsCompare[cont] = card;
                        cont++;
                    }
                }
                Card c1 = cardsCompare[0];
                Card c2 = cardsCompare[1];
                if (c1.getContent().Equals(c2.getContent()))
                {
                    Console.WriteLine("IGUALES");
                    hideCards(cardsCompare);

                    board.setScore();
                }
                else
                {
                    Console.WriteLine("VACIO");
                    flipCards(cardsCompare,"");
                }
            }


            Console.WriteLine("Score" + board.getScore());


        }


        //Oculta cartas cuando estan correctas
        public void hideCards(Card[] cardsCompare)
        {
            for (int i = 0; i < 2; i++)
            {
                Card c1 = cardsCompare[i];
                foreach (Card c in board.getCards())
                {
                    if (c.getPositionX() == c1.getPositionX() && c.getPositionY() == c1.getPositionY())
                    {
                        c.setStatus(false);
                        c.Enabled = false;

                    }
                }
            }
        }
        //Viro las cartas
        public void flipCards(Card[] cardsCompare, string value)
        {
            for (int i=0; i < 2; i++)
            {
                Card c1 = cardsCompare[i];
                foreach (Card c in board.getCards())
                {
                    if (c.getPositionX() == c1.getPositionX() && c.getPositionY() == c1.getPositionY())
                    {
                        c.setStatus(false);
                        c.Enabled = true;
                        c.Text = "TAP ";
                    }
                }
            }
            Thread.Sleep(2000);
        }

        //Getter, Setter: Position X
        public int getPositionX()
        {
            return this.position_x;
        }
        public void setPositionX(int x)
        {
            this.position_x = x;
        }

        //Getter, Setter: Position Y
        public int getPositionY()
        {
            return this.position_y;
        }
        public void setPositionY(int y)
        {
            this.position_y = y;
        }

        //Getter, Setter: Status
        public bool getStatus()
        {
            return this.status;
        }
        public void setStatus(bool status)
        {
            this.status = status;
        }

        //Getter, Setter: Content of the card.
        public string getContent()
        {
            return this.content;
        }
        public void setContent(string content)
        {
            this.content = content;
        }

        //toString Method

        public string toString()
        {
            return this.content;
        }


        public static void setBoard(MatchPairGame.UI.Board board)
        {
            Card.board = board;
        }
        



    }
}

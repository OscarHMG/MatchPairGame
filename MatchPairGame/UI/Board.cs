using CardMatch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchPairGame.UI
{
    class Board : Form
    {
        private TableLayoutPanel containerLayout;
        public static Card[,] listCards;
        private List<string> contents;
        private static int MAX_X = 4;
        private static int MAX_Y = 4;
        public  static int score = 0;


        public Board()
        {
            initBoard();
        }

        private void clickEvent(object sender, EventArgs e)
        {
            Console.Write(e.ToString());
        }

        public void initBoard()
        {
            listCards = new Card[MAX_X,MAX_Y];
            Card card;
            createListContent();
            for (int i = 0; i < MAX_X; i++)
            {
                for (int j = 0; j < MAX_Y; j++)
                {
                    card = new Card(i, j, null);
                    listCards[i,j] = card;
                }
            }
            fillBoard();
            initializateComponents();
            Card.board = this;
        }




        //Create the content of the cards
        public void createListContent()
        {
            contents = new List<string>();
            for (int i = 0; i < MAX_X * 2; i++)
            {
                contents.Add("" + i);
            }
        }



        public void fillBoard()
        {
            Random randomNumber = new Random();
            int posX, posY, cont = 0;
            foreach (string content in contents)
            {
                while (cont != 2)   //Pregunto si he puesta el contenido de la ficha 2 veces.
                {
                    posX = randomNumber.Next(MAX_X);
                    posY = randomNumber.Next(MAX_Y);
                    for (int i = 0; i < MAX_X; i++)
                    {
                        for (int j = 0; j < MAX_Y; j++)
                        {
                            Card card = listCards[i, j];
                            if (card.getPositionX() == posX && card.getPositionY() == posY) //Here obtain the card
                            {
                                if (card.getContent() == null)
                                {
                                    card.setContent(content);
                                    cont++;
                                    Console.WriteLine("Content: " + content + " Position: (" + posX + "," + posY + ")");
                                    break; //Finish iterate board
                                }
                            }

                        }
                    }
                }
                cont = 0;
            }

        }




        public void initializateComponents()
        {
            this.containerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.containerLayout.RowCount = 4;
            this.containerLayout.ColumnCount = 4;
            this.containerLayout.SuspendLayout();
            this.SuspendLayout();
            for (int i = 0; i < MAX_X; i++)
            {
                this.containerLayout.RowStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                for (int j = 0; j < MAX_Y; j++)
                {
                    this.containerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
                    this.containerLayout.Controls.Add(listCards[i,j], j, i);
                }
            }

            this.containerLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.containerLayout.Size = new System.Drawing.Size(300, 300);

            this.containerLayout.Location = new System.Drawing.Point(151, 63);
            this.containerLayout.Name = "containerLayout";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 387);
            this.Controls.Add(this.containerLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BoardMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoardMain";
            
            this.containerLayout.PerformLayout();
            this.PerformLayout();


        }

        public Card[,] getCards()
        {
            return listCards;
        }



        public int getScore()
        {
            return score;
        }

        public void setScore()
        {
            score = score + 10;
        }

    }
}

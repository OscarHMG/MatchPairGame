using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMatch.Model
{
    class Card
    {
        //Attributes of Card (Button maybe)
        private int position_x;
        private int position_y;
        //Status: True -> Covered, False -> Discovered
        private bool status;
        private string content;

        //Constructor
        public Card(int x, int y, String content)
        {
            this.position_x = x;
            this.position_y = y;
            this.status = false;
            this.content = content;
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



    }
}

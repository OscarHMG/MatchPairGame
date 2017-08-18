using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMatch.Model
{
    class User
    {
        private string userName;
        private string password;
        private string name;
        private string lastName;
        private DateTime birthdate;
        private string email;

        //Getter, Setter userName
        public string getUserName()
        {
            return this.userName;
        }

        public void setUserName(string userName)
        {
            this.userName = userName;
        }

        //Getter, Setter password
        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        //Getter, Setter Name
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        //Getter, Setter LastName
        public string getLastName()
        {
            return this.lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        //Getter, Setter BirthDate
        public DateTime getBirthDate()
        {
            return this.birthdate;
        }

        public void setBirthDate(DateTime birthDate)
        {
            this.birthdate = birthDate;
        }

        //Getter, Setter Email
        public string getEmail()
        {
            return this.email;
        }

        public void setEmail(string birthDate)
        {
            this.email = email;
        }



    }
}

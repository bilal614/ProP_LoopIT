using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject.Classes
{
    class GroupMember
    {
        //instance variables
        private int groupId;

        private string co_email;

        private int campResNo;

        private bool checkIn;
        //properties
        public int GroupId { get { return groupId; } }

        public string Co_Email { get { return co_email; } }

        public int CampResNo//defines a unique id for the reservation made by customers, used as primary key for entity
        { get { return campResNo; } }//read-only

        public bool CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }//should also have a setter in order to allow guests to check out and 
            //allow other guests to check-in in their place
        }
        //constructors

        //methods
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject.Classes
{
    class CampRes
    {
        //instance variables
        private int campResNo;
        private int campId;
        /*should AccountId be taken from parent class EventAccount to establish the link between the classes??
         Or should it be a separate class on its own, then how will you make the link?*/
        private DateTime startDate;
        private DateTime endDate;

        //properties
        public int CampResNo//defines a unique id for the reservation made by customers, used as primary key for entity
        { get { return campResNo; } }//read-only

        public int CampId//used to describe unique location of camp on the map of the camp
        { get { return campId; } }//read-only

        public DateTime StartDate
        {
            get { return startDate; }

            set
            {
                if (value < EndDate)
                { startDate = value; }
            }//can add restrictions to StartDate depending on circumstances such as dates of event etc.
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set
            {
                if (value > StartDate)
                { endDate = value; }
            }
        }
        //constructors
        public CampRes(int campResNo, int campID,/*int accountID,*/DateTime startDate, DateTime endDate)
        {
            this.campResNo = campResNo;
            this.campId = campID;
            //will the AccountId come from parent class EventAccount??
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
        //methods

    }
}

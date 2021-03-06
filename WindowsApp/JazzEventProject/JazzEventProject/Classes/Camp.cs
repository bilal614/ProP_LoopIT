﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JazzEventProject.Classes
{
    class Camp
    {
        //instance variables
        private int campId;
        private int maxPerson;

        //properties
        public int CampId
        { get { return campId; } }

        public string Description { get; set; }

        public int MaxPerson
        {
            get { return maxPerson; }
            set
            {
                if (value > 0 && value <= 6)//camp size cannot take more than 6 people but must be more than 0
                    maxPerson = value;
            }
        }

        public bool Available { get; set; }
        //constructors
        public Camp(int id, string desc, int size, bool available)
        {
            this.campId = id;
            this.Description = desc;
            this.MaxPerson = size;
            this.Available = available;
        }
        //methods
    }
}

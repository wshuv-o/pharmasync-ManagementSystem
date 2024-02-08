﻿using System;

namespace PharmacyManagementSystem
{
    public class PharmacistsClass
    {
        public int PhId 
        { 
            get; 
            set; 
        }
        public string PhFirstName 
        { 
            get;
            set; 
        }
        public string PhLastName 
        { 
            get; 
            set; 
        }
        public DateTime PhDob 
        { 
            get; 
            set; 
        }
        public string PhGender 
        { 
            get;
            set; 
        }
        public string PhContact 
        { 
            get; 
            set; 
        }
        public double PhSalary 
        { 
            get; 
            set; 
        }
        public string PhUsername 
        { 
            get;
            set; 
        }
        public string PhPassword 
        { 
            get; 
            set; 
        }


        public PharmacistsClass(int phId, string phFirstName, string phLastName, DateTime phDob, string phGender,
            string phContact, double phSalary, string phUsername, string phPassword)
        {
            this.PhId = phId;
            this.PhFirstName = phFirstName;
            this.PhLastName = phLastName;
            this.PhDob = phDob;
            this.PhGender = phGender;
            this.PhContact = phContact;
            this.PhSalary = phSalary;
            this.PhUsername = phUsername;
            this.PhPassword = phPassword;
        }
    }
}

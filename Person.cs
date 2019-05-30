using System;
using Project1.Properties;
///////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project1
//  File Name:      Person.cs
//  Description:    This class contains properties for person object to be instantiated by gender.
//  Course:         CSCI-2910-001 - Data Structures
//  Author:         Cory Moore, moorecs1@etsu.edu, Department of Computing, ETSU
//  Created:        Thursday, January 09, 2017
//  Copyright:      Cory Moore, 2017
//
///////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project1
{
    /// <summary>
    /// This class contains properties for person object to be instantiated by gender.
    /// </summary>
    public abstract class Person 
    {
        
        public LastName LastName { get; set; }
        public DateTime BirthDate{ get; set; }
        public CreditCard CreditCard { get; set; } 
        public Address Address { get; set; }
        public Company Company { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public InternetInfo InternetInfo { get; set; }
       /// <summary>
       /// Note that the Ssn class is stored in the PhoneNumber File-
       /// because both of these classes have only one property. 
       /// </summary>
        protected Ssn Ssn { get; set; }
        public abstract int GetAge();

        public abstract string ToString();

    }
}



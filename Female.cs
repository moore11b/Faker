using System;
using System.Reflection.Metadata;
using FakerClass;
using Project1;
using Project1.Properties;

///////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project 1  
//  File Name:      Female.cs
//  Description:    This class contains several enums of cities for various states.
//  Course:         CSCI-2910-001 - Data Structures
//  Author:         Cory Moore, moorecs1@etsu.edu, Department of Computing, ETSU
//  Created:        Thursday, January 09, 2017
//  Copyright:      Cory Moore, 2017
//
///////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project1
{
    /// <summary>
    /// Creates a Person object of the female gender
    /// </summary>
    public class Female : Person
    {
        public FemaleTitle Title { get; private set; }
        public FemaleFirstName FirstName { get; private set; }
        /// <summary>
        /// Female Constructor
        /// </summary>
        public Female()
        {
            BirthDate = DateTime.Now.AddDays(-new Random().Next((30 * 365), (60 * 365)));
            Title = (FemaleTitle) new Random().Next(0, Enum.GetNames(typeof(FemaleTitle)).Length);
            LastName = (LastName) new Random().Next(0, Enum.GetNames(typeof(LastName)).Length);
            FirstName = (FemaleFirstName) new Random().Next(0, Enum.GetNames(typeof(FemaleFirstName)).Length);
            Address = new Address();
            Company = new Company();
            CreditCard = new CreditCard();
            PhoneNumber = new PhoneNumber();
            InternetInfo = new InternetInfo(FirstName.ToString(), LastName.ToString());
            Ssn = new Ssn();
        }
        /// <summary>
        /// Calculates the person's age based on the birthdate. 
        /// </summary>
        /// <returns></returns>
        public override int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;
            if (BirthDate > today.AddYears(-age)) age--;
            return age;
        }
        /// <summary>
        /// Prints out all the female properties, as well as the ones in
        /// the parent (Person) class. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return 
                "\nTitle      : "  + Title +
                "\nFirst Name : " + FirstName +
                "\nLast Name  : " + LastName+
                "\nBirth Date : " + BirthDate.ToShortDateString() + 
                "\nAge        : " + GetAge()+
                "\nPhone #    : " +PhoneNumber +
                "\nAddress    : " + Address+
                "\nCompany    : " + Company +
                                CreditCard
                +InternetInfo + 
                "\nSSN        : " + Ssn;
        }//end method
    }//end class
}
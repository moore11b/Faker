using System;
using FakerClass;
using Project1.Properties;
///////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project 1
//  File Name:      Male.cs
//  Description:    Creates a person object of the male gender. 
//  Course:         CSCI-2910-001 - Data Structures
//  Author:         Cory Moore, moorecs1@etsu.edu, Department of Computing, ETSU
//  Created:        Thursday, January 09, 2017
//  Copyright:      Cory Moore, 2017
//
///////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project1
{
    /// <summary>
    /// Creates a person object of the male gender.
    /// </summary>
    public class Male : Person
    {
        private MaleTitle Title { get; set; }
        private MaleFirstName FirstName{ get; set; }
        
        /// <summary>
        /// Male Constructor
        /// </summary>
        public Male() 
        {
            BirthDate = DateTime.Now.AddDays(-new Random().Next((30 * 365), (60 * 365)));
            Title = (MaleTitle) new Random().Next(0, Enum.GetNames(typeof(MaleTitle)).Length);
            LastName = (LastName) new Random().Next(0, Enum.GetNames(typeof(LastName)).Length);
            FirstName = (MaleFirstName) new Random().Next(0, Enum.GetNames(typeof(MaleFirstName)).Length);
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
            if (BirthDate> today.AddYears(-age)) age--;
            return age;
        }
        /// <summary>
        /// Prints out all the female properties, as well as the ones in
        /// the parent (Person) class. 
        /// </summary>
        /// <returns></returns>
        public override String ToString()
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
        }
    }
}
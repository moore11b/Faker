using System;
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
    public class PhoneNumber 
    {
        public string Number{ get;private set; }
        /// <summary>
        /// PhoneNumber constructor
        /// </summary>
        public PhoneNumber()
        {
            AssignPhoneNumber();
        }

       /// <summary>
       /// Method used for the user to assign the character between the phone
       /// number digits.
       /// </summary>
       /// <param name="character"></param>
       /// <returns></returns>
       public void UserAssignPhoneNumber(char character)
        {
                int firstThreeDigits = new Random().Next(200,999);
                int secondThreeDigits = new Random().Next(100,999);
                int lastFourDigits = new Random().Next(1000,9999);
                Number = ""+firstThreeDigits + character + secondThreeDigits +
                       character + lastFourDigits;
        }
       /// <summary>
       /// Method used for the user to assign the character between the phone
       /// number digits.
       /// </summary>
       /// <param name="character"></param>
       /// <returns></returns>
       private void AssignPhoneNumber()
       {
           int firstThreeDigits = new Random().Next(200,999);
           int secondThreeDigits = new Random().Next(100,999);
           int lastFourDigits = new Random().Next(1000,9999);
           Number = ""+firstThreeDigits + "-" + secondThreeDigits +
                    "-" + lastFourDigits;
       }
        /// <summary>
        /// Simply returns a string holding the Phone Number
        /// </summary>
        /// <returns></returns>
       public override string ToString()
       {
           return  Number;
       }//end method
    }//end class
    public class Ssn
    {
        public string SsNumber { get; private set; }
        /// <summary>
        /// Ssn Constructor
        /// </summary>
        public Ssn()
        {
            AssignSsn();
        }
        /// <summary>
        /// Assigns a Randomly generated fake SSN.  The first three digits on SSN, ITIN,
        /// and ATIN never are between 734 and 749.  With the combination of the other
        /// randomly generated numbers, this creates a range of nearly 15,000. 
        /// </summary>
        private void AssignSsn()
        {
            var tempString = "";
            for (var i = 0; i < 3; i++)
            {
                switch(i)
                {
                   case 0: tempString += new Random().Next(734,749) +"-";
                       break;
                   case 1: tempString += new Random().Next(0,9);
                            tempString += 0 +"-";
                       break;
                   case 2: tempString += new Random().Next(1000,9999);
                       break;
                   default:
                       tempString = "error";
                       break;
                }//end switch
            }//end loop
            SsNumber = tempString;
        }//end method
        /// <summary>
        /// Simply returns the SSN
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return SsNumber;
        }
    }//end class
}
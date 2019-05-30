using System;
///////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project 1 - HashTables 
//  File Name:      CreditCard.cs
//  Description:    Creates Random credit card related information. 
//  Course:         CSCI-2910-001 - Data Structures
//  Author:         Cory Moore, moorecs1@etsu.edu, Department of Computing, ETSU
//  Created:        Thursday, January 09, 2017
//  Copyright:      Cory Moore, 2017
//
///////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project1.Properties
{
    /// <summary>
    /// Creates Random credit card related information. 
    /// </summary>
    public class CreditCard
    {
        public string CardNumber { get;  private set; }
        public string ExpirationDate { get; private set; }
        public int Csv { get; private set; }
        public CreditCardBrand CreditCardBrand { get;   private set; } 
        /// <summary>
        /// CreditCard Constructor
        /// </summary>
        public CreditCard()
        {
            CreditCardBrand = (CreditCardBrand) new Random().Next(0,
                Enum.GetNames(typeof(CreditCardBrand)).Length);
            AssignCardNumber();
            Csv = new Random().Next(100,9999);
            
            var dateAndTime =DateTime.Now.AddDays(
                new Random().Next((3 * 365), (4 * 365)));
            ExpirationDate = dateAndTime.ToString("dd/mm/yyyy");
        }//end constructor
        /// <summary>
        /// Changes the Brand and Number to a test card base on the
        /// user's decision. 
        /// </summary>
        /// <param name="cardBrand"></param>
        public void UserAssignedTestCard(int cardBrand)
        {
            switch (cardBrand)
            {
                case 1:
                    CreditCardBrand=0;
                    CardNumber = ""+378282246310005;
                    break;
                case 2:
                    CreditCardBrand = (CreditCardBrand)1;
                    CardNumber = "" + 378734493671000;
                    break;
                case 3:
                    CreditCardBrand=(CreditCardBrand)2;
                    CardNumber = ""+5610591081018250;
                    break;
                case 4:
                    CreditCardBrand = (CreditCardBrand)3;
                    CardNumber = "" +  30569309025904;
                    break;
                case 5:
                    CreditCardBrand=(CreditCardBrand)4 ;
                    CardNumber = ""+6011111111111117;
                    break;
                case 6:
                    CreditCardBrand=(CreditCardBrand)5 ;
                    CardNumber = "" + 3530111333300000;
                    break;
                case 7: 
                    CreditCardBrand=(CreditCardBrand)6 ;
                    CardNumber = ""+5105105105105100;
                    break;
                case 8:
                    CreditCardBrand=(CreditCardBrand)7;
                    CardNumber = "" + 4111111111111111;
                    break;
                case 9:
                    CreditCardBrand=(CreditCardBrand)8;
                    CardNumber = ""+76009244561;
                    break;
                default:
                    CreditCardBrand=(CreditCardBrand)8;
                    CardNumber = ""+76009244561;
                    break;
            }
        }
        
       /// <summary>
       /// Assigns The Number to the CreditCard
       /// </summary>
        private void AssignCardNumber()
        {
            if (CreditCardBrand.ToString().Equals("American_Express"))
            {
                var firstTwoDigits = 34;
                if ( new Random().Next(0,2) == 0)
                {
                    firstTwoDigits = 37;
                }
                var firstHalf  = new Random().Next(100000, 999999);
                var secondHalf = new Random().Next(1000000,9999999);
                CardNumber = firstTwoDigits + firstHalf.ToString() + secondHalf;
            }
            else if (CreditCardBrand.ToString().Equals("Discover"))
            {
                var firstDigits = 6011;
                if ( new Random().Next(0,3) == 0)
                {
                    firstDigits = 64;
                }
                else if ( new Random().Next(0,3) == 1)
                {
                    firstDigits = 65;
                }

                if (firstDigits == 6011)
                {
                    var firstPart  = new Random().Next(10000,99999);
                    var secondPart = new Random().Next(100000,999999);
                    var thirdPart = new Random().Next(1,9999);
                    CardNumber = firstDigits.ToString() + firstPart + secondPart + thirdPart;
                }
                else
                {
                    var firstPart  = new Random().Next(100000,999999);
                    var secondPart = new Random().Next(1000000,9999999);
                    var thirdPart = new Random().Next(1,9999);
                    CardNumber = firstDigits.ToString() +firstPart + secondPart + thirdPart;
                }
                
            }
            else if (CreditCardBrand.ToString().Equals("MasterCard"))
            {
               if ( new Random().Next(0,2) == 0)
               {
                   var firstDigits = new Random().Next(222100, 272099);
                   var secondDigits =new Random().Next(100000, 999999);
                   var thirdDigits = new Random().Next(1000,   9999);
                   CardNumber = firstDigits.ToString() + secondDigits + thirdDigits;
               }
               else
               {
                   var firstDigits = new Random().Next(51,55);
                   var secondDigits =new Random().Next(1000000, 9999999);
                   var thirdDigits = new Random().Next(1000000, 9999999);
                   CardNumber = firstDigits.ToString() + secondDigits + thirdDigits;
               }
            }
            else if (CreditCardBrand.ToString().Equals("Visa"))
            {
                var firstDigit = 4;
                var secondDigits =new Random().Next(1000000, 9999999);
                var thirdDigits = new Random().Next(10000000, 99999999);
                CardNumber = firstDigit.ToString() + secondDigits + thirdDigits;
            }
            else
            {
                CreditCardBrand = (CreditCardBrand) 7;
                var firstDigit = 4;
                var secondDigits =new Random().Next(1000000, 9999999);
                var thirdDigits = new Random().Next(10000000, 99999999);
                CardNumber = firstDigit.ToString() + secondDigits + thirdDigits;
            }
                }//end method
        /// <summary>
        /// Returns a string of the Person's Credit card information
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "\nCard Brand : " + CreditCardBrand +
                   "\nCard Number: " + CardNumber + 
                   "\nCSV        : " + Csv +
                   "\nExp. Date  : " + ExpirationDate;
        }
    }//end class
    /// <summary>
    /// Various credit card brands.
    /// </summary>
    public enum CreditCardBrand
    {
        AmericanExpress,AmericanExpress_Corporate,Australian_BankCard
        ,Diners_Club,Discover,JCB,MasterCard,Visa,Dankort
    }
}


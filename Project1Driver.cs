using System;
using System.IO;
using Project1.Properties;
 
///////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project 1
//  File Name:      Project1Driver.cs
//  Description:    Implements all the data generated in project 1.  
//  Course:         CSCI-2910-001 - Data Structures
//  Author:         Cory Moore, moorecs1@etsu.edu, Department of Computing, ETSU
//  Created:        Thursday, January 09, 2017
//  Copyright:      Cory Moore, 2017
//
///////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project1
{
    /// <summary>
    /// Implements all the data generated in project 1. 
    /// </summary>
    public class Project1Driver
    {
        static void Main()
        {
            /*//The method below Holds a person value.. 
            var p1 = CreateGender();
           CardMenu(p1);
           PhoneMenu(p1);
           EmailMenu(p1);
           Console.Clear();
           var error1 = true;
           while (error1)
           {
               try
               {
                   Console.Clear();
                   Console.Out.WriteLine("What country would you like on your address?" +
                                         "\n\tPress 1 for USA"
                                         + "\n\tPress 2 for Mexico");

                   var countryOpt = Convert.ToInt32(Console.ReadLine());
                   Console.Out.WriteLine(countryOpt);
                   
                       p1.Address.AssignCountryName(countryOpt);
                   
                   error1 = false;
               }
               catch(FormatException e)
               {
                   Console.Out.WriteLine("Mistakes were made, try again..");
                   error1 = true;
               }
               catch (Exception e)
               {
                   Console.WriteLine(e);
                   throw;
                }
           }
           Console.Out.WriteLine(p1.ToString());
           
           
           //The lines belog test the Color Dictionary,
           //brings out a random Color from it, along
            //with the corresponding value. 
           var c1 = new Color();
            Console.Out.WriteLine(c1);
            PressEnterToContinue();
           string path = "../Project1/FixedSampleText.txt";
           string readText = File.ReadAllText(path);
           //Uncomment the method below to text Random Consecutive sentences. 
           Sentence.MakeSentenceList(readText);
           var error2 = true;
           while (error2)
           {
               try
               {
                   TextSentMenu();
                   error2 = false;
               }
               catch (Exception e)
               {
                   Console.Out.WriteLine("Sorry No paragraph for you");
                   error2 = true;
               }
           } 
           Words.MakeWordsList(readText);
           var error3 = true;
           while (error3)
           {
               try
               {
                   TextWordMenu();
                   error3 = false;
               }
               catch (Exception e)
               {
                   Console.Out.WriteLine("Sorry No paragraph for you");
                   error3 = true;
               }
           }//end TestWord
           */
            Male p1 = new Male();
            Console.Out.WriteLine(p1.Company);
            
         }//end main
        /// <summary>
        /// Creates a person of random gender. 
        /// </summary>
        /// <returns></returns>
        public static Person CreateGender()
        {
            var rand = new Random().Next(0,2);
            if (rand == 0)
                return  new Male();
            else
               return  new Female();
        }
        /// <summary>
        /// Built for testing the random Sentnece method.
        /// </summary>
        public static void TextSentMenu()
        {
            Console.Clear();
            Console.Out.WriteLine("Enter the number of sentences you want in your " +
                                          "paragraph: ");
             var paraSize = Convert.ToInt32(Console.ReadLine());
            var para = "";
            para = Sentence.GetParagraph(paraSize);
            Console.Out.WriteLine("Paragraph:\n" +para+
                                          "\n\nRandom Sentence:\n" + Sentence.GetRandSentence());
            PressEnterToContinue();
        }
        /// <summary>
        /// Built for testing the random word method. 
        /// </summary>
        public static void TextWordMenu()
        {
            Console.Clear();
            Console.Out.WriteLine("Enter the number of Words you want in your " +
                                  "paragraph: ");
            var paraSize = Convert.ToInt32(Console.ReadLine());
            var para = "";
            para = Words.GetRandomWords(paraSize);
            Console.Out.WriteLine("Paragraph:\n" + para);
            PressEnterToContinue();
        }
        /// <summary>
        /// Gives the user an option to modify an email address,
        /// Keeps the same structure of original email,
        /// but places random characters between the first and last name. 
        /// </summary>
        /// <param name="p1"></param>
        public static void EmailMenu(Person p1)
        {
              var optionEmail = "";
              Console.Clear();
              Console.Out.WriteLine("Current email: "
                                          +p1.InternetInfo.EmailAddress+
                        "\nDo you need to slightly modify your email?" +
                                          "\n\tPress y for yes. " +
                                          "\n\tPress n for no.");
              optionEmail = Console.ReadLine().ToLower();
              if (optionEmail.StartsWith("y"))
              {
                  Console.Out.WriteLine(optionEmail);
                         p1.InternetInfo.UserAssignEmailAddress(p1.LastName.ToString()
                        , p1.InternetInfo.EmailAddress);
                         Console.Clear();
                        Console.Out.WriteLine("You have a new Email!"
                                              +   "\nCurrent email:"
                                              + p1.InternetInfo.EmailAddress);
                        PressEnterToContinue();
              }//end if
              else if (optionEmail.StartsWith("n"))
              {
                   PressEnterToContinue();
              }
              else
              {
                        Console.Clear();
                        Console.Out.WriteLine("Not valid, Please try again");
              }
        }//end emailMenu
        /// <summary>
        /// Allows the user to Use a custom character to delimit their
        /// phone number
        /// </summary>
        /// <param name="p1"></param>
        public static void PhoneMenu(Person p1)
        { 
            var option = "";
                    Console.Clear();
                    Console.Out.WriteLine("Do you want to place " +
                                              "\na custom character " +
                                             "\nto delimit your phone number?" +
                                          "\n\tPress y for yes. " +
                                          "\n\tPress n for no.");
            option = Console.ReadLine().ToLower();
            if (option.StartsWith("y"))
            {
                 Console.Clear();
                 Console.Out.WriteLine("Please enter your chosen character:" );
                 var phoneChar = Console.ReadKey().KeyChar;
                        p1.PhoneNumber.UserAssignPhoneNumber(phoneChar);
            }//end if
            else if (option.StartsWith("n"))
            {
                PressEnterToContinue();
            }
            else
            {
                 Console.Out.WriteLine("Not valid, Please try again");
            }
        }
        /// <summary>
        /// Gives the user an option to create a test card. 
        /// </summary>
        /// <param name="p1"></param>
        public static void CardMenu(Person p1)
        {
             var option = "";
              Console.Out.WriteLine("Do you need a test card?" +
                                          "Press y for yes. " +
                                          "Press n for no.");
              option = Console.ReadLine().ToLower();
              if (option.StartsWith("y"))
              {
                  Console.Clear();
                  Console.Out.WriteLine("Press the corresponding number"
                                              + "\nwith the associated card:"
                                              + "\n\tPress 1 for American Express "
                                              + "\n\tPress 2 for American Express Corporate"
                                              + "\n\tPress 3 for Australian BankCard"
                                              + "\n\tPress 4 for Diners Club"
                                              + "\n\tPress 5 for Discover"
                                              + "\n\tPress 6 for JCB"
                                              + "\n\tPress 7 for MasterCard"
                                              + "\n\tPress 8 for Visa"
                                              + "\n\tPress 9 for Dankort (PBS)"
                                              + "\n\tPress 10 for Switch/Solo (Paymentech)");
                        
                  var cardBrand = Convert.ToInt32(Console.ReadLine());
                  p1.CreditCard.UserAssignedTestCard(cardBrand);
                      
                  }//end if
                  else if (option.StartsWith("n"))
                  {
                     Console.Clear();
                     Console.Out.WriteLine("Continuing...");
                  }
                  else
                  {
                     Console.Clear();
                     Console.Out.WriteLine("Not valid, Please try again");
                  }
        }//end CardMenu
        /// <summary>
        /// Pauses the program and waits for the user to continue manually. 
        /// </summary>
        public static void PressEnterToContinue()
        {
            Console.Out.WriteLine("Press enter to Continue");
            Console.ReadLine();
            Console.Clear();
        }
    }//end class
    
}
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
 
///////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project 1 - HashTables 
//  File Name:      Sentence.cs
//  Description:    Class used for generating sentences.  
//  Course:         CSCI-2910-001 - Data Structures
//  Author:         Cory Moore, moorecs1@etsu.edu, Department of Computing, ETSU
//  Created:        Thursday, January 09, 2017
//  Copyright:      Cory Moore, 2017
//
///////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project1.Properties
{
    /// <summary>
    /// Class used for generating sentences. 
    /// </summary>
    public static class Sentence
    {
       
        public static List<string> SentencesList { get; set; }
        /// <summary>
        /// Makes a list of sentences from a text file. 
        /// </summary>
        /// <param name="text"></param>
        public static void MakeSentenceList(string text)
        {
            SentencesList = new List <string>();
            var varSentList =  Regex.Split(text, @"(?<=[.?!])");

            for (int i = 0; i < varSentList.Length; i++)
            {
                SentencesList.Add(varSentList[i]); 
            }
        }
        /// <summary>
        /// Creates a paragraph based on a range input by the user. 
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public static string GetParagraph(int range)
        {
            var paragraph = "";
            var count = 0;
            var rand = new Random().Next(0,SentencesList.Count-range);
            while (count != range)//keeps the accurate number of sentences.
            {
                if (count + range > SentencesList.Count)
                {
                    break;
                }
                else
                {
                    paragraph += "\n\nSentence " + rand +" "+ SentencesList[rand] + " ";
                    rand++;
                    count++;
                }
            }
            return paragraph;
        }
        /// <summary>
        /// Gets a random sentences from the List. 
        /// </summary>
        /// <returns></returns>
        public static string GetRandSentence()
        {
            return SentencesList[new Random().Next(0, SentencesList.Count)];
        }
    }//end class
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using FakerClass;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Design;

 
///////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project 1 - HashTables 
//  File Name:      Words.cs
//  Description:    Class used for generating words from the sentence class.  
//  Course:         CSCI-2910-001 - Data Structures
//  Author:         Cory Moore, moorecs1@etsu.edu, Department of Computing, ETSU
//  Created:        Thursday, January 09, 2017
//  Copyright:      Cory Moore, 2017
//
///////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project1.Properties
{
    /// <summary>
    ///  Class used for generating words from the sentence class. 
    /// </summary>
    public static class Words
    {
       
        public static List<string> WordList { get;  set; }
        public static Dictionary<string,int> WordDict { get;  set; }
        /// <summary>
        /// Uses several delimiters to refine the "word bank" in the array.  
        /// </summary>
        /// <param name="text"></param>
        public static void MakeWordsList(string text )
        {
            WordList = new List <string>();
            
            string[] separators = {"',","(",")","_",
                "! '", "? '", ". '" ,"--'", ".)", ", )", ") ," , "!'" ,"?'",".'"
                ,",","--","*" ,  " ",".", "!", ".'","!'"
                
                ,"?", ":", ";","\r","\n"};
                
            var varSentList = text.Split(separators, StringSplitOptions.RemoveEmptyEntries );

            for (var i = 0; i < varSentList.Length; i++)
            {
                WordList.Add(varSentList[i]); 
            }
        }//end MakeWordsList
        /// <summary>
        /// Collects consecutive words from a text file based on
        /// a range entered from the user.
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public static string GetRandomWords(int range)
        {
            var paragraph = "";
            var count = 0;
            var rand = new Random().Next(0,WordList.Count -range);
            while (count != range)//keeps the accurate number of sentences.
            {
                if (count + range > WordList.Count)
                {
                    Console.Out.WriteLine("Error");
                }
                else
                {
                    paragraph += "\n\nSentence " + rand +" "+ WordList[rand] + " ";
                    rand++;
                    count++;
                }
            }
            return paragraph;
        }
        /// <summary>
        /// Doesn't actually Count the "words" (or keys) rather,
        /// it simply returns the key and the value if word as the parameter exist. 
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static int GetWordCount(string wordKey)
        {
            int value = 0;
            if (WordDict.TryGetValue(wordKey, out value))//Could I use an int as a value instead of a string?
            {
                Console.WriteLine("key : " + wordKey +"\nvalue : {0}.", value++);
            }
            else
            {
                Console.WriteLine("Key : " + wordKey +" is not found.");
            }
            return value;
        }//end GetStateAbb
        ///<summary>
        ///This initializes the Dictionary from the individual Word Array
        ///</summary>
        ///<param name = none> </param>
        ///<returns> void </returns>
        public static void MakeDictionary()
        {
            WordDict = new Dictionary<string, int>();
            for (int i = 0; i < WordList.Count ; i++)
            {
                if(WordDict.ContainsKey(WordList[i]))
                {
                    WordDict[WordList[i]]++;
                }
                else
                {
                    WordDict.Add(WordList[i],1);
                }
            }
        }//end MakeDictionary()
        
     
    }
}
using System;
using System.Collections.Generic;
using System.IO;
///////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project 1 - HashTables 
//  File Name:      Color.cs
//  Description:    Creates a randomly generated color. 
//  Course:         CSCI-2910-001 - Data Structures
//  Author:         Cory Moore, moorecs1@etsu.edu, Department of Computing, ETSU
//  Created:        Thursday, January 09, 2017
//  Copyright:      Cory Moore, 2017
//
///////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project1.Properties
{
    /// <summary>
    /// Creates a randomly generated color.
    /// </summary>
    public class Color
    {
        public List<string>  ColorNameList { get; set; }
        public List<string>  HexNameList { get; set; }
        public List<string>  RgbNameList { get; set; }
       /// <summary>
       /// ColorDict: Key is the Color name while the
       /// value is a combined string of the HEX and RGB values.
       /// </summary>
        public Dictionary<string,string> ColorDict { get; set; }
       ///Randomly selected color from the ColorInfoList. 
       public string SelectedColor { get; set; }
        /// <summary>
        /// Color Constructor. 
        /// </summary>
        public Color()
        {
            CreateColorNameList();
            CreateHexList();
            CreateRgbList();
            CreateColorDict();
        }
        /// <summary>
        /// Creates a List of the Color Names read from a txt file,
        /// to be converted to keys in the dictionary. 
        /// </summary>
        private void CreateColorNameList()
        {
            ColorNameList = new List<string>();
            char[] separators = { ','};
            var path = "../Project1/Color.txt";
            var readText = File.ReadAllText(path);
            var varColorName = readText.Split(separators, StringSplitOptions.None);
            for (var i = 0; i < varColorName.Length; i++)
            {
                ColorNameList.Add( varColorName[i]);
            }
        }
        /// <summary>
        /// Creates a List of the Hex values read from a txt file,
        /// to be converted to part of a value in the dictionary. 
        /// </summary>
        private void CreateHexList()
        {
            HexNameList = new List<string>();
            char[] separators = { ','};
            var path = "../Project1/HexVals.txt";
            var readText = File.ReadAllText(path);
            var varColorName = readText.Split(separators, StringSplitOptions.None);
            for (var i = 0; i < varColorName.Length; i++)
            {
               HexNameList.Add( varColorName[i]);
            }
        } 
        /// <summary>
        /// Creates a List of the RGB values read from a txt file,
        /// to be converted to part of a value in the dictionary. 
        /// </summary>
        private void CreateRgbList()
        {
            RgbNameList = new List<string>();
            char[] separators = { '\n' , '@'};
            var path = "../Project1/Rgb.txt";
            var readText = File.ReadAllText(path);
            var varColorName = readText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            for (var i = 0; i < varColorName.Length; i++)
            {
                RgbNameList.Add(varColorName[i]);
            }
        }
        /// <summary>
        /// A dictionary was appropriate so that the values wouldn't be
        /// edited or changed from the color. 
        /// </summary>
        private void CreateColorDict()
        {
            ColorDict = new Dictionary<string, string>();
            var temp = "";
            for (var i = 0; i < ColorNameList.Count; i++)
            {
                temp = "Hex Value: " + HexNameList[i] +
                       " | RGB Value: " + RgbNameList[i]; 
                ColorDict.Add(ColorNameList[i],temp);
            }
        }
        /// <summary>
        /// Combines the a random key and corresponding value.
        /// Can easily converted to print the entire dictionary;
        /// however, that can be implemented in the driver, and this demonstrates
        /// that accurate values were created and stored. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            int rand = new Random().Next(0, ColorDict.Count);
            List<string> keyList = new List<string>(ColorDict.Keys);
            SelectedColor = keyList[rand];
            List<string> valList = new List<string>(ColorDict.Values);
            SelectedColor += " | " +valList[rand];
            return SelectedColor;
        }//end method
    }//end class
}
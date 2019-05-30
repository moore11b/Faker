using System;
///////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Project:        Project 1 - HashTables 
//  File Name:      Company.cs
//  Description:    Creates random employer information for the person object.  
//  Course:         CSCI-2910-001 - Data Structures
//  Author:         Cory Moore, moorecs1@etsu.edu, Department of Computing, ETSU
//  Created:        Thursday, January 09, 2017
//  Copyright:      Cory Moore, 2017
//
///////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project1.Properties
{
    /// <summary>
    /// Creates random employer information for the person object.
    /// </summary>
    public class Company
    {
        public CompanyName CompanyName { get; private set; }
        public CompanyPosition CompanyPosition { get; private set; }
        public CompanySuffix CompanySuffix { get; private set; }
        /// <summary>
        /// Company constructor. 
        /// </summary>
        public Company()
        {
            CompanyName = (CompanyName) new  Random().Next(0, Enum.GetNames(
                typeof(CompanyName)).Length);
            CompanyPosition =(CompanyPosition) new Random().Next(0, Enum.GetNames(
                typeof(CompanyPosition)).Length);
            CompanySuffix = ( CompanySuffix) new Random().Next(0, Enum.GetNames(
                typeof(CompanySuffix)).Length);
        }
        /// <summary>
        /// ToString method. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return   CompanyName + " " +CompanySuffix +
                   "\nPosition   : " + CompanyPosition  ;
        }
        
    }//end Company Class
    /// <summary>
    /// Enumerated class For Company names
    /// </summary>
    public enum CompanyName{Eastman, CGI, Americorps, Amazon,Verizon,Boring_Company,SpaceX,}
   /// <summary>
   /// Suffix for company names
   /// </summary>
    public enum CompanySuffix{Ltd,  LLC, Inc, Corp, }
    /// <summary>
    /// Various Positions for companies.  
    /// </summary>
    public enum CompanyPosition
    {
        Foreman, Manager, Supervisor, CEO,CIO,Secretary, COO,CFO,General_Manager,
        President,Vice_President, Sergeant_At_Arms, Treasurer
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSearch.Class;

namespace FileSearch
{
    internal class TestMain
    {
        static void Main(string[] args)
        {
            #region Notes

            /*
            Approach

            1. Goals
                Fastest way to find a file in a system
            2. What do we need to do - Scope of work

                Abstraction - **** Important Word - What
                Implementation - How
                Class- Who
                ADT - Abstraction Based Technique
                NIT - Noun Identification Technique
                DDT - Data Driven Technique

                1. Seach for file
                    1.1 : Accept File Name
                    1.2 : Accept the drives to search in
                    1.3 : Check if file has already been searched in history
                    1.4 : If yes, display
                    1.5 : If no, Initiate new search 
                    1.6 : Search for file
                    1.6.1 : Search for file in a multi-threaded manner
                    1.6.2 : Capture the results
                2. Store the search results in history
                3. Display search results
            */

            /*
                Different category of classes
                Boundary
                Control
                Entity
                Extenal Interface
            */

            #endregion

            var searchForm = new SearchInputForm();

            searchForm.Search();
        }
    }
}
//file names sample
/*
ECIS-Induction.pdf
ADO.NET Reference Manual.pdf
FIT-NET-JAN-2022-20220219_170936-Meeting Recording.mp4
project-colors.json
 */
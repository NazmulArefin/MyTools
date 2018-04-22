using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace NecessaryTools.Models
{
    public class MissMatch
    {
        [DisplayName(@"Pest idol list here:")]
        public List<string> FirstList { get; set; }
        [DisplayName(@"Pest testing list here:")]
        public List<string> SecondList { get; set; }

        public Missing MissingData { get; set; }
        public CommaSeparateData SeparateCommanData { get; set; }
        public AgeCalculator CalculateAge { get; set; }



        public class Missing
        {
            public int Index { get; set; }
            public string Value { get; set; }
        }

        public class CommaSeparateData
        {
            [DisplayName(@"Pest list here:")]
            public List<string> List { get; set; }
            public int Line { get; set; }
            public string Index { get; set; }
            public string Value { get; set; }

            public CommaSeparateData()
            {
                Line = 0;
                Index = "0";
                Value = "0";  
            }
        }

        public class AgeCalculator
        {
            [DisplayName(@"Date of Birth:")]
            public string DOB { get; set; }
            [DisplayName(@"Current Date:")]
            public string CurrentDate { get; set; }

            public string Year { get; set; }
            public string Month { get; set; }
            public string Day { get; set; }

            public static string AgeCalculate(AgeCalculator ageCalculator)
            {
                DateTime dob = Convert.ToDateTime(Convert.ToDateTime(ageCalculator.DOB).ToString("yyyy-MM-dd"));
                DateTime today = Convert.ToDateTime(Convert.ToDateTime(ageCalculator.CurrentDate).ToString("yyyy-MM-dd"));

                int months = today.Month - dob.Month;
                int years = today.Year - dob.Year;

                if (today.Day < dob.Day)
                {
                    months--;
                }

                if (months < 0)
                {
                    years--;
                    months += 12;
                }

                int days = (today - dob.AddMonths((years * 12) + months)).Days;

                return
                    $"{years} year{((years == 1) ? "" : "s")}, {months} month{((months == 1) ? "" : "s")} and {days} day{((days == 1) ? "" : "s")}";

            }
        }

        public static List<Missing> GetMissingItems(MissMatch aMissMatch)
        {
            List<string> aStringList = aMissMatch.FirstList;
            List<string> bStringList = aMissMatch.SecondList;
            List<Missing> missingList = new List<Missing>();

            for (int i = 0; i < bStringList.Count; i++)
            {
                if (aStringList.Contains(bStringList[i]))
                {
                    continue;
                }
                else
                {
                    Missing aMissing = new Missing
                    {
                        Index = i+1,
                        Value = bStringList[i]
                    };
                    missingList.Add(aMissing);
                }
            }
            return missingList;
        }
    }
}
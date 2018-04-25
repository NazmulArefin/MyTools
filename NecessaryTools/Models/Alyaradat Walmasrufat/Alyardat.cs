using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NecessaryTools.Models.Alyaradat_Walmasrufat
{
    public class AlYardat
    {
        public int IncomId { get; set; }
        [DisplayName(@"Income Source:")]
        public string IncomeSourceName { get; set; }
        public double Amount { get; set; }
        [DisplayName(@"Date of Income:")]
        public string IncomeDate { get; set; }
        public double Remainder { get; set; }
    }
}
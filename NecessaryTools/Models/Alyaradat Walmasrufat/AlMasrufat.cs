using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NecessaryTools.Models.Alyaradat_Walmasrufat
{
    public class AlMasrufat
    {
        public int ExpenseId { get; set; }
        [DisplayName(@"Source Name:")]
        public string ExpenseSource { get; set; }
        public string Goods { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public double Total { get; set; }
        [DisplayName(@"Date of Expense:")]
        public string ExpDate { get; set; }
        public string Remarks { get; set; }

    }
}
using System.Threading;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Interface_Implementation.models
{
    public class Bill
    {
        private int BillNo;
        private DateTime Date;
        private string Memeber_ID;
        private decimal Amount;

        public int BillNumber {get; set;}
        public DateTime BillPayDate {get; set;}
        public string MemeberID {get; set;}
        public decimal BillAmount {get; set;}

        public void BillCreate()
        {
            Console.WriteLine($"-------Creating Bill------------");
            Console.WriteLine($"Bill NO: {BillNumber}");
            Console.WriteLine($"Date: {BillPayDate}");
            Console.WriteLine($"Member ID: {MemeberID}");
            Console.WriteLine($"Total Amount: {BillAmount}");
            Console.WriteLine($"-----------------------------");
            Console.WriteLine($"Messege: Bill Created Successfully!");
        }
        public void BillUpdate(int bno, DateTime billPayDate, string memid, decimal amount)
        {
            BillNumber = bno;
            BillPayDate = billPayDate;
            MemeberID = memid;
            BillAmount = amount;
            Console.WriteLine($"Bill updating........");
            Thread.Sleep(5000);
            Console.WriteLine($"Messege: Bill Updated Successfully!");
        }
    }
}
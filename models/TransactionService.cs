using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interface_Implementation.interfaces;

namespace Interface_Implementation.models
{
    public class TransactionService : ITransaction
    {
        private string TransactionID;
        private string MemeberID;
        private string BookID;
        private DateTime DateOfIssue;
        private DateTime DueDate;

        public string Tran_ID
        {
            get {return TransactionID;}
            set {TransactionID = value;}
        }
        public string Memeber_ID
        {   
            get {return MemeberID;}
            set {MemeberID = value;}
        }
        public string Book_ID
        {
            get {return BookID;}
            set {BookID = value;}
        }
        public DateTime Date_Of_Issue
        {
            get {return DateOfIssue;}
            set {DateOfIssue = value;}
        }
        public DateTime Due_Date
        {
            get {return DueDate;}
            set {DueDate = value;}
        }

        public string CreateTransaction()
        {
            Console.WriteLine($"===========Creating Transaction=======");
            Console.WriteLine($"Transaction ID: {Tran_ID}");
            Console.WriteLine($"Member ID: {Memeber_ID}");
            Console.WriteLine($"Book ID: {Book_ID}");
            Console.WriteLine($"Date of Issue: {Date_Of_Issue.ToShortDateString()}");
            Console.WriteLine($"Due Date: {Due_Date.ToShortDateString()}");
            Console.WriteLine($"-----------------------");
            return "Messege: Transaction Created Succesfully!";
        }
        public void DeleteTransaction()
        {
            Console.WriteLine($"You are Gonna Delete Transaction.");
            Console.Write($"Are You Sure (Y/N): ");
            string status = Console.ReadLine().ToLower();

            switch(status)
            {
                case "y":
                    Console.WriteLine($"Messege: Deleted Successfully");
                    break;
                case "n":
                    Console.WriteLine($"Messege: Did Not Delete.");
                     RetrieveTransaction();
                    break;
            }
        }
        public void RetrieveTransaction()
        {
            Console.WriteLine($"Messege: Retrieved Successfully!");
        }
    }
}
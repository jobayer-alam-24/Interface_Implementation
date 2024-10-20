﻿using Interface_Implementation.models;

namespace Interface_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            BookService book = new BookService();
            book.BookID = "#b2242";
            book.BookTitle = "Way of Lives";
            book.AuthorName = "Unknown";
            book.BookEdition = "4th Edition";
            book.BookPrice = 45.532m;
            book.BookRackNo = 4;
            book.BookStatus = "Available";
            book.PurchaseDate = DateTime.Now;
            TransactionService transaction = new TransactionService();
            transaction.Tran_ID = "TR123";
            transaction.Book_ID = "B1-4";
            transaction.Memeber_ID = "M224";
            transaction.Date_Of_Issue = DateTime.Today;
            transaction.Due_Date = DateTime.Now.AddDays(-5);
            Bill bill1 = new Bill();
            bill1.BillNumber = 1;
            bill1.BillPayDate = DateTime.Now;
            bill1.MemeberID = "M12";
            bill1.BillAmount = 455.5m;
            Librarian librarian1 = new Librarian();
            librarian1.Name = "Sabbir Boss";
            librarian1.Password = "abc_123";
            MemberRecord member = new MemberRecord();
            member.MemeberID = "#Mem123";
            member.Memeber_Type = "Regular";
            member.DateOfMembership = DateTime.Now;
            member.MaxBookLimit = 12;
            member.Name = "Saabir Boss";
            member.Address = "Saabir Boss, Chonka";
            member.PhoneNumber = "01902730962 | 01909488972";

            Console.WriteLine(book.UpdateStatus("Unavailable"));
            book.DisplayBookDetails();
            Console.WriteLine(transaction.CreateTransaction());
            transaction.DeleteTransaction();
            bill1.BillCreate();
            bill1.BillUpdate(2, DateTime.Now, "ME2", 450m);
            librarian1.SearchBook();
            librarian1.VerifyMember();
            librarian1.IssueBook();
            Console.WriteLine($"Total Amount (Include Fine): {librarian1.CalculateFine(8)}");
            librarian1.CreateBill(bill1);
            librarian1.ReturnBook();
            member.RetrieveMember();
            member.IncreaseBookIssue();
            member.DecreaseBookIssue();
            member.PayBill();
        }
    }
}
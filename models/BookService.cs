using System.Runtime.Intrinsics.X86;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interface_Implementation.interfaces;

namespace Interface_Implementation.models
{
    public class BookService : IBook
    {
        private string ID;
        private string Author;
        private string Name;
        private decimal Price;
        private int RackNo;
        private string Status;
        private string Edition;
        private DateTime DateOfPurchase;

        public string BookID
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        public string AuthorName
        {
            get {return Author;}
            set {Author = value;}
        }
        public string BookTitle
        {
            get {return Name;}
            set {Name = value;}
        }
        public decimal BookPrice
        {
            get {return Price;}
            set {Price = value;}
        }
        public int BookRackNo
        {
            get {return RackNo;}
            set {RackNo = value;}
        }
        public string BookStatus
        {
            get {return Status;}
            set {Status = value;}
        }
        public string BookEdition
        {
            get {return Edition;}
            set {Edition = value;}
        } 
        public DateTime PurchaseDate
        {
            get {return DateOfPurchase;}
            set {DateOfPurchase = value;}
        }
        public void DisplayBookDetails()
        {
            Console.WriteLine($"=========Book Details=========");
            Console.WriteLine($"Book ID: {BookID}");
            Console.WriteLine($"Author: {AuthorName}");
            Console.WriteLine($"Name: {BookTitle}");
            Console.WriteLine($"Price: {BookPrice}");
            Console.WriteLine($"Rack No: {BookRackNo}");
            Console.WriteLine($"Stauts: {BookStatus}");
            Console.WriteLine($"Editon: {BookEdition}");
            Console.WriteLine($"PurchaseDate: {PurchaseDate.ToShortDateString()}");
        }
        public string UpdateStatus(string IsAvailable)
        {
            Status = IsAvailable;
            return "Messege: Status Updated Successfully!";
        }
    }
}
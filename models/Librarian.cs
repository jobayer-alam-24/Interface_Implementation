using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface_Implementation.models
{
    public class Librarian
    {
        public string Name {get; set;}
        public string Password {get; set;}

        public void SearchBook()
        {
            Console.WriteLine($"Searching For Book.......");
            Thread.Sleep(4000);
            Console.WriteLine($"Found Book. Book Name: {Name}.");
            Console.WriteLine($"-----------------");
        }
        public void VerifyMember()
        {
            Console.WriteLine($"Verifying Member.......");
            Thread.Sleep(4000);
            Console.WriteLine($"Messege: Verified");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"-----------------");
        }
        public void IssueBook()
        {
            Console.WriteLine($"Issueing Book.......");
            Thread.Sleep(4000);
            Console.WriteLine($"Messege: Issued");
            Console.WriteLine($"-----------------");
        }
        public decimal CalculateFine(int dayLeft)
        {
            return dayLeft * 50;
        }
        public void CreateBill(Bill bill1)
        {
            Console.WriteLine($"Creating Bill.....");
            Thread.Sleep(4000);
            Console.WriteLine($"Bill ID: {bill1.BillNumber}");
            Console.WriteLine($"Bill Pay Date: {bill1.BillPayDate}");
            Console.WriteLine($"Member ID: {bill1.MemeberID}");
            Console.WriteLine($"Bill Amount: {bill1.BillAmount}");
            Console.WriteLine($"-----------------");
        }
        public void ReturnBook()
        {
            Console.WriteLine($"Returning Book.....");
            Thread.Sleep(4000);
            Console.WriteLine($"Messege: Bill Returned Successfully!");
            Console.WriteLine($"-----------------");
        }
    }
}
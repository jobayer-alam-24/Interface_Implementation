using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface_Implementation.models
{
    public class MemberRecord
    {
        public string MemeberID {get; set;}
        public string Memeber_Type {get; set;}
        public DateTime DateOfMembership {get; set;}
        public int MaxBookLimit {get; set;}
        public string Name {get; set;}
        public string Address {get; set;}
        public string PhoneNumber {get; set;}
            
        public void RetrieveMember()
        {
            Console.WriteLine($"Messege: Retrieved Successfully");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
        }
        public void IncreaseBookIssue()
        {
            Console.WriteLine($"Messege: Increased Book Issue.");
        }
        public void DecreaseBookIssue()
        {
            Console.WriteLine($"Messege: Decreased Book Issue.");
        }
        public void PayBill()
        {
            Console.Write($"Messege: Bill Paid");
            Console.WriteLine($"Member ID: {MemeberID}");
            Console.WriteLine($"Member Type: {Memeber_Type}");
            Console.WriteLine($"Max Book Limit: {MaxBookLimit}");
            Console.WriteLine($"Date Of Membership: {DateOfMembership}");
        }
    }
}
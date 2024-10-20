using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface_Implementation.interfaces
{
    public interface IBook
    {
        // Interface: Fully Unimplemented class
        void DisplayBookDetails();
        string UpdateStatus(string AvailableOrNot);
    }
}
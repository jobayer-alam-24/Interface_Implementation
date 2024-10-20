using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface_Implementation.interfaces
{
    public interface ITransaction
    {
        string CreateTransaction();
        void DeleteTransaction();
        void RetrieveTransaction();
    }
}
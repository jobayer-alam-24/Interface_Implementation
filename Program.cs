using Interface_Implementation.models;

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

            Console.WriteLine(book.UpdateStatus("Unavailable"));
            book.DisplayBookDetails();
            Console.WriteLine(transaction.CreateTransaction());
            transaction.DeleteTransaction();
        }
    }
}
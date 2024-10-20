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

            Console.WriteLine(book.UpdateStatus("Unavailable"));
            book.DisplayBookDetails();
        }
    }
}
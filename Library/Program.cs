using Library0;

class Program
{
    static void Main(string[] args)
    {
        // Create some books
        var book1 = new Book { Title = "badam", Author = "qoz", Year = 2001 };
        var book2 = new Book { Title = "kitabci", Author = "yazar", Year = 2002 };

        // Create a library and add books to it
        var library = new Library();
        library.AddBook(book1);
        library.AddBook(book2);

        // Display the books in the library
        library.DisplayBooks();
    }
}
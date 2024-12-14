using System.Drawing;

namespace _2._6dars.Api.HMWRK;

public class BookCollection
{
    private List<Book> _books;

    public BookCollection()
    {
        _books = new List<Book>();
    }

    public Book AddBook(Book book)
    {
        _books.Add(book);
        return book;
    }

    public List<Book> GetBooksByAuthor(string authorName)
    {
        var booksByAuthorName = new List<Book>();

        foreach (var book in _books)
        {
            if (book.Author == authorName)
            {
                booksByAuthorName.Add(book);
            }
        }

        return booksByAuthorName;
    }
}

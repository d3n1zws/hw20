using System.ComponentModel;
using ConsoleApp18.Exceptions;
namespace ConsoleApp18;

public class BookService : IBookService
{
    static List<Book> books = new List<Book>();
    public void Add(Book book)
    {
        Book? book1 = books.Find(x => x.Author == book.Author && x.Title == book.Title);
        if (book1 != null)
        {
            throw new ConflictException("bele bir kitab var");
        }
        books.Add(book);
    }
    public Book GetById(int id)
    {
        Book? book = books.Find(x => x.Id == id);
        if (book == null)
        {
            throw new NotFoundException("yanlis id");
        }
        return book;
    }
    public List<Book> GetByGenre(Genre genre)
    {
        List<Book> list = books.FindAll(x => x.Genre == genre);
        return list;
    }
    public Book GetMostExpensiveBook()
    {
        double maks = 0;
        Book ansbook = books[0];
        foreach (Book book in books)
        {
            if (book.Price > maks)
            {
                maks = book.Price;
                ansbook = book;
            }
        }
        return ansbook;
    }
    public Book GetCheapestBook()
    {
        double mini = int.MaxValue;
        Book ansbook = books[0];
        foreach (Book book in books)
        {
            if (book.Price > mini)
            {
                mini = book.Price;
                ansbook = book;
            }
        }
        return ansbook;
    }
    public double GetAveragePrice()
    {
        double x = 0;
        foreach (Book book in books)
        {
            x += book.Price;
        }
        return x / (double)books.Count;
    }
    public int CountByGenre(Genre genre) =>
         books.FindAll(x => x.Genre == genre).Count;
    public List<Book> GetByPriceRange(double min, double max) => 
        books.FindAll(x => min <= x.Price && max >= x.Price);
}



//- Eyni Title + Author ilə kitab əlavə olunarsa ConflictException atılsın

//- Tapılmayan id üçün NotFoundException atılsın

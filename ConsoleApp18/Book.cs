namespace ConsoleApp18;

public class Book
{
    static int id = 0;

    public Book(string title, string author, int pageCount, double price, int stockCount, Genre genre)
    {
        Id = ++id;
        Title = title;
        Author = author;
        PageCount = pageCount;
        Price = price;
        StockCount = stockCount;
        CreatedAt = DateTime.Now;
        Genre = genre;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PageCount { get; set; }
    public double Price { get; set; }
    public int StockCount { get; set; }
    public DateTime CreatedAt { get; set; }
    public Genre Genre { get; set; }

}



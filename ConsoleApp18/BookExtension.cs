using ConsoleApp18;

public static class BookExtensions
{
    public static string GetShortInfo(this Book book)
    {
        return $"{book.Title} - {book.Author} - {book.Price} AZN";
    }

    public static bool IsInStock(this Book book)
    {
        return book.StockCount > 0;
    }

    public static void ApplyDiscount(this Book book, double percent)
    {
        book.Price -= book.Price * percent / 100;
    }
}
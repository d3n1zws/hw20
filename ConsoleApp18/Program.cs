using ConsoleApp18;
using ConsoleApp18.Exceptions;

BookService service = new BookService();

try
{
    Book book1 = new Book(
        "Clean Code",
        "Robert Martin",
        464,
        35,
        5,
        Genre.Programming
    );

    Book book2 = new Book(
        "C# Basics",
        "John Smith",
        300,
        25,
        10,
        Genre.Programming
    );

    Book book3 = new Book(
        "A Brief History of Time",
        "Stephen Hawking",
        256,
        40,
        3,
        Genre.Science
    );

    Book book4 = new Book(
        "1984",
        "George Orwell",
        328,
        18,
        0,
        Genre.Novel
    );

    Book book5 = new Book(
        "Sapiens",
        "Yuval Noah Harari",
        443,
        30,
        4,
        Genre.History
    );

    Book book6 = new Book(
        "The Alchemist",
        "Paulo Coelho",
        208,
        15,
        6,
        Genre.Novel
    );

    service.Add(book1);
    service.Add(book2);
    service.Add(book3);
    service.Add(book4);
    service.Add(book5);
    service.Add(book6);


    Console.WriteLine("GET BY ID");

    Book foundBook = service.GetById(1);

    Console.WriteLine(foundBook.GetShortInfo());


    Console.WriteLine("\nPROGRAMMING BOOKS");

    List<Book> programmingBooks =
        service.GetByGenre(Genre.Programming);

    foreach (Book book in programmingBooks)
    {
        Console.WriteLine(book.GetShortInfo());
    }


    Console.WriteLine("\nMOST EXPENSIVE");

    Book expensive = service.GetMostExpensiveBook();

    Console.WriteLine(expensive.GetShortInfo());


    Console.WriteLine("\nCHEAPEST");

    Book cheapest = service.GetCheapestBook();

    Console.WriteLine(cheapest.GetShortInfo());


    Console.WriteLine("\nAVERAGE PRICE");

    Console.WriteLine(service.GetAveragePrice());


    Console.WriteLine("\nNOVEL COUNT");

    Console.WriteLine(
        service.CountByGenre(Genre.Novel)
    );


    Console.WriteLine("\nPRICE RANGE 20-35");

    List<Book> rangeBooks =
        service.GetByPriceRange(20, 35);

    foreach (Book book in rangeBooks)
    {
        Console.WriteLine(book.GetShortInfo());
    }


    Console.WriteLine("\nEXTENSION METHODS");

    Console.WriteLine(book1.IsInStock());

    Console.WriteLine(book1.GetShortInfo());

    book1.ApplyDiscount(20);

    Console.WriteLine(book1.GetShortInfo());
}
catch (ConflictException ex)
{
    Console.WriteLine(ex.Message);
}
catch (NotFoundException ex)
{
    Console.WriteLine(ex.Message);
}
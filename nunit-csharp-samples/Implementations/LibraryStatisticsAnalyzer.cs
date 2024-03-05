public class LibraryStatisticsAnalyzer
{
    public class LibraryStatisticsAnalyzer
{
    private readonly LibraryManager _manager;

    public LibraryStatisticsAnalyzer(LibraryManager manager)
    {
        _manager = manager;
    }
    
    /// <summary>
    /// Gets books by author.
    /// </summary>
    /// <param name="author">Book author.</param>
    /// <returns>Book list.</returns>
    public List<Book> GetBooksByAuthor(string author)
    {
        // TODO step 3.
        return [];
    }
    
    /// <summary>
    /// Gets book by title.
    /// </summary>
    /// <param name="title">Book title.</param>
    /// <returns>Book.</returns>
    public Book GetBookByTitle(string title)
    {
        // TODO step 3.
        return new Book();
    }

    /// <summary>
    /// Gets book by articul.
    /// </summary>
    /// <param name="articul">Book articul.</param>
    /// <returns>Book.</returns>
    public Book GetBookByArticul(string articul)
    {
        // TODO step 3.
        return new Book();
    }
}

    /// <summary>
    /// Тест: Перевіряє, чи повертається правильний список книг за автором.
    /// </summary>
    public void Test_GetBooksByAuthor_ReturnsCorrectListOfBooks()
    {
        string author = "Джон Доу";
        List<Book> expectedBooks = new List<Book>
        {
            new Book { Author = author, Title = "Книга 1" },
            new Book { Author = author, Title = "Книга 2" },
            new Book { Author = author, Title = "Книга 3" }
        };
        foreach (var book in expectedBooks)
        {
            _manager.AddBook(book);
        }

        List<Book> actualBooks = GetBooksByAuthor(author);

        if (expectedBooks.Count != actualBooks.Count || !expectedBooks.All(actualBooks.Contains))
        {
            throw new Exception("Помилка тестування: список повернутих книг не відповідає очікуваному.");
        }
    }
}

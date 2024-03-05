/// <summary>
/// A manager for a library's collection of books.
/// </summary>
public class LibraryManager : ILibraryManager
{
    private List<Book> _books;

    /// <summary>
    /// Adds a book to the library's collection.
    /// </summary>
    /// <param name="book">The book to add.</param>
    public void AddBook(Book book)
    {
        // TODO step 1.
        // TODO step 2.
    }

    /// <summary>
    /// Removes a book from the library's collection.
    /// </summary>
    /// <param name="book">The book to remove.</param>
    public void RemoveBook(Book book)
    {
        // TODO step 1.
    }
}

public void AddBook(Book book)
{
    // TODO step 2.
}

public void RemoveBook(Book book)
{
    // TODO step 1.
}

/// <summary>
/// Gets or sets a book articul.
/// </summary>
public string Articul { get; set; }

public List<Book> GetBooksByAuthor(string author)
{
    // TODO step 3.
    return [];
}
    
public Book GetBookByTitle(string title)
{
    // TODO step 3.
    return new Book();
}

public Book GetBookByArticul(string articul)
{
    // TODO step 3.
    return new Book();
}
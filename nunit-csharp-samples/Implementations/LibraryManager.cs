public class LibraryManager : ILibraryManager
{
    /// <summary>
/// A manager for a library's collection of books.
/// </summary>
public class LibraryManager : ILibraryManager
{
    private List<Book> _books;

public class LibraryManager : ILibraryManager
{
    public class LibraryManager : ILibraryManager
{
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

    /// <summary>
    /// Тест: Перевіряє, що книга успішно додається до списку книг.
    /// </summary>
    public void Test_AddBook_AddsBookToList()
    {
        Book bookToAdd = new Book(); // Створюємо новий екземпляр книги
        AddBook(bookToAdd); // Додаємо книгу
        if (!_books.Contains(bookToAdd))
        {
            throw new Exception("Помилка тестування: книга не була додана до списку.");
        }
    }

    /// <summary>
    /// Тест: Перевіряє, що книга успішно видаляється зі списку книг.
    /// </summary>
    public void Test_RemoveBook_RemovesBookFromList()
    {
        Book bookToRemove = new Book(); // Створюємо новий екземпляр книги
        AddBook(bookToRemove); // Додаємо книгу до списку
        RemoveBook(bookToRemove); // Видаляємо книгу
        if (_books.Contains(bookToRemove))
        {
            throw new Exception("Помилка тестування: книга не видалена зі списку.");
        }
    }
}

    /// <summary>
    /// Тест: Перевіряє, що книга успішно додається до списку книг.
    /// </summary>
    public void Test_AddBook_AddsBookToList()
    {
        Book bookToAdd = new Book(); // Створюємо новий екземпляр книги
        AddBook(bookToAdd); // Додаємо книгу
        if (!_books.Contains(bookToAdd))
        {
            throw new Exception("Помилка тестування: книга не була додана до списку.");
        }
    }

    /// <summary>
    /// Тест: Перевіряє, що книга успішно видаляється зі списку книг.
    /// </summary>
    public void Test_RemoveBook_RemovesBookFromList()
    {
        Book bookToRemove = new Book(); // Створюємо новий екземпляр книги
        AddBook(bookToRemove); // Додаємо книгу до списку
        RemoveBook(bookToRemove); // Видаляємо книгу
        if (_books.Contains(bookToRemove))
        {
            throw new Exception("Помилка тестування: книга не видалена зі списку.");
        }
    }
}


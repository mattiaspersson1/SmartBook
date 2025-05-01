using System.Text.Json;

namespace SmartBook;

public class Library
{
    public List<Book> Books { get; set; } = new();

    public bool AddBook(Book book)
    {
        if (Books.Any(b => b.ISBN == book.ISBN))
            return false;
        Books.Add(book);
        return true;
    }

    public bool RemoveBook(string identifier)
    {
        var book = Books.FirstOrDefault(b => b.Title.Equals(identifier, StringComparison.OrdinalIgnoreCase) || b.ISBN == identifier);
        if (book == null)
            return false;
        Books.Remove(book);
        return true;
    }

    public IEnumerable<Book> ListBooks() =>
        Books.OrderBy(b => b.Title);

    public IEnumerable<Book> Search(string keyword) =>
        Books.Where(b => b.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                         b.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase));

    public bool ToggleBorrowStatus(string isbn)
    {
        var book = Books.FirstOrDefault(b => b.ISBN == isbn);
        if (book == null)
            return false;
        book.IsBorrowed = !book.IsBorrowed;
        return true;
    }

    public void SaveToFile(string path)
    {
        var json = JsonSerializer.Serialize(Books);
        File.WriteAllText(path, json);
    }

    public void LoadFromFile(string path)
    {
        if (!File.Exists(path)) return;
        var json = File.ReadAllText(path);
        var loadedBooks = JsonSerializer.Deserialize<List<Book>>(json);
        if (loadedBooks != null)
            Books = loadedBooks;
    }
}
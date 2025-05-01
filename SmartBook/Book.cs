namespace SmartBook;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public string Category { get; set; }
    public bool IsBorrowed { get; set; }

    public Book(string title, string author, string isbn, string category)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Category = category;
        IsBorrowed = false;
    }

    public override string ToString()
    {
        return $"\"{Title}\" by {Author} (ISBN: {ISBN}) - {Category} - " + (IsBorrowed ? "Borrowed" : "Available");
    }
}
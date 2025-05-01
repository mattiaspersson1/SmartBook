namespace SmartBook;

public class LibraryApp
{
    private readonly Library _library = new();
    private const string FilePath = "library.json";

    public void Run()
    {
        _library.LoadFromFile(FilePath);
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nSmartBook Library System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. List Books");
            Console.WriteLine("4. Search Book");
            Console.WriteLine("5. Toggle Borrow Status");
            Console.WriteLine("6. Save and Exit");
            Console.Write("Select an option: ");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1": AddBook(); break;
                case "2": RemoveBook(); break;
                case "3": ListBooks(); break;
                case "4": SearchBook(); break;
                case "5": ToggleBorrowStatus(); break;
                case "6":
                    _library.SaveToFile(FilePath);
                    running = false;
                    break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }

    private void AddBook()
    {
        try
        {
            Console.Write("Title: ");
            string title = Console.ReadLine() ?? "";
            Console.Write("Author: ");
            string author = Console.ReadLine() ?? "";
            Console.Write("ISBN: ");
            string isbn = Console.ReadLine() ?? "";
            Console.Write("Category: ");
            string category = Console.ReadLine() ?? "";

            var book = new Book(title, author, isbn, category);
            if (_library.AddBook(book))
                Console.WriteLine("Book added.");
            else
                Console.WriteLine("A book with the same ISBN already exists.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    private void RemoveBook()
    {
        Console.Write("Enter Title or ISBN to remove: ");
        string input = Console.ReadLine() ?? "";
        if (_library.RemoveBook(input))
            Console.WriteLine("Book removed.");
        else
            Console.WriteLine("Book not found.");
    }

    private void ListBooks()
    {
        foreach (var book in _library.ListBooks())
            Console.WriteLine(book);
    }

    private void SearchBook()
    {
        Console.Write("Enter title or author to search: ");
        string keyword = Console.ReadLine() ?? "";
        var results = _library.Search(keyword);
        foreach (var book in results)
            Console.WriteLine(book);
    }

    private void ToggleBorrowStatus()
    {
        Console.Write("Enter ISBN to toggle borrow status: ");
        string isbn = Console.ReadLine() ?? "";
        if (_library.ToggleBorrowStatus(isbn))
            Console.WriteLine("Borrow status updated.");
        else
            Console.WriteLine("Book not found.");
    }
}
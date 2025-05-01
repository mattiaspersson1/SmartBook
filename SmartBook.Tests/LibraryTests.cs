using SmartBook;
using Xunit;

namespace SmartBook.Tests;

public class LibraryTests
{
    [Fact]
    public void AddBook_ShouldAddBookToList()
    {
        var lib = new Library();
        var book = new Book("Test", "Author", "123", "Fiction");

        bool added = lib.AddBook(book);

        Assert.True(added);
        Assert.Contains(book, lib.Books);
    }

    [Fact]
    public void Search_ShouldFindBookByTitle()
    {
        var lib = new Library();
        var book = new Book("C# Basics", "Jane Doe", "456", "Programming");
        lib.AddBook(book);

        var results = lib.Search("C#").ToList();

        Assert.Single(results);
        Assert.Equal("456", results[0].ISBN);
    }
}
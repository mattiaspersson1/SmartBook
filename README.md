# SmartBook Library System

A console-based library management system built in C#. This application allows users to manage a book collection through a menu interface.

## Features

- Add a book (title, author, ISBN, category)
- Remove a book (by title or ISBN)
- List all books (sorted by title using LINQ)
- Search for a book (by title or author using LINQ)
- Mark a book as "borrowed" or "available"
- Save and load the library from a JSON file
- Validation to prevent duplicate ISBNs

## Technologies

- .NET 8 (latest)
- xUnit for unit testing
- System.Text.Json for file handling

## How to Run

1. Open the solution in Visual Studio 2022+.
2. Build the solution.
3. Run the `SmartBook` project.

## Testing

Run the `SmartBook.Tests` project to execute unit tests.

Tests included:
- AddBook correctly adds a book
- Searching by title or author works as expected
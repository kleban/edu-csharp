
using LibraryApp;

Library library = new Library();
Console.ForegroundColor = ConsoleColor.White;

while (true)
{
    Console.WriteLine(" --- NAVIGATION ---");
    Console.WriteLine("\t[A]dd Book");
    Console.WriteLine("\t[R]emove Book");
    Console.WriteLine("\t[L]ist Books");
    Console.WriteLine("\tE[x]it");
    Console.Write("\nSelect an option: ");

    string option = Console.ReadLine().ToUpper();

    switch(option)
    {
        case "A":
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book author: ");
            string author = Console.ReadLine();
            Console.Write("Enter book ISBN: ");
            string isbn = Console.ReadLine();
            Console.Write("Enter book year: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.Write("Invalid input. Please enter a valid year: ");
            }
            library.AddBook(new Book { Title = title, Author = author, ISBN = isbn, Year = year });
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Book succesfully added!");
            Console.ForegroundColor = ConsoleColor.White;
            break;
        case "R":
            Console.Write("Enter the ISBN of the book to remove: ");
            string isbnToRemove = Console.ReadLine();
            if(library.RemoveBook(isbnToRemove))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Book successfully removed!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Book not found.");
            }
            Console.ForegroundColor = ConsoleColor.White;
            break;
        case "L":           
            Console.WriteLine("Books in the library:");
            foreach (var book in library.GetAllBooks())
            {
                Console.WriteLine("\t- " + book);
            }
            break;
        case "X":
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Exiting the application...");
            Console.ForegroundColor = ConsoleColor.White;
            return;
    }
}

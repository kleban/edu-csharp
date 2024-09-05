
using InterfacesDemo2;

BookReaderInitializer init = new BookReaderInitializer(new RemoteAPIBookReader());
init = new BookReaderInitializer(new TextBookReader());

// 
List<Book> books = init.Reader.ReadBooks();

books.ForEach(book => Console.WriteLine(book.Title));
using BookApp;

Book b1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);
Book b2 = new Book("To Kill a Mockingbird", "Harper Lee", 1281);

b1.PrintInfo();
b2.PrintInfo();

Console.WriteLine(b2.IsLongBook());
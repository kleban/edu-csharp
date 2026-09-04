
using CollectionsDemo2;

var books = new List<Book>
{
    new Book { Id = 1,  Name = "Don Quixote",              Author = "Miguel de Cervantes",  Year = 1605, Pages = 863  },
    new Book { Id = 2,  Name = "The Divine Comedy",        Author = "Dante Yaroslav Alighieri",      Year = 1320, Pages = 798  },
    new Book { Id = 3,  Name = "Hamlet",                   Author = "William Shakespeare",  Year = 1603, Pages = 172  },
    new Book { Id = 4,  Name = "Madame Bovary",            Author = "Gustave Ivan Flaubert",     Year = 1857, Pages = 329  },
    new Book { Id = 5,  Name = "Faust",                    Author = "Johann Goethe",        Year = 1808, Pages = 464  },
    new Book { Id = 6,  Name = "The Odyssey",              Author = "Homer",                Year = -800, Pages = 374  },
    new Book { Id = 7,  Name = "Moby-Dick",                Author = "Herman-Melville",      Year = 1851, Pages = 635  },
    new Book { Id = 8,  Name = "Jane Eyre",                Author = "Charlotte Brontë",     Year = 1847, Pages = 532  },
    new Book { Id = 9,  Name = "The Iliad",                Author = "Homer",                Year = -750, Pages = 683  },
    new Book { Id = 10, Name = "Great Expectations",       Author = "Charles Dickens",      Year = 1861, Pages = 544  },
    new Book { Id = 11, Name = "The Scarlet Letter",       Author = "Nathaniel Hawthorne",  Year = 1850, Pages = 238  },
    new Book { Id = 12, Name = "Middlemarch",              Author = "George Eliot",         Year = 1872, Pages = 904  },
    new Book { Id = 13, Name = "Les Misérables",           Author = "Victor Hugo",          Year = 1862, Pages = 1463 },
    new Book { Id = 14, Name = "The Count of Monte Cristo",Author = "Alexandre Dumas",      Year = 1844, Pages = 1276 },
    new Book { Id = 15, Name = "Wuthering Heights",        Author = "Emily Brontë",         Year = 1847, Pages = 342  },
    new Book { Id = 16, Name = "Treasure Island",          Author = "Robert Louis Stevenson",Year = 1883, Pages = 292  },
};

var chat = new OpenAIChatClient(apiKey: "<ADD_OPEN_AI_API_KEY_HERE>");

Console.WriteLine("Chat started. Type 'exit' to quit.\n");

var prompt = "Ти отримаєш список авторів класичних творів. Поверни найвідоміші цитати з їх творів у форматі {author, novel, cite, cite_in_ukrainian}.\n Список авторів: ";
var input = prompt + string.Join(",", books.Select(x => x.Author));

string reply = await chat.SendMessageAsync(input);
Console.WriteLine(reply);

//printBooks(books);

//books = books.OrderBy(x=> x.Year).ToList();

//var listShort = books.Select(x => new ShortBook { Name = x.Name, Author = x.Author }).ToList();

//printBooks(books);

//int longestBookTitle = books.Select(x => x.Name).Max(x => x.Count()) + 10;

//foreach (var book in listShort)
//{
//    Console.WriteLine($"{book.Name.PadRight(longestBookTitle)}\t{book.Author}");
//}

//printBooks(books.OrderBy(x=> x.Name).ToList());
//printBooks(books.Where(x=> x.Pages >= 1000).ToList());

//var listX = books.Where(x=> x.Author.C)
static void printBooks(List<Book> books)
{
    Console.WriteLine("++++++++++++++++++++++++++++++");
    foreach (Book book in books)
    {
        Console.WriteLine(book);
    }
}
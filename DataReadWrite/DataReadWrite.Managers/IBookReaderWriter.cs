using DataReadWrite.Domain;

namespace DataReadWrite.Managers
{
    public interface IBookReaderWriter
    {
        IEnumerable<Book> Read(string path);    
        void Write(IEnumerable<Book> books, string path);
    }
}

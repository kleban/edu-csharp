using Data;
using System.Data;

namespace Manager
{
  //  Написати програму, що дозволяє зчитати та записати текстовий файл 
   //     з інформацією про товари.

//Читання та запис даних виокремити у спеціальний клас
//ProductTextReader (IDataReader?)

//Відкривання, зберігання файлів реалізувати за допомогою діалогів

    public interface IProductManager
    {
        List<Product> Read(string path);
        void Write(string path, List<Product> products);
    }
}

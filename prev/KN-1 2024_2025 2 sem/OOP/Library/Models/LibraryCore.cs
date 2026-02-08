using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class LibraryCore
    {
        private PrintedEntity[] entities;
        private Author[] authors;
        private Publisher[] publishers;
        public LibraryCore()
        {
            entities = new PrintedEntity[0];
            _init();
        }

        private void _init()
        {
            //
        }

        public PrintedEntity[] Entities { get { return entities; } }

        public void AddEntity(PrintedEntity entity)
        {
            Array.Resize(ref entities, entities.Length + 1);
            entities[entities.Length - 1] = entity;
        }

        public PrintedEntity[] Find(string title)
        {
            return null;
        }


    }
}

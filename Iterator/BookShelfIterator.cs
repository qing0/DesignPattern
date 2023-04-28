using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class BookShelfIterator : IIterator
    {
        private BookShelf bookShelf;
        private int index;
        public BookShelfIterator(BookShelf bookShelf)
        { 
            this.bookShelf = bookShelf;
        }

        public bool HasNext()
        {
            if (index < bookShelf.GetCount())
            {
                return true;
            }
            return false;
        }

        public object Next()
        {
            Book book=bookShelf.GetBook(index);
            index++;
            return book;
        }
    }
}

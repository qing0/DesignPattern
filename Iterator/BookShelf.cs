using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /// <summary>
    /// 书架 包含书本的添加、获取书名、迭代器
    /// </summary>
    internal class BookShelf:Aggeragate
    {
        public List<Book> Books{ get; set; }
        public BookShelf()
        {
            this.Books= new List<Book>();
        }
        public int GetCount()
        {
            return this.Books.Count;
        }
        public Book GetBook(int index)
        {
            return this.Books[index];
        }
        public void AppendBook(Book book)
        {
            this.Books.Add(book);
        }
        public IIterator Iterator()
        {
            return new BookShelfIterator(this);
        }
    }
}

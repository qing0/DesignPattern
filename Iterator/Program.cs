// See https://aka.ms/new-console-template for more information
//迭代器 将集合实体类与迭代器解耦
using Iterator;

BookShelf bookShelf=new BookShelf();
bookShelf.AppendBook(new Book("C#"));
bookShelf.AppendBook(new Book("JAVA"));
bookShelf.AppendBook(new Book("C++"));
bookShelf.AppendBook(new Book("Python"));


IIterator iit = new BookShelfIterator(bookShelf);

IIterator iterator=bookShelf.Iterator();

while (iterator.HasNext())
{
    Book book = (Book)iterator.Next();
    Console.WriteLine(book.Name);
}
using System;
using System.Linq;

namespace Arrays
{
    class Book
    {
        public Book(string author, string title, ushort yearOfPublication)
        {
            Author = author;
            code = Convert.ToString(++counter);
            Title = title;
            YearOfPublication = yearOfPublication;
        }
        private string author;
        private string code;
        private string title;
        private static int counter=0;
        const int minYear = 1900;
        private ushort yearOfPublication;
        public static explicit operator CoverBook(Book book) => new CoverBook(book.Author, book.Title, book.YearOfPublication);
        public static explicit operator Book(CoverBook cover) => new Book(cover.Author, cover.Name, cover.Year);
        public Book() : this("No author", "Noname", 0) { }
        public override string ToString()
        {
            return ($"Author : {author}, Code : {code}, Name : {title}, Year : {yearOfPublication}");
        }
        private bool IsValidIndex(int index) => index >= 0;
        public string this[int index]
        {
            get
            {
                if (index == Convert.ToInt32(code))
                {
                    if (!IsValidIndex(index))
                    {
                        throw new Exception($"Invalid index. ({index})");
                    }
                    return $"({ToString()}) by index {index}";
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public string Author
        {
            get => author;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    author = value;
                }
            }
        }
        public string Сode
        {
            get => code;
            set
            {
                if (value.All(c => char.IsLetterOrDigit(c)))
                {
                    if (value.Length>3&& value.Length<7)
                    {
                        code = value;
                    }
                }
            }
        }
        public string Title
        {
            get => title;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                   title = value;
                }
            }
        }
        public ushort YearOfPublication
        {
            get => yearOfPublication;
            set
            {
                if (value > minYear)
                {
                    yearOfPublication = value;
                }
            }
        }
        public void setValues(string author, string name, ushort year)
        {
            this.author = author;
            this.title = name;
            this.yearOfPublication = year;
        }
        public void print()
        {
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"Authot : {author}");
            Console.WriteLine($"Year of publication : {yearOfPublication}");
            Console.WriteLine($"Cipher : {code}");
        }
    }

    class Liblary
    {
        private Book[] books;
        private readonly string name = "Some name";
        int count = 0;
        public Liblary()
        {
            books = new Book[0];
        }
        public int Count
        {
            get => count;

        }
        private bool IsValidIndex(int index) => index >= 0;
        public Book this[int index]
        {
            get
            {
                if (!IsValidIndex(index))
                {
                    throw new Exception($"Invalid index. ({index})");
                }
                return books[index];
            }
            set
            {
                if (!IsValidIndex(index))
                {
                    throw new Exception($"Invalid index. ({index})");
                }
                string author = Console.ReadLine();
                string name = Console.ReadLine();
                ushort year = ushort.Parse(Console.ReadLine());
                books[index].setValues(author, name, year);
            }
        }
        public Book this[string index]
        {
            get
            {
                int id = Convert.ToInt32(index);
                if (id == Convert.ToInt32(books[id].Сode))
                {
                    return books[id];
                }
                else
                {
                    throw new Exception($"Invalid index. ({index ?? "null"})");
                }
            }
            set
            {
                int id = Convert.ToInt32(index);
                if (id == Convert.ToInt32(books[id].Сode))
                {
                    string author = Console.ReadLine();
                    string name = Console.ReadLine();
                    ushort year = ushort.Parse(Console.ReadLine());
                    books[id].setValues(author, name, year);
                }
            }
        }
        public void addBook(Book book)
        {
            if (book != null)
            {
                Array.Resize(ref books, books.Length + 1);
                books[books.Length - 1] = book;
            }
            count++;
        }
        public void removeBookByCipher(string cipher)
        {
            int index = Array.FindIndex(books, e => e.Сode == cipher);
            if (index != -1)
            {
                Book[] temp = new Book[books.Length - 1];
                Array.Copy(books, temp, index);

                Array.Copy(books, index, temp, books.Length - 1, books.Length - index - 1);
                books = new Book[temp.Length];
                books = temp;
            }
            count--;
        }
        public void SortByAuthor()
        {
            Array.Sort(books, (e, e2) => String.Compare(e.Author, e2.Author));
        }
        public void SortByAuthorAndYearPublication()
        {
            SortByAuthor();
            Array.Sort(books, (e, e2) => (e.YearOfPublication.CompareTo(e2.YearOfPublication)));

        }
        public Book SearchByAuthor(string author)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Books written by {author} :");
            Console.WriteLine();
            Book temp = Array.Find(books, e => e.Author == author);
            if (temp != null)
            {
                return temp;
            }
            else
            {
                throw new Exception("didn't find book by author " + author);

            }
        }
        public Book SearchByTitle(string title)
        {
            Console.WriteLine();
            Book temp = Array.Find(books, e => e.Title == title);
            if (temp != null)
            {
                return temp;
            }
            else
            {
                throw new Exception("didn't find book by title " + title);

            }

        }
        public void print()
        {
            if (books.Length > 0)
            {
                Console.WriteLine("#########################");
                foreach (var item in books)
                {
                    item.print();
                    Console.WriteLine("#########################");
                }
            }
        }
    }
   
}
class CoverBook
{
    public string Author { get; set; }
    public string Name { get; set; }
    public ushort Year { get; set; }

    public CoverBook(string author, string name, ushort year)
    {
        Author = author;
        Name = name;
        Year = year;
    }
    public CoverBook() : this("No author", "Noname", 0) { }
}
namespace Home_Work_C_Sharp_Arrays_Book_
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays.Liblary lib = new Arrays.Liblary();
            lib.addBook(new Arrays.Book("Rowling", "Harry Potter", 1997));
            lib.addBook(new Arrays.Book("Orwel",  "1984", 1948));
            Arrays.Book b = new Arrays.Book("Tolkien","The Lord of rings", 1954);
            CoverBook cb = new CoverBook();
            
            
            lib.addBook(b);
            lib.SortByAuthor();
            lib.print();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //lib.SortByAuthorAndYearPublication();
            //lib.print();
            //Arrays.Book book = lib.SearchByAuthor("Tolkien");
            //book.print();
            //Console.WriteLine();
            //Console.WriteLine($"Count :{lib.Count}");
            cb = (CoverBook)b;
            b = (Arrays.Book)cb;

        }
    }
}


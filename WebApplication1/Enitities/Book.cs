namespace WebApplication1.Enitities
{
    public class Book
    {
        public BookId id { get; set; }

        public string value { get; set; }

        public Book(BookId id)
        {
            this.id = id;
        }
    }
    
    public class BookId
    {
        public readonly int id;

        public BookId(int id)
        {
            this.id = id;
        }
    }
}
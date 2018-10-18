namespace WebApplication1.Entities
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

        public override bool Equals(object obj)
        {
            if (!(obj is BookId item))
            {
                return false;
            }

            return id == item.id;
        }

        public override int GetHashCode()
        {
            return id.GetHashCode();
        }

        public static bool operator ==(BookId left, BookId right)
        {
            return left?.id == right?.id;
        }

        public static bool operator !=(BookId left, BookId right)
        {
            return !(left == right);
        }
    }
}
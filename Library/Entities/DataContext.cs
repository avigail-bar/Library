namespace Library.Entities
{
    public class DataContext
    {
        public static List<Reader> Readers { get; set; }
        public static List<Question> Questions { get; set; }

        public static List<Book> Books { get; set; }
        public DataContext()
        {
            Readers = new List<Reader>();
            Questions = new List<Question>();
            Books = new List<Book> {
                new Book { Id=1,Name="bbb",Author="b"},
                new Book { Id=2,Name="bbb",Author="b"},
                new Book { Id=3,Name="bbb",Author="b"}

                };
        }
    }
}

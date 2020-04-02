using SQLite;

namespace ESIBIB_Student.Models
{
    [Table("Books")]
    class Book
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Available { get; set; }
        public string ISBN { get; set; }
        public string Coverurl { get; set; }
    }
}

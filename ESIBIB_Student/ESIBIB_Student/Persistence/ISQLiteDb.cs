using SQLite;

namespace ESIBIB_Student
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}


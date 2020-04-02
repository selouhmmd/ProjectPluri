using SQLite;

namespace ESIBIB_Admin
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}


using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using ESIBIB_Admin.Droid;

[assembly: Dependency(typeof(SQLiteDb))]

namespace ESIBIB_Admin.Droid
{
	public class SQLiteDb : ISQLiteDb
	{
		public SQLiteAsyncConnection GetConnection()
		{
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			var path = Path.Combine(documentsPath, "MySQLite.db3");

			return new SQLiteAsyncConnection(path);
		}
	}
}


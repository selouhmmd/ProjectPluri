using ESIBIB_Student.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESIBIB_Student.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdvancedSearch : ContentPage
    {

        private SQLiteAsyncConnection _connection;

        public AdvancedSearch()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await _connection.CreateTableAsync<Book>();
            var books = await _connection.Table<Book>().ToListAsync();
            var bks = books.Where(b => (b.Title.ToLower().Contains(title.Text)) && b.Author.ToLower().Contains(author.Text) && b.Description.ToLower().Contains(description.Text));
            await Navigation.PushAsync(new SearchResult(bks.ToList()));
        }
    }
}
using ESIBIB_Student.Models;
using ESIBIB_Student.Persistence;
using Firebase.Database;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESIBIB_Student.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BooksList : ContentPage
    {
        private ObservableCollection<Book> _books;
        private SQLiteAsyncConnection _connection;

        internal ObservableCollection<Book> Books { get => _books; set => _books = value; }

        FirebaseHelper firebaseHelper = new FirebaseHelper();


        public BooksList()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await _connection.CreateTableAsync<Book>();
            var books = await _connection.Table<Book>().ToListAsync();
            _books = new ObservableCollection<Book>(books);
            bookList.ItemsSource = _books;
        }

        private async void bookList_Refreshing(object sender, EventArgs e)
        {
            var allBOOKs = await firebaseHelper.GetAllBooks();
            await _connection.DropTableAsync<Book>();
            await _connection.CreateTableAsync<Book>();
            await _connection.InsertAllAsync(allBOOKs);
            bookList.ItemsSource = allBOOKs;
            bookList.EndRefresh();
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }


        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }


        private void bookList_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
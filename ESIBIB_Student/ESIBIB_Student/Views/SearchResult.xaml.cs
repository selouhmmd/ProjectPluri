﻿using ESIBIB_Student.Models;
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
    public partial class SearchResult : ContentPage
    {
        public SearchResult(List<Book> books)
        {
            InitializeComponent();
            bookList.ItemsSource = books;
        }

        private async void bookList_ItemTapped(object sender, ItemTappedEventArgs e)
        { 
            var book = e.Item as Book;
            await Navigation.PushAsync(new BookView(book));
        }
    }
}
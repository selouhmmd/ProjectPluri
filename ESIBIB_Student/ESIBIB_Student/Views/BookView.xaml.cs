using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESISBA.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ESISBA.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookView : ContentPage
    {
        public BookView(Book book)
        {
            if (book == null)
                throw new ArgumentNullException();

            InitializeComponent();
            BindingContext = book;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Sending Email Request", "Do You Want To Request This Book", "Yes", "No");
        }
    }
}
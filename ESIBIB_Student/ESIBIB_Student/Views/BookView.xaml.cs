using ESIBIB_Student.Models;
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
    public partial class BookView : ContentPage
    {
        public BookView(Book bk)
        {
            if (bk == null)
                throw new ArgumentNullException();
            InitializeComponent();
            BindingContext = bk;
        }
    }
}
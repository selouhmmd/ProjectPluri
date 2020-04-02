using ESIBIB_Student.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ESIBIB_Student
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BooksList());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            // Here Goes The Code For Extra Features That Needs The Student To Be Logged In To BE Exact Here Goes The COnnect to google part
        }
    }
}

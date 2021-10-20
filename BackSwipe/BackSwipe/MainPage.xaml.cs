using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BackSwipe
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {
            var page = new PageWithNavigationBar();
            await Navigation.PushAsync(page);
        }
    }
}

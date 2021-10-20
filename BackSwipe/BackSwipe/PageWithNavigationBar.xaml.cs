using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BackSwipe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageWithNavigationBar : ContentPage
    {
        public PageWithNavigationBar()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
        }
    }
}
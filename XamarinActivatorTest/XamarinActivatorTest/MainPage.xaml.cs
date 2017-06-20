using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinActivatorTest
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel model;
        public MainPage()
        {
            InitializeComponent();
            model = new MainPageViewModel();
            BindingContext = model;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
             model.IsBusy = !model.IsBusy;
          // ACT.IsRunning = !ACT.IsRunning;
            //Act.IsRunning = false;
            //Act.IsVisible = false;
        }
    }
}

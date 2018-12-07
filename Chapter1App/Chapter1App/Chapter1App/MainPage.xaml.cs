using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chapter1App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Content = new Label
            {
                Text = "HI Xamarin.Forms!"
            };

            Padding = new Thickness(0, 40, 0, 0);
        }
    }
}

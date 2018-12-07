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

            var colors = new[]
            {
                new { value = Color.White, name = "White"},
                new { value = Color.Silver, name = "Silver"},
                new { value = Color.Gray, name = "Gray" },
                new { value = Color.Red, name = "Red" }
            };

            StackLayout stackLayout = new StackLayout();

            foreach( var color in colors)
            {
                stackLayout.Children.Add(
                    new Label
                    {
                        Text = color.name,
                        TextColor = color.value,
                        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            
                    });
            }

            Padding = new Thickness(50, Device.OnPlatform(20, 5, 5), 5, 5);
            Content = stackLayout;

        }
    }
}

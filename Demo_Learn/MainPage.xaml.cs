using Demo_Learn.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo_Learn
{
    public partial class MainPage : ContentPage
    {   
        public MainPage()
        {
            InitializeComponent();
            slider.Value = 0.3;
            Padding = new Thickness(20, 20, 20, 20);
            //Content = new Label
            //{
            //    Text = "Hello, World!",
            //    HorizontalOptions = LayoutOptions.Center,
            //    TextColor = Color.Orange,
            //    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            //    VerticalOptions = LayoutOptions.Center
            //};
        }
        // change a value when slider change
        //public void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        //{
        //    double value = args.NewValue;
        //    value = Math.Round(value, 1);
        //    label.Text = string.Format("Value is : {0:F2}",value.ToString());
        //}
        // next page 
        public void PageExercice(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Exo());
        }
    }
}

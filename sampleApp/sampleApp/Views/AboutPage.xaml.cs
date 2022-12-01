using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sampleApp.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void MyButton_Clicked(object sender, EventArgs e)
        {
            MyLabel.Text = "Hello, World";
        }
    }
}
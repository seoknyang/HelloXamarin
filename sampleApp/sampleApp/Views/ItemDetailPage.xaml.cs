using sampleApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace sampleApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
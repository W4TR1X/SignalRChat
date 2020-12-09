using SignalR.UI.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SignalR.UI.Mobile.Views
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
using System.ComponentModel;
using Xamarin.Forms;
using ZNO_ukr_mobile.ViewModels;

namespace ZNO_ukr_mobile.Views
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
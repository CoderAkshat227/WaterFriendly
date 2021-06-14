using BSMHackathon.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BSMHackathon.Views
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
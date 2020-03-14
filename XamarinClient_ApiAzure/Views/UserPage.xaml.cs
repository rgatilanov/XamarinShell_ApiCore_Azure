using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinClient_ApiAzure.ViewModels;

namespace XamarinClient_ApiAzure.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        UserViewModel viewModel;
        public UserPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new UserViewModel();
        }

        async void ItemsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Models.User;
            if (item == null)
                return;
            string UserName = item.Name;
            await Shell.Current.GoToAsync($"userdetails?name={UserName}");
            ItemsListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
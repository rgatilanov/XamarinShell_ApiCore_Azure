using System;
using System.Collections.Generic;

using System.Text;

namespace XamarinClient_ApiAzure.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Threading.Tasks;
    using Xamarin.Forms;
    using XamarinClient_ApiAzure.Models;

    public class UserViewModel: BaseViewModel
    {
        public ObservableCollection<User> SearchResults { get; private set; }
        public ObservableCollection<User> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public UserViewModel()
        {
            Title = "Users from WebApi on Azure";
            Items = new ObservableCollection<User>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataUser.GetUserAsync();
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex){ }
            finally
            {
                IsBusy = false;
            }
        }
    }
}

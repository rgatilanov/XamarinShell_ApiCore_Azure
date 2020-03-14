using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinClient_ApiAzure.Services;

namespace XamarinClient_ApiAzure
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public IDataUser<Models.User> DataUser => DependencyService.Get<IDataUser<Models.User>>();
        public AppShell()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}

using System;
using System.Collections.Generic;
using DemoCOMSOLiD.Models;
using DemoCOMSOLiD.ViewModels;
using Xamarin.Forms;

namespace DemoCOMSOLiD.Views
{
    public partial class ChatsPage : ContentPage
    {
        readonly ChatsPageViewModel _vm;
        public ChatsPage()
        {
            InitializeComponent();
            this.BindingContext = _vm = new ChatsPageViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as ChatModel;

            Navigation.PushAsync(new SingleChatPage(item));
        }
    }
}

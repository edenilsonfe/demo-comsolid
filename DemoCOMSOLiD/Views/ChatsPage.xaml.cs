using System;
using System.Collections.Generic;
using DemoCOMSOLiD.Models;
using DemoCOMSOLiD.ViewModels;
using Xamarin.Forms;

namespace DemoCOMSOLiD.Views
{
    public partial class ChatsPage : ContentPage
    {
        readonly ChatPageViewModel _vm;
        public ChatsPage()
        {
            InitializeComponent();
            this.BindingContext = _vm = new ChatPageViewModel();
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as ChatModel;

            DisplayAlert("", item.Name, "Ok");
        }
    }
}

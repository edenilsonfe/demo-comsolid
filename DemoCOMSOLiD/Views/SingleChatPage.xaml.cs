using System;
using System.Collections.Generic;
using DemoCOMSOLiD.Models;
using DemoCOMSOLiD.ViewModels;
using Xamarin.Forms;

namespace DemoCOMSOLiD.Views
{
    public partial class SingleChatPage : ContentPage
    {
        readonly SingleChatPageViewModel _vm;
        public SingleChatPage(ChatModel chatModel)
        {
            InitializeComponent();
            this.BindingContext = _vm = new SingleChatPageViewModel(chatModel);
        }
    }
}

using System;
using System.Collections.Generic;
using DemoCOMSOLiD.ViewModels;
using Xamarin.Forms;

namespace DemoCOMSOLiD.Views
{
    public partial class CallsPage : ContentPage
    {
        readonly CallsPageViewModel _vm;
        public CallsPage()
        {
            InitializeComponent();
            this.BindingContext = _vm = new CallsPageViewModel();
        }
    }
}

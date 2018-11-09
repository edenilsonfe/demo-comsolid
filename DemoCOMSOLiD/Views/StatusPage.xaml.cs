using System;
using System.Collections.Generic;
using DemoCOMSOLiD.ViewModels;
using Xamarin.Forms;

namespace DemoCOMSOLiD.Views
{
    public partial class StatusPage : ContentPage
    {
        readonly StatusPageViewModel _vm;
        public StatusPage()
        {
            InitializeComponent();
            this.BindingContext = _vm = new StatusPageViewModel();
        }
    }
}

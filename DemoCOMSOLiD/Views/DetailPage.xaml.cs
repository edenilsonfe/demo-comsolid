using System;
using System.Collections.Generic;
using DemoCOMSOLiD.ViewModels;
using Xamarin.Forms;

namespace DemoCOMSOLiD.Views
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();
            BindingContext = new DetailPageViewModel();
        }
    }
}

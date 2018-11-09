using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoCOMSOLiD.Views
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            CurrentPage = Children[1];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DemoCOMSOLiD.Models;
using Xamarin.Forms;

namespace DemoCOMSOLiD.Components
{
    public partial class UserMessageView : ContentView
    {
        public UserMessageView()
        {
            InitializeComponent();
        }

        public ChatModel Chat { get { return (ChatModel)GetValue(ChatProperty); } set { SetValue(ChatProperty, value); } }
        public static readonly BindableProperty ChatProperty = BindableProperty.Create(nameof(Chat), typeof(ChatModel), typeof(UserMessageView), null);

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == ChatProperty.PropertyName)
            {
                UpdateFields();
            }
        }

        void UpdateFields()
        {
            lblMessage.Text = Chat.Message;
        }
    }
}

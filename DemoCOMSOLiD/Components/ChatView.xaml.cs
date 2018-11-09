using System.Runtime.CompilerServices;
using Badge.Plugin;
using DemoCOMSOLiD.Models;
using Xamarin.Forms;

namespace DemoCOMSOLiD.Components
{
    public partial class ChatView : ContentView
    {
        public ChatModel Chat { get { return (ChatModel)GetValue(ChatProperty); } set { SetValue(ChatProperty, value); } }
        public static readonly BindableProperty ChatProperty = BindableProperty.Create(nameof(Chat), typeof(ChatModel), typeof(ChatView), null);

        public ChatView()
        {
            InitializeComponent();
        }

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
            txtTitle.Text = Chat.Name;
            txtDescription.Text = Chat.Message;
            photoUser.Source = Chat.PhotoUrl;
        }
    }
}

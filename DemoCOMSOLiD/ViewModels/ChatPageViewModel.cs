using System;
using System.Collections.ObjectModel;
using DemoCOMSOLiD.Models;

namespace DemoCOMSOLiD.ViewModels
{
    public class ChatPageViewModel
    {
        public ObservableCollection<ChatModel> Chats { get; set; } = new ObservableCollection<ChatModel>();

        public ChatPageViewModel()
        {
            Chats.Add(new ChatModel { Name = "234234", Message = "234234", PhotoUrl = "https://www.geek.com/wp-content/uploads/2017/09/maxresdefault-625x352.jpg" });
            Chats.Add(new ChatModel { Name = "234234", Message = "234234", PhotoUrl = "https://www.geek.com/wp-content/uploads/2017/09/maxresdefault-625x352.jpg" });
            Chats.Add(new ChatModel { Name = "234234", Message = "234234", PhotoUrl = "https://www.geek.com/wp-content/uploads/2017/09/maxresdefault-625x352.jpg" });
            Chats.Add(new ChatModel { Name = "234234", Message = "234234", PhotoUrl = "https://www.geek.com/wp-content/uploads/2017/09/maxresdefault-625x352.jpg" });
            Chats.Add(new ChatModel { Name = "234234", Message = "234234", PhotoUrl = "https://www.geek.com/wp-content/uploads/2017/09/maxresdefault-625x352.jpg" });
            Chats.Add(new ChatModel {  Name = "234234", Message = "234234", PhotoUrl = "https://www.geek.com/wp-content/uploads/2017/09/maxresdefault-625x352.jpg" });
        }

    }
}

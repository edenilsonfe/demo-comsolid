using System;
using System.Collections.ObjectModel;
using DemoCOMSOLiD.Models;

namespace DemoCOMSOLiD.ViewModels
{
    public class SingleChatPageViewModel
    {
        public ObservableCollection<ChatModel> Chats { get; set; } = new ObservableCollection<ChatModel>()
        {
            //new ChatModel { Name = "asfsdfsdf", Message = "sdlkfds", PhotoUrl = "323" },
            //new ChatModel { Name = "asfsdfsdf", Message = "sdlkfds", PhotoUrl = "234" },
            //new ChatModel { Name = "asfsdfsdf", Message = "sdlkfds", PhotoUrl = "123" },
            //new ChatModel { Name = "asfsdfsdf", Message = "sdlkfds", PhotoUrl = "1123" },
            //new ChatModel { Name = "asfsdfsdf", Message = "sdlkfds", PhotoUrl = "12312" }
        };



        public string ProfileImage { get; set; }

        public SingleChatPageViewModel(ChatModel chatModel)
        {
            ProfileImage = chatModel.PhotoUrl;
        }
    }
}

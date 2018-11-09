using System;
using System.Collections.ObjectModel;
using DemoCOMSOLiD.Models;

namespace DemoCOMSOLiD.ViewModels
{
    public class ChatsPageViewModel
    {
        public ObservableCollection<ChatModel> Chats { get; set; } = new ObservableCollection<ChatModel>();

        public ChatsPageViewModel()
        {
            Chats.Add(new ChatModel { Name = "Marty McFly", Message = "If you put your mind to it, you can accomplish anything.", PhotoUrl = "https://i.imgflip.com/2/e4t4k.jpg" });
            Chats.Add(new ChatModel { Name = "Dr. Emmett Brown", Message = "Roads? Where we are going we don`t need roads", PhotoUrl = "http://www.georgefiorini.eu/images/ritorno-al-futuro/doc-brown.jpg" });
            Chats.Add(new ChatModel { Name = "Will", Message = "Cara, to precisando passar uns dias ai em bell-air", PhotoUrl = "https://www.deveserisso.com.br/blog/wp-content/uploads/2016/12/series-anos-90-um-maluco-no-pedaco-150x150.jpg" });
            Chats.Add(new ChatModel { Name = "Rochelle", Message = "Eu não preciso disso, meu marido tem 2 empregos, EU ME DEMIIIITOO", PhotoUrl = "http://rederecord.r7.com/wp-content/blogs.dir/21/files/veja-as-caras-e-bocas-que-so-a-rochelle-consegue-fazer/9.jpg" });
            Chats.Add(new ChatModel { Name = "234234", Message = "234234", PhotoUrl = "" });
            Chats.Add(new ChatModel { Name = "234234", Message = "234234", PhotoUrl = "" });
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            //Pust some logic here
            FakePush(name, message);
            PushUsers(name);
        }

        public void FakePush(string name, string message)
        {

            Clients.All.addNewMessageToPage(name, message);
        }

        public void PushUsers(string name)
        {

            Clients.All.pushUsersToPage(name);
        }
    }
}
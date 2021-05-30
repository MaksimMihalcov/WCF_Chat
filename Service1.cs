using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace WCF_Chat
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        private List<ServerUser> users = new List<ServerUser>();
        private int nextId = 1;

        public int Connect(string name)
        {
            ServerUser serverUser = new ServerUser()
            {
                ID = nextId,
                Name = name,
                operationContext = OperationContext.Current
            };
            ++nextId;
            Send_Msg(": " + serverUser.Name + " connected to chat.", 0);
            users.Add(serverUser);
            return serverUser.ID;
        }

        public void Disconnect(int id)
        {
            ServerUser serverUser = users.FirstOrDefault(i => i.ID == id));
            if (serverUser == null)
                return;
            users.Remove(serverUser);
            Send_Msg(": " + serverUser.Name + " disconnected.", 0);
        }

        public void Send_Msg(string msg, int id)
        {
            foreach (ServerUser user in users)
            {
                string str = DateTime.Now.ToShortTimeString();
                ServerUser serverUser = users.FirstOrDefault(i => i.ID == id);
                if (serverUser != null)
                    str = str + ": " + serverUser.Name + ": ";
                string mesg = str + msg;
                user.operationContext.GetCallbackChannel<IServerChatCallBack>().MsgCallBack(mesg);
            }
        }
    }
}

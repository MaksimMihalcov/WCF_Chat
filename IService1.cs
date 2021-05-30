using System.ServiceModel;

namespace WCF_Chat
{
    [ServiceContract(CallbackContract = typeof(IServerChatCallBack))]
    public interface IService1
    {
        [OperationContract]
        int Connect(string name);

        [OperationContract]
        void Disconnect(int id);

        [OperationContract(IsOneWay = true)]
        void Send_Msg(string msg, int id);
    }

    public interface IServerChatCallBack
    {
        [OperationContract(IsOneWay = true)]
        void MsgCallBack(string mesg);
    }
}

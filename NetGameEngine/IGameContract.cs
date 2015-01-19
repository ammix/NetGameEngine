using System;
using System.ServiceModel;

namespace NetGameEngine
{
    [ServiceContract(CallbackContract = typeof(IGameContractCallback))]
    public interface IGameContract
    {
        [OperationContract]
        void ClientMove(string shoot);

        [OperationContract]
        void Connect();

        [OperationContract]
        void Disconnect();
    }

    [ServiceContract]
    public interface IGameContractCallback
    {
        [OperationContract]
        void ServerMove(string shoot);
    }
}

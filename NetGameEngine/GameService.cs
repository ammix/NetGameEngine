using System;
using System.ServiceModel;
using System.Collections.Generic;

namespace NetGameEngine
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class GameService : IGameContract
    {
        private IGameContractCallback callback;

        public event Action<string> ClientMoved;

        //[OperationBehavior(Impersonation = ImpersonationOption.Required)]
        public void Connect()
        {
            callback = OperationContext.Current.GetCallbackChannel<IGameContractCallback>();
        }

        //[OperationBehavior(Impersonation = ImpersonationOption.Required)]
        public void ClientMove(string shoot)
        {
            if (ClientMoved != null)
                ClientMoved(shoot);
        }

        public void ServerMove(string shoot)
        {
            callback.ServerMove(shoot);
        }

        public void Disconnect()
        {
            // TODO
        }
    }
}
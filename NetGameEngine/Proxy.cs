using System.ServiceModel;
using System.ServiceModel.Channels;

namespace NetGameEngine
{
    public partial class GameContractClient : ClientBase<IGameContract>, IGameContract
    {
        public GameContractClient()
        {
        }

        public GameContractClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public GameContractClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public GameContractClient(string endpointConfigurationName, EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public GameContractClient(Binding binding, EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public GameContractClient(InstanceContext callbackInstance, Binding binding, EndpointAddress remoteAddress) :
            base(callbackInstance, binding, remoteAddress)
        {
        }

        public void ClientMove(string shoot)
        {
            base.Channel.ClientMove(shoot);
        }

        public void Connect()
        {
            base.Channel.Connect();
        }

        public void Disconnect()
        {
            base.Channel.Disconnect();
        }
    }
}
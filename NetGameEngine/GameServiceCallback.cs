using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetGameEngine
{
    public class GameServiceCallback: IGameContractCallback
    {
        public event Action<string> ServerMoved;

        public void ServerMove(string shoot)
        {
            if (ServerMoved != null)
                ServerMoved(shoot);
        }
    }
}

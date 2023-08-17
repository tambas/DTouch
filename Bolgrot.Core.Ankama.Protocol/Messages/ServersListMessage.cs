using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolgrot.Core.Ankama.Protocol.Types;

namespace Bolgrot.Core.Ankama.Protocol.Messages
{
    public class ServersListMessage : NetworkMessage
    {

	    public GameServerInformations[] servers;


        public ServersListMessage()
        {
        }

        public ServersListMessage(GameServerInformations[] servers)
        {
            this.servers = servers;

        }
    }
}
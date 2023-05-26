using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

using DesignPatterns.Factory.NetworkUtilities;

namespace DesignPatterns.Factory.NetworkFactory
{
    public class NetworkFactory
    {
        public INetwork GetNetworkInstance(string type)
        {
            INetwork obj = null;

            if (type.ToLower().Equals("ping"))
            {
                obj = new Ping();
            }
            else if (type.ToLower().Equals("arp"))
            {
                obj = new ARP();
            }
            else if (type.ToLower().Equals("dns"))
            {
                obj = new DNS();
            }
            else
            {
                throw new Exception("Invalid network type.");
            }

            return obj;
        }
    }
}
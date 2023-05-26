// See https://aka.ms/new-console-template for more information

using DesignPatterns.Singleton;
using DesignPatterns.Factory.NetworkFactory;
using DesignPatterns.Facade;

// Singleton
Singleton singleton1 = Singleton.Instance();
Singleton singleton2 = Singleton.Instance();

if (singleton1 == singleton2)
{
    Console.WriteLine("singleton1 and singleton2 are the same instance");
}

// Factory
NetworkFactory factory = new NetworkFactory();

var arp = factory.GetNetworkInstance("arp");
var dns = factory.GetNetworkInstance("dns");
var ping = factory.GetNetworkInstance("ping");

arp.SendRequest("1.1.1.1", 5);
dns.SendRequest("1.1.1.1", 1);
ping.SendRequest("2.321.22.222", 2);


// Facade
NetworkFacade networkFacade = new NetworkFacade("1.1.1.1", "UDP");

networkFacade.BuildNetworkLayer();
networkFacade.SendPacketOverNetwork();

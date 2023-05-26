namespace DesignPatterns.Facade
{
    public class NetworkFacade
    {
        private Packet packet;
        private Socket socket;
        private Transmission transmission;

        public NetworkFacade(string ip, string protocol)
        {
            packet = new Packet(ip);
            socket = new Socket(protocol);
            transmission = new Transmission(protocol);
        }

        public void BuildNetworkLayer()
        {
            packet.PacketBuilt();
            socket.BuildSocket();
        }

        public void SendPacketOverNetwork()
        {
            BuildNetworkLayer();
            transmission.SendTransmission();
        }
    }
}
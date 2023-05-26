namespace DesignPatterns.Factory.NetworkUtilities
{
    public interface INetwork
    {
        void SendRequest(string ip, int timesSent);

    }
}
namespace DesignPatterns.Factory.NetworkUtilities
{
    public class ARP : INetwork
    {
        public void SendRequest(string ip, int timesSent)
        {
            Console.WriteLine($"ARP request sent to {ip} {timesSent} times.");
        }
    }
}
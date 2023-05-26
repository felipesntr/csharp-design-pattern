namespace DesignPatterns.Factory.NetworkUtilities
{
    public class Ping : INetwork
    {
        public void SendRequest(string ip, int timesSent)
        {
            Console.WriteLine($"Ping request sent to {ip} {timesSent} times.");
        }
    }
}
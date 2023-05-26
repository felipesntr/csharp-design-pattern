namespace DesignPatterns.Factory.NetworkUtilities
{
    public class DNS : INetwork
    {
        public void SendRequest(string ip, int timesSent)
        {
            Console.WriteLine($"DNS request sent to {ip} {timesSent} times.");
        }
    }
}
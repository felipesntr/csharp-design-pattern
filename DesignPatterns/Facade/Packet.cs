using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace DesignPatterns.Facade
{
    public class Packet
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string Ip { get; set; }
        public Packet(string ip)
        {
            Ip = ip;

        }

        public void PacketBuilt()
        {
            Console.WriteLine($"Packet built");
        }
    }
}
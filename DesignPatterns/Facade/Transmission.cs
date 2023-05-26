using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace DesignPatterns.Facade
{
    public class Transmission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Transmission(string protocolNname)
        {
            Name = protocolNname;
        }
        public void SendTransmission()
        {
            Console.WriteLine($"Sent Transmission");
        }
    }
}
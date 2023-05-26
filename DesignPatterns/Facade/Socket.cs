using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace DesignPatterns.Facade
{
    public class Socket
    {
        public int Id { get; set; }
        public int Port { get; set; }
        public string Protocol { get; set; }
        public Socket(string protocol)
        {
            Protocol = protocol;
        }
        public void BuildSocket()
        {
            Console.WriteLine($"Build Socket");
        }
    }
}
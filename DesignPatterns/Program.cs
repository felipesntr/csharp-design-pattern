// See https://aka.ms/new-console-template for more information

using DesignPatterns.Singleton;

Singleton singleton1 = Singleton.Instance();
Singleton singleton2 = Singleton.Instance();

if (singleton1 == singleton2)
{
    Console.WriteLine("singleton1 and singleton2 are the same instance");
}
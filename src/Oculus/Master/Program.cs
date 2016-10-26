using System;
using Akka.Actor;

namespace Master
{
    class Program
    {
        static void Main(string[] args)
        {
            var actorSystem = ActorSystem.Create("Oculus");

            var master = actorSystem.ActorOf<MasterActor>("Master");

            master.Tell(new Appear("Test"));

            Console.ReadLine();
        }
    }
}

using System;
using Akka.Actor;

namespace Master
{
    public class MasterActor : TypedActor, IHandle<Appear>
    {
        public void Handle(Appear message)
        {
            Console.WriteLine($"Look who's here: {message.ServerName}");
        }
    }
}
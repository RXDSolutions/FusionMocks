using System;

namespace Sophis.Event
{
    public abstract class EventBase : IEvent
    {
        public abstract int What { get; }

        public abstract string EventCategory { get; }

        public abstract int PacketClass { get; }

        public abstract int PacketId { get; }

        public abstract bool HasHighPriority { get; }

        public string SenderHost { get; set; }

        public int SenderPID { get; set; }

        public int SenderId { get; set; }

        public int SenderUser { get; set; }

        public int EventId { get; set; }

        public long CreationTime { get; set; }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophis.Event
{
    public interface IEvent : ICloneable
    {
        string SenderHost { get; set; }

        int SenderPID { get; set; }

        int SenderId { get; set; }

        int SenderUser { get; set; }

        int EventId { get; set; }

        long CreationTime { get; set; }

        int What { get; }

        string EventCategory { get; }

        int PacketClass { get; }

        int PacketId { get; }

        bool HasHighPriority { get; }
    }
}

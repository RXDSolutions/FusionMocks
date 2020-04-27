using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sophis.Event
{
    public class UserEvent : GenericEvent, IDisposable
    {
        public void Dispose()
        {
        }

        public static int ClassWhat { get; }

        public override int What { get; }

        public override string EventCategory { get; }

        public override int PacketClass { get; }

        public override int PacketId { get; }

        public override bool HasHighPriority { get; }
    }
}

//  Copyright (c) RXD Solutions. All rights reserved.
//  FusionLink is licensed under the MIT license. See LICENSE.txt for details.

using System;

namespace Sophis.Event
{
    public delegate void SophisEventHandler(IEvent evt, ref bool deleteEvent);

    public class SophisEventManager : IDisposable
    {
        private static Lazy<SophisEventManager> sophisEventManager = new Lazy<SophisEventManager>();

        private SophisEventManager()
        {
        }

        public static SophisEventManager Instance
        {
            get
            {
                return sophisEventManager.Value;
            }
        }

        public unsafe void AddHandler(SophisEventHandler handler, Thread thread, Layer layer)
        {

        }

        public void Dispatch()
        {

        }

        public unsafe virtual void Send(IEvent evt, bool isLocalEvent, bool isRemoteEvent)
        {
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
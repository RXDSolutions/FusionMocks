namespace Sophis.Event
{
    public abstract class GenericEvent : EventBase
    {
        public unsafe int GetLongAt(int index)
        {
            return 0;
        }

        public int GetTag(int index)
        {
            return 0;
        }

        public int FindTag(int tag)
        {
            return 0;
        }
    }
}

namespace Sophis.Windows.Ribbon
{
    public abstract class RibbonBuilder
    {
        public static RibbonBuilder Instance { get; set; }

        public void BuildRibbon(RRibbon ribbon)
        {

        }

        public RRibbon GetRibbon()
        {
            return new RRibbon();
        }
    }
}

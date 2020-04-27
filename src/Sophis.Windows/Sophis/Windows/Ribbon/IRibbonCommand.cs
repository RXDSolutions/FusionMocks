using System.Windows.Input;

namespace Sophis.Windows.Ribbon
{
    public interface IRibbonCommand
    {
        string IdQ { get; }

        int CommandId { get; }

        string RibbonLabel { get; }

        string SmallImage { get; }

        string LargeImage { get; }

        string Description { get; }

        ControlType Type { get; }

        RoutedUICommand Command { get; }

        InputGestureCollection KeyGestures { get; }
    }
}
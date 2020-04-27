using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Sophis.Windows.Ribbon
{
    public class RibbonCommand : RoutedUICommand, IRibbonCommand
    {
        public string IdQ => base.Name;

        public int CommandId { get; internal set; }

        public string RibbonLabel => base.Text;

        public string SmallImage { get; private set; }

        public string LargeImage { get; private set; }

        public string Description { get; set; }

        public ControlType Type { get; set; }

        public RoutedUICommand Command => this;

        public InputGestureCollection KeyGestures => this.InputGestures;

        public RibbonCommand(string text, string name, Type ownerType, string image) : this(text, name, ownerType, image, image, null)
        {
        }

        public RibbonCommand(string text, string name, Type ownerType, string smallImage, string largeImage) : this(text, name, ownerType, smallImage, largeImage, null)
        {
        }

        public RibbonCommand(string text, string name, Type ownerType, string image, InputGestureCollection inputGestures) : this(text, name, ownerType, image, image, inputGestures)
        {
        }

        public RibbonCommand(string text, string name, Type ownerType, string smallImage, string largeImage, InputGestureCollection inputGestures, ControlType ctrlType = ControlType.Button) : base(text, name, ownerType, inputGestures)
        {
        }
    }
}

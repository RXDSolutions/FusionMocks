using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace Sophis.Windows
{
    public class SophisApplication : Application, IComponentConnector
    {
        public static SophisApplication MainApp => (SophisApplication)Application.Current;

        public UIElement CommandTarget
        {
            get
            {
                return new Grid();
            }
        }

        public static UIElement MainCommandTarget => MainApp.CommandTarget;

        public void Connect(int connectionId, object target)
        {
        }

        public void InitializeComponent()
        {
        }
    }
}

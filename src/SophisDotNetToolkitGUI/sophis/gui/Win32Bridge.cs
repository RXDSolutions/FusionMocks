using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sophis.sophis.gui
{
    public class Win32Bridge
    {
        public unsafe static IntPtr GetMainWindow()
        {
            return IntPtr.Zero;
        }

        public unsafe static int GetChildWindowCount(IntPtr hwnd)
        {
            return 0;
        }

        public unsafe static IntPtr GetNthChildWindow(IntPtr hwnd, int i)
        {
            return IntPtr.Zero;
        }
    }
}

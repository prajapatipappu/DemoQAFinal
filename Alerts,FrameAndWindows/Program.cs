using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alerts_FrameAndWindows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Browser_Windows.Browser_Window();
            Alerts.Alert();
            ModalDialogs.modal();
        }
    }
}

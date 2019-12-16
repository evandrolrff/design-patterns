using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge {
    class LinuxWindow : ImplementedWindow {
        public void DrawButton(string title) {
            Console.WriteLine("\n{0} - Linux button", title);
        }

        public void DrawWindow(string title) {
            Console.WriteLine("\n{0} - Linux window", title);
        }
    }
}

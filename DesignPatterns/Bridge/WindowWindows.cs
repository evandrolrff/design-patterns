using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge {
    class WindowWindows : ImplementedWindow {
        public void DrawButton(string title) {
            Console.WriteLine("\n{0} - Windows button", title);
        }

        public void DrawWindow(string title) {
            Console.WriteLine("\n{0} - Windows window", title);
        }
    }
}

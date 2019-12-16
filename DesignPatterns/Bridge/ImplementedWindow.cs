using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge {
    interface ImplementedWindow {

        void DrawWindow(string title);

        void DrawButton(string title);
    }
}

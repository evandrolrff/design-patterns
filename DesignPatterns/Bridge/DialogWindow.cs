using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge {
    class DialogWindow : AbstractWindow {

        public DialogWindow(ImplementedWindow implementedW) : base(implementedW) { }

        public override void Draw() {
            DrawWindow("Dialog Window");
            DrawButton("Button No");
            DrawButton("Button Yes");
            DrawButton("Button Cancel");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge {
    class AlertWindow : AbstractWindow {
        
        public AlertWindow(ImplementedWindow implemented) : base(implemented) { }

        public override void Draw() {
            DrawWindow("Alert Window");
            DrawButton("Button OK");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge {
    abstract class AbstractWindow {

        protected ImplementedWindow window;

        public AbstractWindow(ImplementedWindow implemented) {
            window = implemented;
        }

        public void DrawWindow(string title) {
            window.DrawWindow(title);
        }

        public void DrawButton(string title) {
            window.DrawButton(title);
        }

        public abstract void Draw();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge {
    class Client {

        public Client() {
            AbstractWindow window = new DialogWindow(new LinuxWindow());
            window.Draw();

            window = new AlertWindow(new LinuxWindow());
            window.Draw();

            window = new DialogWindow(new WindowWindows());
            window.Draw();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter {
    class Adaptee {

        public string GetSpecificRequest() {
            return "Specific request.";
        }
    }
}
